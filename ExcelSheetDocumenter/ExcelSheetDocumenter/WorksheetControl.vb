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

    Private _Creator As String
    Public Property Creator() As String
        Get
            Return _Creator
        End Get
        Set(ByVal value As String)
            _Creator = value
        End Set
    End Property

    Private _Publisher As String
    Public Property Publisher() As String
        Get
            Return _Publisher
        End Get
        Set(ByVal value As String)
            _Publisher = value
        End Set
    End Property

    Private _PublicationDate As String
    Public Property PublicationDate() As String
        Get
            Return _PublicationDate
        End Get
        Set(ByVal value As String)
            _PublicationDate = value
        End Set
    End Property

    Private _Description As String
    Public Property Description() As String
        Get
            Return _Description
        End Get
        Set(ByVal value As String)
            _Description = value
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

            For Each Column As DataColumn In Me.DataTable.Columns
                Dim NewRow As DataRow = MetadataDataTable.NewRow
                NewRow.Item("ColumnName") = Column.ColumnName
                'units - user defined
                'description - user defined
                NewRow.Item("DataType") = Column.DataType.ToString.Replace("System.", "")
                NewRow.Item("AllowDBNull") = Column.AllowDBNull
                NewRow.Item("Caption") = Column.Caption
                NewRow.Item("DateTimeMode") = Column.DateTimeMode.ToString
                NewRow.Item("DefaultValue") = Column.DefaultValue
                NewRow.Item("MaxLength") = Column.MaxLength
                NewRow.Item("Unique") = Column.Unique
                MetadataDataTable.Rows.Add(NewRow)
            Next
            Me.MetadataDataTable = MetadataDataTable

            'fill the metadata datagridview
            Me.MetadataDataGridView.DataSource = Me.MetadataDataTable
            RefreshControls()
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


    Private Function GetCSV(DataTable As DataTable, MetadataDataTable As DataTable, IncludeColumnsMetadata As Boolean, Delimiter As String, QuoteText As Boolean) As String
        'output columns metadata
        Dim MD As String = "Metadata" & vbNewLine
        For Each MRow As DataRow In MetadataDataTable.Rows
            MD = MD & "Column: " & MRow.Item(0) & ", DataType: " & MRow.Item(1) & ", Units: " & MRow.Item(2) & ", Description: " & MRow.Item(3) & vbNewLine
        Next

        'output the column headers
        Dim ColumnHeaders As String = ""
        For Each Column As DataColumn In DataTable.Columns
            ColumnHeaders = ColumnHeaders & Column.ColumnName & Delimiter
        Next

        Dim CSV As String = IIf(IncludeColumnsMetadata = True, MD, "") & ColumnHeaders & vbNewLine

        'output the data rows
        Dim DataRow As String = ""
        For Each Row As DataRow In DataTable.Rows
            DataRow = ""
            For i As Integer = 0 To DataTable.Columns.Count - 1
                Dim item As String = Row.Item(i).ToString.Trim
                If DataTable.Columns(i).DataType.ToString = "System.String" Or DataTable.Columns(i).DataType.ToString = "System.Date" Or DataTable.Columns(i).DataType.ToString = "System.DateTime" And QuoteText = True Then
                    DataRow = DataRow & """" & item & """" & Delimiter & ","
                Else
                    DataRow = DataRow & item & ","
                End If

            Next
            DataRow = DataRow.Substring(0, DataRow.Trim.Length - 1) & vbNewLine
            CSV = CSV & DataRow
        Next
        Return CSV
    End Function


    Private Function GetDataProtocolsDataPackageJSON(Filename As String, DataTable As DataTable, MetadataDataTable As DataTable, Delimiter As String) As String

        Dim JSON As String = ""
        JSON = JSON & "{" & vbNewLine
        JSON = JSON & vbTab & """name"": """ & Me.Filename & """," & vbNewLine
        JSON = JSON & vbTab & """csvddfVersion"": 1.0," & vbNewLine
        JSON = JSON & vbTab & """delimiter"": """ & Delimiter & """," & vbNewLine
        JSON = JSON & vbTab & """doubleQuote"": true," & vbNewLine
        JSON = JSON & vbTab & """quoteChar"": """"""," & vbNewLine
        JSON = JSON & vbTab & """skipInitialSpace"": true," & vbNewLine
        JSON = JSON & vbTab & """header"": true" & vbNewLine
        JSON = JSON & vbTab & """resources"": [" & vbNewLine
        JSON = JSON & vbTab & vbTab & "{" & vbNewLine
        JSON = JSON & vbTab & vbTab & vbTab & """path"": ""data.csv""," & vbNewLine
        JSON = JSON & vbTab & vbTab & vbTab & """schema"": {" & vbNewLine
        JSON = JSON & vbTab & vbTab & vbTab & vbTab & """fields"": [" & vbNewLine

        'output the columns metadata
        Dim i As Integer = 1
        For Each Row As DataRow In MetadataDataTable.Rows
            Dim ColumnName As String = ""
            If Not IsDBNull(Row.Item("ColumnName")) Then
                ColumnName = Row.Item("ColumnName").ToString
            Else
                ColumnName = ""
            End If

            Dim DataType As String = ""
            If Not IsDBNull(Row.Item("DataType")) Then
                DataType = Row.Item("DataType").ToString
            Else
                DataType = ""
            End If

            Dim Units As String = ""
            If Not IsDBNull(Row.Item("Units")) Then
                Units = Row.Item("Units").ToString
            Else
                Units = ""
            End If

            Dim Description As String = ""
            If Not IsDBNull(Row.Item("Description")) Then
                Description = Row.Item("Description").ToString
            Else
                Description = ""
            End If
            JSON = JSON & vbTab & vbTab & vbTab & vbTab & vbTab & "[" & vbNewLine
            JSON = JSON & vbTab & vbTab & vbTab & vbTab & vbTab & vbTab & "{" & vbNewLine
            JSON = JSON & vbTab & vbTab & vbTab & vbTab & vbTab & vbTab & vbTab & """name"": """ & ColumnName & """," & vbNewLine
            JSON = JSON & vbTab & vbTab & vbTab & vbTab & vbTab & vbTab & vbTab & """type"": """ & DataType & """," & vbNewLine
            JSON = JSON & vbTab & vbTab & vbTab & vbTab & vbTab & vbTab & vbTab & """units"": """ & Units & """," & vbNewLine
            JSON = JSON & vbTab & vbTab & vbTab & vbTab & vbTab & vbTab & vbTab & """description"": """ & Description & """" & vbNewLine
            JSON = JSON & vbTab & vbTab & vbTab & vbTab & vbTab & vbTab & "}" & vbNewLine
            JSON = JSON & vbTab & vbTab & vbTab & vbTab & vbTab & "]" & IIf(i < MetadataDataTable.Rows.Count, ",", "") & vbNewLine
            i = i + 1
        Next

        JSON = JSON & vbTab & vbTab & vbTab & vbTab & "]" & vbNewLine
        JSON = JSON & vbTab & vbTab & vbTab & "}" & vbNewLine
        JSON = JSON & vbTab & vbTab & "}" & vbNewLine
        JSON = JSON & vbTab & "]" & vbNewLine
        JSON = JSON & "}" & vbNewLine
        Return JSON
    End Function



    Private Function GetSkeeterJSON(Filename As String, DataTable As DataTable, MetadataDataTable As DataTable) As String

        Dim JSON As String = ""
        JSON = JSON & "{" & vbNewLine
        JSON = JSON & vbTab & " ""filename"": """ & Me.Filename & """," & vbNewLine
        JSON = JSON & vbTab & " ""creator"": """ & Me.Creator & """," & vbNewLine
        JSON = JSON & vbTab & " ""publisher"": """ & Me.Publisher & """," & vbNewLine
        JSON = JSON & vbTab & " ""publication_date"": """ & Me.PublicationDate & """," & vbNewLine
        JSON = JSON & vbTab & " ""file_description"": """ & Me.Description & """," & vbNewLine
        JSON = JSON & vbTab & " ""columns"": [" & vbNewLine

        'output the columns metadata
        Dim i As Integer = 1
        For Each Row As DataRow In MetadataDataTable.Rows
            Dim ColumnName As String = ""
            If Not IsDBNull(Row.Item("ColumnName")) Then
                ColumnName = Row.Item("ColumnName").ToString
            Else
                ColumnName = ""
            End If

            Dim DataType As String = ""
            If Not IsDBNull(Row.Item("DataType")) Then
                DataType = Row.Item("DataType").ToString
            Else
                DataType = ""
            End If

            Dim Units As String = ""
            If Not IsDBNull(Row.Item("Units")) Then
                Units = Row.Item("Units").ToString
            Else
                Units = ""
            End If

            Dim Description As String = ""
            If Not IsDBNull(Row.Item("Description")) Then
                Description = Row.Item("Description").ToString
            Else
                Description = ""
            End If
            JSON = JSON & vbTab & vbTab & "  [" & vbNewLine
            JSON = JSON & vbTab & vbTab & vbTab & vbTab & "{" & vbNewLine
            JSON = JSON & vbTab & vbTab & vbTab & vbTab & vbTab & " ""columnname"": """ & ColumnName & """," & vbNewLine
            JSON = JSON & vbTab & vbTab & vbTab & vbTab & vbTab & " ""datatype"": """ & DataType & """," & vbNewLine
            JSON = JSON & vbTab & vbTab & vbTab & vbTab & vbTab & " ""units"": """ & Units & """," & vbNewLine
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
        MetadataDataTable.Columns.Add("Units", System.Type.GetType("System.String"))
        MetadataDataTable.Columns.Add("Description", System.Type.GetType("System.String"))
        MetadataDataTable.Columns.Add("DataType", System.Type.GetType("System.String"))
        MetadataDataTable.Columns.Add("AllowDBNull", System.Type.GetType("System.Boolean"))
        MetadataDataTable.Columns.Add("Caption", System.Type.GetType("System.String"))
        MetadataDataTable.Columns.Add("DateTimeMode", System.Type.GetType("System.String"))
        MetadataDataTable.Columns.Add("DefaultValue", System.Type.GetType("System.String"))
        MetadataDataTable.Columns.Add("MaxLength", System.Type.GetType("System.String"))
        MetadataDataTable.Columns.Add("Unique", System.Type.GetType("System.String"))

        Return MetadataDataTable
    End Function



    'Private Sub UpdateExportTextboxes()
    '    Me.CSVTextBox.Text = GetCSV(Me.DataTable, Me.MetadataDataTable)
    '    Me.JSONTextBox.Text = GetSkeeterJSON(Me.Filename, Me.DataTable, Me.MetadataDataTable)
    'End Sub

    Private Sub MetadataDataGridView_CellEndEdit(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles MetadataDataGridView.CellEndEdit
        'RefreshControls()
    End Sub

    Public Sub RefreshControls()
        'load the text file formats
        Me.JSONTextBox.Text = GetSkeeterJSON(Me.Filename, Me.DataTable, Me.MetadataDataTable) 'GetCSV(me.datatable, MetadataDataTable)
        Me.CSVTextBox.Text = GetCSV(Me.DataTable, Me.MetadataDataTable, False, "|", True)
        Me.DataPackageTextBox.Text = GetDataProtocolsDataPackageJSON(Me.Filename, Me.DataTable, Me.MetadataDataTable, "|")
        'fill the property grid with the datatable properties
        Me.WorksheetPropertyGrid.SelectedObject = Me.DataTable
    End Sub

    Private Sub ToolStripLabel1_Click(sender As System.Object, e As System.EventArgs)
        RefreshControls()
    End Sub

    Private Sub ExportJSONToolStripButton_Click(sender As System.Object, e As System.EventArgs) Handles ExportJSONToolStripButton.Click
        ExportFile(Me.JSONTextBox.Text.Trim, "json", False)
    End Sub

    Private Sub ExportFile(ExportText As String, FileExtension As String, IsDatasourceFile As Boolean)
        Dim SF As New SaveFileDialog
        SF.Filter = "Text file |*." & FileExtension.Trim

        If IsDatasourceFile = False Then
            SF.FileName = Me.Filename.Trim & "." & FileExtension.Trim
        Else
            SF.FileName = "datapackage.json"
        End If


        If SF.ShowDialog = Windows.Forms.DialogResult.OK Then
            My.Computer.FileSystem.WriteAllText(SF.FileName, ExportText, False)
        End If
    End Sub

    Private Sub ExportCSVToolStripButton_Click(sender As System.Object, e As System.EventArgs) Handles ExportCSVToolStripButton.Click
        ExportFile(Me.JSONTextBox.Text.Trim, "csv", False)
    End Sub

    Private Sub ToolStripButton2_Click(sender As System.Object, e As System.EventArgs) Handles ExportDataPackageToolStripButton.Click
        ExportFile(Me.CSVTextBox.Text, "csv", False)
        ExportFile(Me.DataPackageTextBox.Text, "json", True)
    End Sub

    Private Sub DataPackageToolStripLabel_Click(sender As System.Object, e As System.EventArgs) Handles DataPackageToolStripLabel.Click
        Process.Start(DataPackageToolStripLabel.Text)
    End Sub

    Private Sub MetadataDataGridView_CellValueChanged(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles MetadataDataGridView.CellValueChanged
        RefreshControls()
    End Sub
End Class
