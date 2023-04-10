<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MasterDataPenjualan
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
        Me.dgvLaporan = New System.Windows.Forms.DataGridView()
        Me.NomorDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PemesanDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NamaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TanggalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HargaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.JualBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DatabasePenjualanDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DatabasePenjualanDataSet = New FormPenjualan.DatabasePenjualanDataSet()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.KembaliToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btPrint = New System.Windows.Forms.Button()
        Me.JualTableAdapter = New FormPenjualan.DatabasePenjualanDataSetTableAdapters.jualTableAdapter()
        CType(Me.dgvLaporan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JualBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DatabasePenjualanDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DatabasePenjualanDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvLaporan
        '
        Me.dgvLaporan.AutoGenerateColumns = False
        Me.dgvLaporan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvLaporan.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NomorDataGridViewTextBoxColumn, Me.PemesanDataGridViewTextBoxColumn, Me.NamaDataGridViewTextBoxColumn, Me.TanggalDataGridViewTextBoxColumn, Me.HargaDataGridViewTextBoxColumn, Me.TotalDataGridViewTextBoxColumn})
        Me.dgvLaporan.DataSource = Me.JualBindingSource
        Me.dgvLaporan.Location = New System.Drawing.Point(59, 91)
        Me.dgvLaporan.Name = "dgvLaporan"
        Me.dgvLaporan.Size = New System.Drawing.Size(576, 366)
        Me.dgvLaporan.TabIndex = 0
        '
        'NomorDataGridViewTextBoxColumn
        '
        Me.NomorDataGridViewTextBoxColumn.DataPropertyName = "Nomor"
        Me.NomorDataGridViewTextBoxColumn.HeaderText = "Nomor"
        Me.NomorDataGridViewTextBoxColumn.Name = "NomorDataGridViewTextBoxColumn"
        '
        'PemesanDataGridViewTextBoxColumn
        '
        Me.PemesanDataGridViewTextBoxColumn.DataPropertyName = "Pemesan"
        Me.PemesanDataGridViewTextBoxColumn.HeaderText = "Pemesan"
        Me.PemesanDataGridViewTextBoxColumn.Name = "PemesanDataGridViewTextBoxColumn"
        '
        'NamaDataGridViewTextBoxColumn
        '
        Me.NamaDataGridViewTextBoxColumn.DataPropertyName = "Nama"
        Me.NamaDataGridViewTextBoxColumn.HeaderText = "Nama"
        Me.NamaDataGridViewTextBoxColumn.Name = "NamaDataGridViewTextBoxColumn"
        '
        'TanggalDataGridViewTextBoxColumn
        '
        Me.TanggalDataGridViewTextBoxColumn.DataPropertyName = "Tanggal"
        Me.TanggalDataGridViewTextBoxColumn.HeaderText = "Tanggal"
        Me.TanggalDataGridViewTextBoxColumn.Name = "TanggalDataGridViewTextBoxColumn"
        '
        'HargaDataGridViewTextBoxColumn
        '
        Me.HargaDataGridViewTextBoxColumn.DataPropertyName = "Harga"
        Me.HargaDataGridViewTextBoxColumn.HeaderText = "Harga"
        Me.HargaDataGridViewTextBoxColumn.Name = "HargaDataGridViewTextBoxColumn"
        '
        'TotalDataGridViewTextBoxColumn
        '
        Me.TotalDataGridViewTextBoxColumn.DataPropertyName = "Total"
        Me.TotalDataGridViewTextBoxColumn.HeaderText = "Total"
        Me.TotalDataGridViewTextBoxColumn.Name = "TotalDataGridViewTextBoxColumn"
        '
        'JualBindingSource
        '
        Me.JualBindingSource.DataMember = "jual"
        Me.JualBindingSource.DataSource = Me.DatabasePenjualanDataSetBindingSource
        '
        'DatabasePenjualanDataSetBindingSource
        '
        Me.DatabasePenjualanDataSetBindingSource.DataSource = Me.DatabasePenjualanDataSet
        Me.DatabasePenjualanDataSetBindingSource.Position = 0
        '
        'DatabasePenjualanDataSet
        '
        Me.DatabasePenjualanDataSet.DataSetName = "DatabasePenjualanDataSet"
        Me.DatabasePenjualanDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.KembaliToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(844, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'KembaliToolStripMenuItem
        '
        Me.KembaliToolStripMenuItem.Name = "KembaliToolStripMenuItem"
        Me.KembaliToolStripMenuItem.Size = New System.Drawing.Size(62, 20)
        Me.KembaliToolStripMenuItem.Text = "Kembali"
        '
        'btPrint
        '
        Me.btPrint.Location = New System.Drawing.Point(706, 91)
        Me.btPrint.Name = "btPrint"
        Me.btPrint.Size = New System.Drawing.Size(75, 23)
        Me.btPrint.TabIndex = 2
        Me.btPrint.Text = "Cetak"
        Me.btPrint.UseVisualStyleBackColor = True
        '
        'JualTableAdapter
        '
        Me.JualTableAdapter.ClearBeforeFill = True
        '
        'MasterDataPenjualan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(844, 485)
        Me.Controls.Add(Me.btPrint)
        Me.Controls.Add(Me.dgvLaporan)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "MasterDataPenjualan"
        Me.Text = "MasterDataPenjualanvb"
        CType(Me.dgvLaporan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JualBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DatabasePenjualanDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DatabasePenjualanDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvLaporan As System.Windows.Forms.DataGridView
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents KembaliToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btPrint As System.Windows.Forms.Button
    Friend WithEvents DatabasePenjualanDataSetBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DatabasePenjualanDataSet As FormPenjualan.DatabasePenjualanDataSet
    Friend WithEvents JualBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents JualTableAdapter As FormPenjualan.DatabasePenjualanDataSetTableAdapters.jualTableAdapter
    Friend WithEvents NomorDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PemesanDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NamaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TanggalDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents HargaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TotalDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
