<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainMenu
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
        Me.components = New System.ComponentModel.Container()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FormToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FormPenjualanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MasterDataToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataPenjualanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GantiAkunToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KeluarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FormToolStripMenuItem, Me.MasterDataToolStripMenuItem, Me.GantiAkunToolStripMenuItem, Me.KeluarToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(376, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FormToolStripMenuItem
        '
        Me.FormToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FormPenjualanToolStripMenuItem})
        Me.FormToolStripMenuItem.Name = "FormToolStripMenuItem"
        Me.FormToolStripMenuItem.Size = New System.Drawing.Size(47, 20)
        Me.FormToolStripMenuItem.Text = "Form"
        '
        'FormPenjualanToolStripMenuItem
        '
        Me.FormPenjualanToolStripMenuItem.Name = "FormPenjualanToolStripMenuItem"
        Me.FormPenjualanToolStripMenuItem.Size = New System.Drawing.Size(157, 22)
        Me.FormPenjualanToolStripMenuItem.Text = "Form Penjualan"
        '
        'MasterDataToolStripMenuItem
        '
        Me.MasterDataToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DataPenjualanToolStripMenuItem})
        Me.MasterDataToolStripMenuItem.Name = "MasterDataToolStripMenuItem"
        Me.MasterDataToolStripMenuItem.Size = New System.Drawing.Size(82, 20)
        Me.MasterDataToolStripMenuItem.Text = "Master Data"
        '
        'DataPenjualanToolStripMenuItem
        '
        Me.DataPenjualanToolStripMenuItem.Name = "DataPenjualanToolStripMenuItem"
        Me.DataPenjualanToolStripMenuItem.Size = New System.Drawing.Size(153, 22)
        Me.DataPenjualanToolStripMenuItem.Text = "Data Penjualan"
        '
        'GantiAkunToolStripMenuItem
        '
        Me.GantiAkunToolStripMenuItem.Name = "GantiAkunToolStripMenuItem"
        Me.GantiAkunToolStripMenuItem.Size = New System.Drawing.Size(78, 20)
        Me.GantiAkunToolStripMenuItem.Text = "Ganti Akun"
        '
        'KeluarToolStripMenuItem
        '
        Me.KeluarToolStripMenuItem.Name = "KeluarToolStripMenuItem"
        Me.KeluarToolStripMenuItem.Size = New System.Drawing.Size(52, 20)
        Me.KeluarToolStripMenuItem.Text = "Keluar"
        '
        'MainMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(376, 326)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "MainMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MainMenu"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FormToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FormPenjualanToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MasterDataToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GantiAkunToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents KeluarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DataPenjualanToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
