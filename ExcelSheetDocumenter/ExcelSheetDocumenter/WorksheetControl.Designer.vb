﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.JSONTabPage = New System.Windows.Forms.TabPage()
        Me.JSONTextBox = New System.Windows.Forms.TextBox()
        Me.ToolStrip3 = New System.Windows.Forms.ToolStrip()
        Me.ExportJSONToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
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
        Me.JSONTabPage.SuspendLayout()
        Me.ToolStrip3.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 25)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.MetadataDataGridView)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.TabControl1)
        Me.SplitContainer1.Size = New System.Drawing.Size(1128, 581)
        Me.SplitContainer1.SplitterDistance = 374
        Me.SplitContainer1.TabIndex = 0
        '
        'MetadataDataGridView
        '
        Me.MetadataDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.MetadataDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MetadataDataGridView.Location = New System.Drawing.Point(0, 0)
        Me.MetadataDataGridView.Name = "MetadataDataGridView"
        Me.MetadataDataGridView.Size = New System.Drawing.Size(374, 581)
        Me.MetadataDataGridView.TabIndex = 0
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.DataTabPage)
        Me.TabControl1.Controls.Add(Me.CSVTabPage)
        Me.TabControl1.Controls.Add(Me.JSONTabPage)
        Me.TabControl1.Controls.Add(Me.WorksheetPropertiesTabPage)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(750, 581)
        Me.TabControl1.TabIndex = 1
        '
        'DataTabPage
        '
        Me.DataTabPage.Controls.Add(Me.DataDataGridView)
        Me.DataTabPage.Location = New System.Drawing.Point(4, 22)
        Me.DataTabPage.Name = "DataTabPage"
        Me.DataTabPage.Padding = New System.Windows.Forms.Padding(3)
        Me.DataTabPage.Size = New System.Drawing.Size(742, 555)
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
        Me.DataDataGridView.Size = New System.Drawing.Size(736, 549)
        Me.DataDataGridView.TabIndex = 0
        '
        'CSVTabPage
        '
        Me.CSVTabPage.Controls.Add(Me.CSVTextBox)
        Me.CSVTabPage.Controls.Add(Me.ToolStrip2)
        Me.CSVTabPage.Location = New System.Drawing.Point(4, 22)
        Me.CSVTabPage.Name = "CSVTabPage"
        Me.CSVTabPage.Padding = New System.Windows.Forms.Padding(3)
        Me.CSVTabPage.Size = New System.Drawing.Size(742, 555)
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
        Me.CSVTextBox.Size = New System.Drawing.Size(736, 524)
        Me.CSVTextBox.TabIndex = 0
        Me.CSVTextBox.WordWrap = False
        '
        'ToolStrip2
        '
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExportCSVToolStripButton})
        Me.ToolStrip2.Location = New System.Drawing.Point(3, 3)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.Size = New System.Drawing.Size(736, 25)
        Me.ToolStrip2.TabIndex = 1
        Me.ToolStrip2.Text = "ToolStrip2"
        '
        'ExportCSVToolStripButton
        '
        Me.ExportCSVToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ExportCSVToolStripButton.Image = CType(resources.GetObject("ExportCSVToolStripButton.Image"), System.Drawing.Image)
        Me.ExportCSVToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ExportCSVToolStripButton.Name = "ExportCSVToolStripButton"
        Me.ExportCSVToolStripButton.Size = New System.Drawing.Size(53, 22)
        Me.ExportCSVToolStripButton.Text = "Export..."
        '
        'WorksheetPropertiesTabPage
        '
        Me.WorksheetPropertiesTabPage.Controls.Add(Me.WorksheetPropertyGrid)
        Me.WorksheetPropertiesTabPage.Location = New System.Drawing.Point(4, 22)
        Me.WorksheetPropertiesTabPage.Name = "WorksheetPropertiesTabPage"
        Me.WorksheetPropertiesTabPage.Padding = New System.Windows.Forms.Padding(3)
        Me.WorksheetPropertiesTabPage.Size = New System.Drawing.Size(742, 555)
        Me.WorksheetPropertiesTabPage.TabIndex = 2
        Me.WorksheetPropertiesTabPage.Text = "Worksheet properties"
        Me.WorksheetPropertiesTabPage.UseVisualStyleBackColor = True
        '
        'WorksheetPropertyGrid
        '
        Me.WorksheetPropertyGrid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.WorksheetPropertyGrid.Location = New System.Drawing.Point(3, 3)
        Me.WorksheetPropertyGrid.Name = "WorksheetPropertyGrid"
        Me.WorksheetPropertyGrid.Size = New System.Drawing.Size(736, 549)
        Me.WorksheetPropertyGrid.TabIndex = 0
        '
        'JSONTabPage
        '
        Me.JSONTabPage.Controls.Add(Me.JSONTextBox)
        Me.JSONTabPage.Controls.Add(Me.ToolStrip3)
        Me.JSONTabPage.Location = New System.Drawing.Point(4, 22)
        Me.JSONTabPage.Name = "JSONTabPage"
        Me.JSONTabPage.Padding = New System.Windows.Forms.Padding(3)
        Me.JSONTabPage.Size = New System.Drawing.Size(742, 555)
        Me.JSONTabPage.TabIndex = 3
        Me.JSONTabPage.Text = "JSONTabPage"
        Me.JSONTabPage.UseVisualStyleBackColor = True
        '
        'JSONTextBox
        '
        Me.JSONTextBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.JSONTextBox.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.JSONTextBox.Location = New System.Drawing.Point(3, 28)
        Me.JSONTextBox.Multiline = True
        Me.JSONTextBox.Name = "JSONTextBox"
        Me.JSONTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.JSONTextBox.Size = New System.Drawing.Size(736, 524)
        Me.JSONTextBox.TabIndex = 2
        Me.JSONTextBox.WordWrap = False
        '
        'ToolStrip3
        '
        Me.ToolStrip3.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExportJSONToolStripButton})
        Me.ToolStrip3.Location = New System.Drawing.Point(3, 3)
        Me.ToolStrip3.Name = "ToolStrip3"
        Me.ToolStrip3.Size = New System.Drawing.Size(736, 25)
        Me.ToolStrip3.TabIndex = 3
        Me.ToolStrip3.Text = "ToolStrip3"
        '
        'ExportJSONToolStripButton
        '
        Me.ExportJSONToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ExportJSONToolStripButton.Image = CType(resources.GetObject("ExportJSONToolStripButton.Image"), System.Drawing.Image)
        Me.ExportJSONToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ExportJSONToolStripButton.Name = "ExportJSONToolStripButton"
        Me.ExportJSONToolStripButton.Size = New System.Drawing.Size(53, 22)
        Me.ExportJSONToolStripButton.Text = "Export..."
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1, Me.ToolStripButton1})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1128, 25)
        Me.ToolStrip1.TabIndex = 1
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(96, 22)
        Me.ToolStripLabel1.Text = "Export metadata:"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(32, 22)
        Me.ToolStripButton1.Text = "CSV"
        '
        'WorksheetControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.ToolStrip1)
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
        Me.JSONTabPage.ResumeLayout(False)
        Me.JSONTabPage.PerformLayout()
        Me.ToolStrip3.ResumeLayout(False)
        Me.ToolStrip3.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents MetadataDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents DataTabPage As System.Windows.Forms.TabPage
    Friend WithEvents CSVTabPage As System.Windows.Forms.TabPage
    Friend WithEvents CSVTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStrip2 As System.Windows.Forms.ToolStrip
    Friend WithEvents ExportCSVToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents WorksheetPropertiesTabPage As System.Windows.Forms.TabPage
    Friend WithEvents WorksheetPropertyGrid As System.Windows.Forms.PropertyGrid
    Friend WithEvents JSONTabPage As System.Windows.Forms.TabPage
    Friend WithEvents JSONTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ToolStrip3 As System.Windows.Forms.ToolStrip
    Friend WithEvents ExportJSONToolStripButton As System.Windows.Forms.ToolStripButton

End Class
