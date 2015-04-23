Public Class WorksheetControl

    Private _Filename As String
    Public Property Filename() As String
        Get
            Return _Filename
        End Get
        Set(ByVal value As String)
            _Filename = value
        End Set
    End Property


    Private _DataTable
    Public Property DataTable() As DataTable
        Get
            Return _DataTable
        End Get
        Set(ByVal value As DataTable)
            _DataTable = value

            'set the control's datagridview to the new datatable
            Me.DataDataGridView.DataSource = _DataTable

            'load metadata about the datasource into a metadata datatable
            Dim MetadataDataTable As DataTable = GetMetadataDataTable()
            Dim DT As DataTable = value.Clone
            For Each Column As DataColumn In DT.Columns
                Dim NewRow As DataRow = MetadataDataTable.NewRow
                NewRow.Item(0) = Column.ColumnName
                NewRow.Item(1) = Column.DataType.ToString.Replace("System.", "")
                MetadataDataTable.Rows.Add(NewRow)
            Next
            Me.MetadataDataTable = MetadataDataTable

            'fill the metadata datagridview
            Me.MetadataDataGridView.DataSource = Me.MetadataDataTable

            Me.CSVTextBox.Text = GetJSON(Me.Filename, Me.DataTable, Me.MetadataDataTable) 'GetCSV(me.datatable, MetadataDataTable)
        End Set
    End Property

    Private _MetadataDataTable
    Public Property MetadataDataTable() As DataTable
        Get
            Return _MetadataDataTable
        End Get
        Set(ByVal value As DataTable)
            _MetadataDataTable = value
        End Set
    End Property


    Private Function GetCSV(DataTable As DataTable, MetadataDataTable As DataTable) As String

        'output columns metadata
        Dim MD As String = "Metadata" & vbNewLine
        For Each MRow As DataRow In MetadataDataTable.Rows
            MD = MD & "Column: " & MRow.Item(0) & ", DataType: " & MRow.Item(1) & ", Units: " & MRow.Item(2) & ", Description: " & MRow.Item(3) & vbNewLine
        Next

        'output the column headers
        Dim ColumnHeaders As String = ""
        For Each Column As DataColumn In DataTable.Columns
            Dim Col As String = Column.ColumnName & ","
            ColumnHeaders = ColumnHeaders & Col
        Next
        Dim CSV As String = MD & ColumnHeaders & vbNewLine

        'output the data rows
        Dim DataRow As String = ""
        For Each Row As DataRow In DataTable.Rows
            For i As Integer = 0 To DataTable.Columns.Count - 1
                DataRow = DataRow & Row.Item(i).ToString.Trim & ","
            Next
            DataRow = DataRow.Substring(0, DataRow.Trim.Length - 1) & vbNewLine
            CSV = CSV & DataRow
        Next
        Return CSV
    End Function

    Private Function GetJSON(Filename As String, DataTable As DataTable, MetadataDataTable As DataTable) As String
        Dim JSON As String = ""
        JSON = JSON & "{" & vbNewLine
        JSON = JSON & vbTab & " ""filename"": """ & Filename & """," & vbNewLine
        JSON = JSON & vbTab & " ""creator"": """"," & vbNewLine
        JSON = JSON & vbTab & " ""publisher"": """"," & vbNewLine
        JSON = JSON & vbTab & " ""date published"": """"," & vbNewLine
        JSON = JSON & vbTab & " ""file_description"": """"," & vbNewLine
        JSON = JSON & vbTab & " ""columns"": [" & vbNewLine

        'output the columns metadata
        Dim i As Integer = 1
        For Each Row As DataRow In MetadataDataTable.Rows
            Dim ColumnName As String = ""
            If Not IsDBNull(Row.Item(0)) Then
                ColumnName = Row.Item(0).ToString
            Else
                ColumnName = ""
            End If

            Dim DataType As String = ""
            If Not IsDBNull(Row.Item(1)) Then
                DataType = Row.Item(1).ToString
            Else
                DataType = ""
            End If

            Dim Unit As String = ""
            If Not IsDBNull(Row.Item(2)) Then
                Unit = Row.Item(2).ToString
            Else
                Unit = ""
            End If

            Dim Description As String = ""
            If Not IsDBNull(Row.Item(3)) Then
                Description = Row.Item(3).ToString
            Else
                Description = ""
            End If
            JSON = JSON & vbTab & vbTab & "  [" & vbNewLine
            JSON = JSON & vbTab & vbTab & vbTab & vbTab & "{" & vbNewLine
            JSON = JSON & vbTab & vbTab & vbTab & vbTab & vbTab & " ""columnname"": """ & ColumnName & """," & vbNewLine
            JSON = JSON & vbTab & vbTab & vbTab & vbTab & vbTab & " ""datatype"": """ & DataType & """," & vbNewLine
            JSON = JSON & vbTab & vbTab & vbTab & vbTab & vbTab & " ""unit"": """ & Unit & """," & vbNewLine
            JSON = JSON & vbTab & vbTab & vbTab & vbTab & vbTab & " ""description"": """ & Description & """" & vbNewLine
            JSON = JSON & vbTab & vbTab & vbTab & vbTab & "}" & vbNewLine
            JSON = JSON & vbTab & vbTab & "  ]" & IIf(i < MetadataDataTable.Rows.Count, ",", "") & vbNewLine
            i = i + 1
        Next

        JSON = JSON & vbTab & " ]," & vbNewLine
        JSON = JSON & vbTab & " ""data"": [" & vbNewLine
        i = 1
        For Each Row As DataRow In DataTable.Rows
            JSON = JSON & vbTab & vbTab & "  {" & vbNewLine
            Dim c As Integer = 1
            For Each Col As DataColumn In DataTable.Columns
                JSON = JSON & vbTab & vbTab & vbTab & vbTab & """" & Col.ColumnName & """: """ & Row.Item(Col.ColumnName).ToString & """" & IIf(c < DataTable.Columns.Count, ",", "") & vbNewLine
                c = c + 1
            Next
            JSON = JSON & vbTab & vbTab & "  }" & IIf(i < DataTable.Rows.Count, ",", "") & vbNewLine
            i = i + 1
        Next
        JSON = JSON & vbTab & " ]" & vbNewLine
        JSON = JSON & "}" & vbNewLine
        Return JSON
    End Function

    Private Function GetMetadataDataTable() As DataTable
        Dim MetadataDataTable As New DataTable("Metadata")
        MetadataDataTable.Columns.Add("ColumnName", System.Type.GetType("System.String"))
        MetadataDataTable.Columns.Add("DataType", System.Type.GetType("System.String"))
        MetadataDataTable.Columns.Add("Units", System.Type.GetType("System.String"))
        MetadataDataTable.Columns.Add("Description", System.Type.GetType("System.String"))
        Return MetadataDataTable
    End Function



    Private Sub UpdateCSV()
        If Not Me.DataTable Is Nothing Then
            Me.CSVTextBox.Text = GetCSV(Me.DataTable, Me.MetadataDataTable)
        End If
    End Sub


    Private Sub MetadataDataGridView_Validated(sender As System.Object, e As System.EventArgs) Handles MetadataDataGridView.Validated
        UpdateCSV()
    End Sub
End Class
