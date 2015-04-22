Imports System.Data.OleDb
Imports Microsoft.Office.Interop

Public Class Form1

    Dim MyDataTable As New DataTable

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'GetExcelSheetNames("C:\Work\VitalSigns\ARCN Caribou\Datasets\2015 PLosOne Paper Data\PLOSONE-Data-2012-2013-Diet-Hormone.xlsx")
    End Sub

    Private Function OpenFile() As String
        Dim OFD As New OpenFileDialog
        With OFD
            .AddExtension = True
            .CheckFileExists = True
            .Filter = "Excel files (*.xls)|*.xls|Excel files(.xlsx)|*.xlsx"
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
        Dim MyConnectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Filename & ";Extended Properties=""Excel 12.0 Xml;HDR=YES"";"
        Dim MyConnection As New OleDbConnection(MyConnectionString)
        MyConnection.Open()

        'get a list of the sheets in the workbook
        Dim SheetsDataTable As DataTable = MyConnection.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, Nothing)
        Dim SheetsList As New List(Of String)
        Dim SheetsDataRow As DataRow
        For Each SheetsDataRow In SheetsDataTable.Rows
            SheetsList.Add(SheetsDataRow("TABLE_NAME").ToString())
        Next
        'For Each Sheet As String In SheetsList
        '    Debug.Print(Sheet)
        'Next

        If Not SheetsList(0) Is Nothing Then
            Dim SheetName As String = SheetsList(0)
            Dim MyCommand As New OleDbCommand("SELECT * FROM [" & SheetName & "]", MyConnection)
            Dim MyDataAdapter As New OleDbDataAdapter(MyCommand)
            MyDataAdapter.Fill(MyDataTable)
            MyDataGridView.DataSource = MyDataTable
        Else
            MsgBox("No sheets")
        End If

        MyConnection.Close()

    End Sub



    Private Sub OpenToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles OpenToolStripMenuItem.Click
        Dim Workbook As String = OpenFile()
        GetData(Workbook)
    End Sub
End Class
