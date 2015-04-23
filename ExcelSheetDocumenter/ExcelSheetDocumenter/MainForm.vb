Imports System.Data.OleDb
Imports Microsoft.Office.Interop

Public Class MainForm

    Dim MyDataset As New DataSet

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'GetExcelSheetNames("C:\Work\VitalSigns\ARCN Caribou\Datasets\2015 PLosOne Paper Data\PLOSONE-Data-2012-2013-Diet-Hormone.xlsx")
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
        Me.TabControl1.Controls.Clear()
        Me.FilenameTextBox.Text = ""

        Try
            Dim MyConnectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Filename & ";Extended Properties=""Excel 12.0 Xml;HDR=YES"";"
            Dim MyConnection As New OleDbConnection(MyConnectionString)
            MyConnection.Open()

            'get a list of the sheets in the workbook
            Dim SheetsDataTable As DataTable = MyConnection.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, Nothing)
            Dim SheetsList As New List(Of String)
            'Dim SheetsDataRow As DataRow
            For Each SheetsDataRow In SheetsDataTable.Rows
                SheetsList.Add(SheetsDataRow("TABLE_NAME").ToString())
            Next

            Dim MyDataSet As New DataSet()
            Dim i As Integer = 0
            For Each Sheet As String In SheetsList
                Dim SheetDataTable As New DataTable(Sheet)

                Dim MyCommand As New OleDbCommand("SELECT * FROM [" & Sheet & "]", MyConnection)
                Dim MyDataAdapter As New OleDbDataAdapter(MyCommand)

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
                i = i + 1
            Next
            MyConnection.Close()
        Catch ex As Exception
            MsgBox(ex.Message & " " & System.Reflection.MethodBase.GetCurrentMethod.Name)
        End Try

    End Sub

    'Sub DataTable2CSV(ByVal table As DataTable, ByVal filename As String, ByVal sepChar As String)
    '    Dim writer As System.IO.StreamWriter
    '    Try
    '        writer = New System.IO.StreamWriter(filename)

    '        ' first write a line with the columns name
    '        Dim sep As String = ""
    '        Dim builder As New System.Text.StringBuilder
    '        For Each col As DataColumn In table.Columns
    '            builder.Append(sep).Append(col.ColumnName)
    '            sep = sepChar
    '        Next
    '        writer.WriteLine(builder.ToString())

    '        ' then write all the rows
    '        For Each row As DataRow In table.Rows
    '            sep = ""
    '            builder = New System.Text.StringBuilder

    '            For Each col As DataColumn In table.Columns
    '                builder.Append(sep).Append(row(col.ColumnName))
    '                sep = sepChar
    '            Next
    '            writer.WriteLine(builder.ToString())
    '        Next
    '    Finally
    '        If Not writer Is Nothing Then writer.Close()
    '    End Try
    'End Sub

    Private Sub Export(Workbook As String, Delimiter As String)
        If Delimiter.Trim = "" Then Delimiter = "|"
        Dim MyFileInfo As New System.IO.FileInfo(Workbook)
        For Each Table As DataTable In MyDataset.Tables
            'DataTable2CSV(Table, "C:\temp\z" & MyFileInfo.Name & "-" & Table.TableName & ".csv", Delimiter)
        Next
    End Sub


    Private Sub OpenToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles OpenToolStripMenuItem.Click
        Dim Workbook As String = OpenFile()
        Dim MyFileInfo As New System.IO.FileInfo(Workbook)
        Me.FilenameTextBox.Text = MyFileInfo.Name
        GetData(Workbook)
    End Sub

    Private Sub ExportToPipeSeparatedValuesToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ExportToPipeSeparatedValuesToolStripMenuItem.Click

    End Sub
End Class
