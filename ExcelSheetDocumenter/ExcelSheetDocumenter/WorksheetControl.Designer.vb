<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WorksheetControl
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(WorksheetControl))
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.MetadataDataGridView = New System.Windows.Forms.DataGridView()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.DataTabPage = New System.Windows.Forms.TabPage()
        Me.DataDataGridView = New System.Windows.Forms.DataGridView()
        Me.CSVTabPage = New System.Windows.Forms.TabPage()
        Me.CSVTextBox = New System.Windows.Forms.TextBox()
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip()
        Me.ExportCSVToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.WorksheetPropertiesTabPage = New System.Windows.Forms.TabPage()
        Me.WorksheetPropertyGrid = New System.Windows.Forms.PropertyGrid()
        Me.DataPackageTabPage = New System.Windows.Forms.TabPage()
        Me.DataPackageTextBox = New System.Windows.Forms.TextBox()
        Me.ToolStrip4 = New System.Windows.Forms.ToolStrip()
        Me.ExportDataPackageToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.DataPackageToolStripLabel = New System.Windows.Forms.ToolStripLabel()
        Me.CopyToClipBoardToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.RefreshDataPackageToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.RefreshCSVToolStripButton = New System.Windows.Forms.ToolStripButton()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.MetadataDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.DataTabPage.SuspendLayout()
        CType(Me.DataDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CSVTabPage.SuspendLayout()
        Me.ToolStrip2.SuspendLayout()
        Me.WorksheetPropertiesTabPage.SuspendLayout()
        Me.DataPackageTabPage.SuspendLayout()
        Me.ToolStrip4.SuspendLayout()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.MetadataDataGridView)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.TabControl1)
        Me.SplitContainer1.Size = New System.Drawing.Size(1128, 606)
        Me.SplitContainer1.SplitterDistance = 374
        Me.SplitContainer1.TabIndex = 0
        '
        'MetadataDataGridView
        '
        Me.MetadataDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.MetadataDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MetadataDataGridView.Location = New System.Drawing.Point(0, 0)
        Me.MetadataDataGridView.Name = "MetadataDataGridView"
        Me.MetadataDataGridView.Size = New System.Drawing.Size(374, 606)
        Me.MetadataDataGridView.TabIndex = 0
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.DataTabPage)
        Me.TabControl1.Controls.Add(Me.DataPackageTabPage)
        Me.TabControl1.Controls.Add(Me.CSVTabPage)
        Me.TabControl1.Controls.Add(Me.WorksheetPropertiesTabPage)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(750, 606)
        Me.TabControl1.TabIndex = 1
        '
        'DataTabPage
        '
        Me.DataTabPage.Controls.Add(Me.DataDataGridView)
        Me.DataTabPage.Location = New System.Drawing.Point(4, 22)
        Me.DataTabPage.Name = "DataTabPage"
        Me.DataTabPage.Padding = New System.Windows.Forms.Padding(3)
        Me.DataTabPage.Size = New System.Drawing.Size(742, 580)
        Me.DataTabPage.TabIndex = 0
        Me.DataTabPage.Text = "Data"
        Me.DataTabPage.UseVisualStyleBackColor = True
        '
        'DataDataGridView
        '
        Me.DataDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataDataGridView.Location = New System.Drawing.Point(3, 3)
        Me.DataDataGridView.Name = "DataDataGridView"
        Me.DataDataGridView.Size = New System.Drawing.Size(736, 574)
        Me.DataDataGridView.TabIndex = 0
        '
        'CSVTabPage
        '
        Me.CSVTabPage.Controls.Add(Me.CSVTextBox)
        Me.CSVTabPage.Controls.Add(Me.ToolStrip2)
        Me.CSVTabPage.Location = New System.Drawing.Point(4, 22)
        Me.CSVTabPage.Name = "CSVTabPage"
        Me.CSVTabPage.Padding = New System.Windows.Forms.Padding(3)
        Me.CSVTabPage.Size = New System.Drawing.Size(742, 580)
        Me.CSVTabPage.TabIndex = 1
        Me.CSVTabPage.Text = "CSV"
        Me.CSVTabPage.UseVisualStyleBackColor = True
        '
        'CSVTextBox
        '
        Me.CSVTextBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CSVTextBox.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CSVTextBox.Location = New System.Drawing.Point(3, 28)
        Me.CSVTextBox.Multiline = True
        Me.CSVTextBox.Name = "CSVTextBox"
        Me.CSVTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.CSVTextBox.Size = New System.Drawing.Size(736, 549)
        Me.CSVTextBox.TabIndex = 0
        Me.CSVTextBox.WordWrap = False
        '
        'ToolStrip2
        '
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExportCSVToolStripButton, Me.RefreshCSVToolStripButton})
        Me.ToolStrip2.Location = New System.Drawing.Point(3, 3)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.Size = New System.Drawing.Size(736, 25)
        Me.ToolStrip2.TabIndex = 1
        Me.ToolStrip2.Text = "ToolStrip2"
        '
        'ExportCSVToolStripButton
        '
        Me.ExportCSVToolStripButton.Image = CType(resources.GetObject("ExportCSVToolStripButton.Image"), System.Drawing.Image)
        Me.ExportCSVToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ExportCSVToolStripButton.Name = "ExportCSVToolStripButton"
        Me.ExportCSVToolStripButton.Size = New System.Drawing.Size(69, 22)
        Me.ExportCSVToolStripButton.Text = "Export..."
        '
        'WorksheetPropertiesTabPage
        '
        Me.WorksheetPropertiesTabPage.Controls.Add(Me.WorksheetPropertyGrid)
        Me.WorksheetPropertiesTabPage.Location = New System.Drawing.Point(4, 22)
        Me.WorksheetPropertiesTabPage.Name = "WorksheetPropertiesTabPage"
        Me.WorksheetPropertiesTabPage.Padding = New System.Windows.Forms.Padding(3)
        Me.WorksheetPropertiesTabPage.Size = New System.Drawing.Size(742, 580)
        Me.WorksheetPropertiesTabPage.TabIndex = 2
        Me.WorksheetPropertiesTabPage.Text = "Worksheet properties"
        Me.WorksheetPropertiesTabPage.UseVisualStyleBackColor = True
        '
        'WorksheetPropertyGrid
        '
        Me.WorksheetPropertyGrid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.WorksheetPropertyGrid.Location = New System.Drawing.Point(3, 3)
        Me.WorksheetPropertyGrid.Name = "WorksheetPropertyGrid"
        Me.WorksheetPropertyGrid.Size = New System.Drawing.Size(736, 574)
        Me.WorksheetPropertyGrid.TabIndex = 0
        '
        'DataPackageTabPage
        '
        Me.DataPackageTabPage.Controls.Add(Me.DataPackageTextBox)
        Me.DataPackageTabPage.Controls.Add(Me.ToolStrip4)
        Me.DataPackageTabPage.Location = New System.Drawing.Point(4, 22)
        Me.DataPackageTabPage.Name = "DataPackageTabPage"
        Me.DataPackageTabPage.Padding = New System.Windows.Forms.Padding(3)
        Me.DataPackageTabPage.Size = New System.Drawing.Size(742, 580)
        Me.DataPackageTabPage.TabIndex = 4
        Me.DataPackageTabPage.Text = "Data package"
        Me.DataPackageTabPage.UseVisualStyleBackColor = True
        '
        'DataPackageTextBox
        '
        Me.DataPackageTextBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataPackageTextBox.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataPackageTextBox.Location = New System.Drawing.Point(3, 28)
        Me.DataPackageTextBox.Multiline = True
        Me.DataPackageTextBox.Name = "DataPackageTextBox"
        Me.DataPackageTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.DataPackageTextBox.Size = New System.Drawing.Size(736, 549)
        Me.DataPackageTextBox.TabIndex = 4
        Me.DataPackageTextBox.WordWrap = False
        '
        'ToolStrip4
        '
        Me.ToolStrip4.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RefreshDataPackageToolStripButton, Me.ToolStripSeparator3, Me.ExportDataPackageToolStripButton, Me.ToolStripSeparator1, Me.CopyToClipBoardToolStripButton, Me.ToolStripSeparator2, Me.DataPackageToolStripLabel})
        Me.ToolStrip4.Location = New System.Drawing.Point(3, 3)
        Me.ToolStrip4.Name = "ToolStrip4"
        Me.ToolStrip4.Size = New System.Drawing.Size(736, 25)
        Me.ToolStrip4.TabIndex = 5
        Me.ToolStrip4.Text = "ToolStrip4"
        '
        'ExportDataPackageToolStripButton
        '
        Me.ExportDataPackageToolStripButton.Image = CType(resources.GetObject("ExportDataPackageToolStripButton.Image"), System.Drawing.Image)
        Me.ExportDataPackageToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ExportDataPackageToolStripButton.Name = "ExportDataPackageToolStripButton"
        Me.ExportDataPackageToolStripButton.Size = New System.Drawing.Size(69, 22)
        Me.ExportDataPackageToolStripButton.Text = "Export..."
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'DataPackageToolStripLabel
        '
        Me.DataPackageToolStripLabel.Name = "DataPackageToolStripLabel"
        Me.DataPackageToolStripLabel.Size = New System.Drawing.Size(365, 22)
        Me.DataPackageToolStripLabel.Text = "See http://dataprotocols.org/tabular-data-package/ for information"
        '
        'CopyToClipBoardToolStripButton
        '
        Me.CopyToClipBoardToolStripButton.Image = CType(resources.GetObject("CopyToClipBoardToolStripButton.Image"), System.Drawing.Image)
        Me.CopyToClipBoardToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.CopyToClipBoardToolStripButton.Name = "CopyToClipBoardToolStripButton"
        Me.CopyToClipBoardToolStripButton.Size = New System.Drawing.Size(122, 22)
        Me.CopyToClipBoardToolStripButton.Text = "Copy to clipboard"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'RefreshDataPackageToolStripButton
        '
        Me.RefreshDataPackageToolStripButton.Image = CType(resources.GetObject("RefreshDataPackageToolStripButton.Image"), System.Drawing.Image)
        Me.RefreshDataPackageToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.RefreshDataPackageToolStripButton.Name = "RefreshDataPackageToolStripButton"
        Me.RefreshDataPackageToolStripButton.Size = New System.Drawing.Size(66, 22)
        Me.RefreshDataPackageToolStripButton.Text = "Refresh"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'RefreshCSVToolStripButton
        '
        Me.RefreshCSVToolStripButton.Image = CType(resources.GetObject("RefreshCSVToolStripButton.Image"), System.Drawing.Image)
        Me.RefreshCSVToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.RefreshCSVToolStripButton.Name = "RefreshCSVToolStripButton"
        Me.RefreshCSVToolStripButton.Size = New System.Drawing.Size(66, 22)
        Me.RefreshCSVToolStripButton.Text = "Refresh"
        '
        'WorksheetControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "WorksheetControl"
        Me.Size = New System.Drawing.Size(1128, 606)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.MetadataDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.DataTabPage.ResumeLayout(False)
        CType(Me.DataDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CSVTabPage.ResumeLayout(False)
        Me.CSVTabPage.PerformLayout()
        Me.ToolStrip2.ResumeLayout(False)
        Me.ToolStrip2.PerformLayout()
        Me.WorksheetPropertiesTabPage.ResumeLayout(False)
        Me.DataPackageTabPage.ResumeLayout(False)
        Me.DataPackageTabPage.PerformLayout()
        Me.ToolStrip4.ResumeLayout(False)
        Me.ToolStrip4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents MetadataDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents DataTabPage As System.Windows.Forms.TabPage
    Friend WithEvents CSVTabPage As System.Windows.Forms.TabPage
    Friend WithEvents CSVTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ToolStrip2 As System.Windows.Forms.ToolStrip
    Friend WithEvents ExportCSVToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents WorksheetPropertiesTabPage As System.Windows.Forms.TabPage
    Friend WithEvents WorksheetPropertyGrid As System.Windows.Forms.PropertyGrid
    Friend WithEvents DataPackageTabPage As System.Windows.Forms.TabPage
    Friend WithEvents DataPackageTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ToolStrip4 As System.Windows.Forms.ToolStrip
    Friend WithEvents ExportDataPackageToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents DataPackageToolStripLabel As System.Windows.Forms.ToolStripLabel
    Friend WithEvents CopyToClipBoardToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents RefreshDataPackageToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents RefreshCSVToolStripButton As System.Windows.Forms.ToolStripButton

End Class
