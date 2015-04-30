Imports System.Data.OleDb
Imports Microsoft.Office.Interop

Public Class MainForm

    Dim MyDataset As New DataSet

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        Me.DatasetTitleTextBox.Text = My.Settings.DatasetTitle

    End Sub

    Private Function OpenFile() As String
        MyDataset.Clear()
        Me.TabControl1.Controls.Clear()

        Dim OFD As New OpenFileDialog
        With OFD
            .AddExtension = True
            .CheckFileExists = True
            .Filter = "Excel  files(.xlsx)|*.xlsx|Excel files (*.xls)|*.xls"
            'Text files (*.txt)|*.txt|All files (*.*)|*.*
            .Multiselect = False
            .Title = "Select an workbook to open"
        End With
        If OFD.ShowDialog = Windows.Forms.DialogResult.OK Then
            Return OFD.FileName
        Else
            Return Nothing
        End If
    End Function

    Private Sub GetData(ByVal Filename As String)

        'Try
        Me.TabControl1.Controls.Clear()

        Dim MyConnectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Filename & ";Extended Properties=""Excel 12.0 Xml;HDR=YES"";"
        Dim MyConnection As New OleDbConnection(MyConnectionString)
        MyConnection.Open()

        'get a list of the sheets in the workbook
        Dim SheetsDataTable As DataTable = MyConnection.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, Nothing)
        Dim SheetsList As New List(Of String)

        For Each SheetsDataRow In SheetsDataTable.Rows
            SheetsList.Add(SheetsDataRow("TABLE_NAME").ToString())
        Next

        Dim MyDataSet As New DataSet()
        Dim i As Integer = 0
        For Each Sheet As String In SheetsList
            Dim SheetDataTable As New DataTable(Sheet)

            Dim MyCommand As New OleDbCommand("SELECT * FROM [" & Sheet & "]", MyConnection)
            Dim MyDataAdapter As New OleDbDataAdapter(MyCommand)
            'Try
            MyDataAdapter.Fill(SheetDataTable)
            MyDataSet.Tables.Add(SheetDataTable)

            Dim WorksheetControl As New WorksheetControl
            With WorksheetControl
                .Filename = Me.FilenameTextBox.Text.Trim
                .DataTable = MyDataSet.Tables(i)
                .Show()
                .Dock = DockStyle.Fill
            End With
            Dim TabPage As New TabPage(Sheet)
            TabPage.Controls.Add(WorksheetControl)
            Me.TabControl1.Controls.Add(TabPage)
            'Catch ex As Exception
            '    MsgBox(ex.Message)
            'End Try


            i = i + 1
        Next
        MyConnection.Close()

        'Catch ex As Exception
        '    MsgBox(ex.Message & " " & System.Reflection.MethodBase.GetCurrentMethod.Name)
        'End Try

    End Sub


    Private Sub OpenToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles OpenToolStripMenuItem.Click
        Dim Workbook As String = OpenFile()
        If My.Computer.FileSystem.FileExists(Workbook) Then
            Dim MyFileInfo As New System.IO.FileInfo(Workbook)
            Me.CurrentFileTextBox.Text = MyFileInfo.FullName
            Me.FilenameTextBox.Text = MyFileInfo.Name
            GetData(Workbook)
        Else
            MsgBox("The file " & Workbook & " does not exist on the file system")
            Me.CurrentFileTextBox.Text = ""
        End If
    End Sub


    Private Sub DatasetTitleTextBox_TextChanged(sender As System.Object, e As System.EventArgs) Handles DatasetTitleTextBox.TextChanged
        My.Settings.DatasetTitle = Me.DatasetTitleTextBox.Text.Trim
    End Sub

End Class
