<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExportToPipeSeparatedValuesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExportToCommaSeparatedValuesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.MetadataPanel = New System.Windows.Forms.Panel()
        Me.FilenameTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.MetadataPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.ExportToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(854, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpenToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'OpenToolStripMenuItem
        '
        Me.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem"
        Me.OpenToolStripMenuItem.Size = New System.Drawing.Size(112, 22)
        Me.OpenToolStripMenuItem.Text = "Open..."
        '
        'ExportToolStripMenuItem
        '
        Me.ExportToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExportToPipeSeparatedValuesToolStripMenuItem, Me.ExportToCommaSeparatedValuesToolStripMenuItem})
        Me.ExportToolStripMenuItem.Name = "ExportToolStripMenuItem"
        Me.ExportToolStripMenuItem.Size = New System.Drawing.Size(55, 20)
        Me.ExportToolStripMenuItem.Text = "Export "
        '
        'ExportToPipeSeparatedValuesToolStripMenuItem
        '
        Me.ExportToPipeSeparatedValuesToolStripMenuItem.Name = "ExportToPipeSeparatedValuesToolStripMenuItem"
        Me.ExportToPipeSeparatedValuesToolStripMenuItem.Size = New System.Drawing.Size(264, 22)
        Me.ExportToPipeSeparatedValuesToolStripMenuItem.Text = "Export to pipe separated values..."
        '
        'ExportToCommaSeparatedValuesToolStripMenuItem
        '
        Me.ExportToCommaSeparatedValuesToolStripMenuItem.Name = "ExportToCommaSeparatedValuesToolStripMenuItem"
        Me.ExportToCommaSeparatedValuesToolStripMenuItem.Size = New System.Drawing.Size(264, 22)
        Me.ExportToCommaSeparatedValuesToolStripMenuItem.Text = "Export to comma separated values..."
        '
        'TabControl1
        '
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 92)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(854, 451)
        Me.TabControl1.TabIndex = 3
        '
        'MetadataPanel
        '
        Me.MetadataPanel.Controls.Add(Me.Label1)
        Me.MetadataPanel.Controls.Add(Me.FilenameTextBox)
        Me.MetadataPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.MetadataPanel.Location = New System.Drawing.Point(0, 24)
        Me.MetadataPanel.Name = "MetadataPanel"
        Me.MetadataPanel.Size = New System.Drawing.Size(854, 68)
        Me.MetadataPanel.TabIndex = 4
        '
        'FilenameTextBox
        '
        Me.FilenameTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FilenameTextBox.Location = New System.Drawing.Point(70, 9)
        Me.FilenameTextBox.Name = "FilenameTextBox"
        Me.FilenameTextBox.Size = New System.Drawing.Size(772, 20)
        Me.FilenameTextBox.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Filename:"
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(854, 543)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.MetadataPanel)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "MainForm"
        Me.Text = "Excel Sheet Documenter"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.MetadataPanel.ResumeLayout(False)
        Me.MetadataPanel.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents ExportToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExportToPipeSeparatedValuesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExportToCommaSeparatedValuesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MetadataPanel As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents FilenameTextBox As System.Windows.Forms.TextBox

End Class
