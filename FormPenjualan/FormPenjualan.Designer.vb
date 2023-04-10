<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtNomor = New System.Windows.Forms.TextBox()
        Me.txtPemesan = New System.Windows.Forms.TextBox()
        Me.txtNama = New System.Windows.Forms.TextBox()
        Me.txtHarga = New System.Windows.Forms.TextBox()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.txtTanggal = New System.Windows.Forms.DateTimePicker()
        Me.btSimpan = New System.Windows.Forms.Button()
        Me.btHapus = New System.Windows.Forms.Button()
        Me.btTambah = New System.Windows.Forms.Button()
        Me.btClose = New System.Windows.Forms.Button()
        Me.dgvJual = New System.Windows.Forms.DataGridView()
        Me.NomorDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PemesanDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NamaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TanggalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HargaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.JualBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DatabasePenjualanDataSet = New FormPenjualan.DatabasePenjualanDataSet()
        Me.JualTableAdapter = New FormPenjualan.DatabasePenjualanDataSetTableAdapters.jualTableAdapter()
        Me.btEdit = New System.Windows.Forms.Button()
        Me.btBatal = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FormToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FormPersediaanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.dgvJual, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JualBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DatabasePenjualanDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(407, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Form Penjualan"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(114, 63)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nomor"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(114, 125)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Pemesan"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(114, 192)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(35, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Nama"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(500, 63)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(46, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Tanggal"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(500, 125)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(36, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Harga"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(500, 192)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(31, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Total"
        '
        'txtNomor
        '
        Me.txtNomor.Location = New System.Drawing.Point(174, 60)
        Me.txtNomor.Name = "txtNomor"
        Me.txtNomor.Size = New System.Drawing.Size(184, 20)
        Me.txtNomor.TabIndex = 7
        '
        'txtPemesan
        '
        Me.txtPemesan.Location = New System.Drawing.Point(174, 118)
        Me.txtPemesan.Name = "txtPemesan"
        Me.txtPemesan.Size = New System.Drawing.Size(184, 20)
        Me.txtPemesan.TabIndex = 8
        '
        'txtNama
        '
        Me.txtNama.Location = New System.Drawing.Point(174, 189)
        Me.txtNama.Name = "txtNama"
        Me.txtNama.Size = New System.Drawing.Size(184, 20)
        Me.txtNama.TabIndex = 9
        '
        'txtHarga
        '
        Me.txtHarga.Location = New System.Drawing.Point(564, 122)
        Me.txtHarga.Name = "txtHarga"
        Me.txtHarga.Size = New System.Drawing.Size(184, 20)
        Me.txtHarga.TabIndex = 11
        '
        'txtTotal
        '
        Me.txtTotal.Location = New System.Drawing.Point(564, 189)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(184, 20)
        Me.txtTotal.TabIndex = 12
        '
        'txtTanggal
        '
        Me.txtTanggal.CustomFormat = ""
        Me.txtTanggal.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txtTanggal.Location = New System.Drawing.Point(564, 57)
        Me.txtTanggal.Name = "txtTanggal"
        Me.txtTanggal.Size = New System.Drawing.Size(175, 20)
        Me.txtTanggal.TabIndex = 13
        Me.txtTanggal.Value = New Date(2023, 3, 27, 0, 0, 0, 0)
        '
        'btSimpan
        '
        Me.btSimpan.Location = New System.Drawing.Point(211, 244)
        Me.btSimpan.Name = "btSimpan"
        Me.btSimpan.Size = New System.Drawing.Size(86, 35)
        Me.btSimpan.TabIndex = 14
        Me.btSimpan.Text = "Simpan"
        Me.btSimpan.UseVisualStyleBackColor = True
        '
        'btHapus
        '
        Me.btHapus.Location = New System.Drawing.Point(460, 244)
        Me.btHapus.Name = "btHapus"
        Me.btHapus.Size = New System.Drawing.Size(86, 35)
        Me.btHapus.TabIndex = 15
        Me.btHapus.Text = "Hapus"
        Me.btHapus.UseVisualStyleBackColor = True
        '
        'btTambah
        '
        Me.btTambah.Location = New System.Drawing.Point(92, 244)
        Me.btTambah.Name = "btTambah"
        Me.btTambah.Size = New System.Drawing.Size(86, 35)
        Me.btTambah.TabIndex = 16
        Me.btTambah.Text = "Tambah"
        Me.btTambah.UseVisualStyleBackColor = True
        '
        'btClose
        '
        Me.btClose.Location = New System.Drawing.Point(687, 244)
        Me.btClose.Name = "btClose"
        Me.btClose.Size = New System.Drawing.Size(87, 35)
        Me.btClose.TabIndex = 17
        Me.btClose.Text = "Close"
        Me.btClose.UseVisualStyleBackColor = True
        '
        'dgvJual
        '
        Me.dgvJual.AutoGenerateColumns = False
        Me.dgvJual.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvJual.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NomorDataGridViewTextBoxColumn, Me.PemesanDataGridViewTextBoxColumn, Me.NamaDataGridViewTextBoxColumn, Me.TanggalDataGridViewTextBoxColumn, Me.HargaDataGridViewTextBoxColumn, Me.TotalDataGridViewTextBoxColumn})
        Me.dgvJual.DataSource = Me.JualBindingSource
        Me.dgvJual.Location = New System.Drawing.Point(117, 313)
        Me.dgvJual.Name = "dgvJual"
        Me.dgvJual.Size = New System.Drawing.Size(643, 102)
        Me.dgvJual.TabIndex = 18
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
        Me.JualBindingSource.DataSource = Me.DatabasePenjualanDataSet
        '
        'DatabasePenjualanDataSet
        '
        Me.DatabasePenjualanDataSet.DataSetName = "DatabasePenjualanDataSet"
        Me.DatabasePenjualanDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'JualTableAdapter
        '
        Me.JualTableAdapter.ClearBeforeFill = True
        '
        'btEdit
        '
        Me.btEdit.Location = New System.Drawing.Point(334, 244)
        Me.btEdit.Name = "btEdit"
        Me.btEdit.Size = New System.Drawing.Size(86, 35)
        Me.btEdit.TabIndex = 19
        Me.btEdit.Text = "Edit"
        Me.btEdit.UseVisualStyleBackColor = True
        '
        'btBatal
        '
        Me.btBatal.Location = New System.Drawing.Point(574, 244)
        Me.btBatal.Name = "btBatal"
        Me.btBatal.Size = New System.Drawing.Size(86, 35)
        Me.btBatal.TabIndex = 20
        Me.btBatal.Text = "Batal"
        Me.btBatal.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FormToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(865, 24)
        Me.MenuStrip1.TabIndex = 21
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FormToolStripMenuItem
        '
        Me.FormToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FormPersediaanToolStripMenuItem})
        Me.FormToolStripMenuItem.Name = "FormToolStripMenuItem"
        Me.FormToolStripMenuItem.Size = New System.Drawing.Size(47, 20)
        Me.FormToolStripMenuItem.Text = "Form"
        '
        'FormPersediaanToolStripMenuItem
        '
        Me.FormPersediaanToolStripMenuItem.Name = "FormPersediaanToolStripMenuItem"
        Me.FormPersediaanToolStripMenuItem.Size = New System.Drawing.Size(162, 22)
        Me.FormPersediaanToolStripMenuItem.Text = "Form Persediaan"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(865, 483)
        Me.Controls.Add(Me.btBatal)
        Me.Controls.Add(Me.btEdit)
        Me.Controls.Add(Me.dgvJual)
        Me.Controls.Add(Me.btClose)
        Me.Controls.Add(Me.btTambah)
        Me.Controls.Add(Me.btHapus)
        Me.Controls.Add(Me.btSimpan)
        Me.Controls.Add(Me.txtTanggal)
        Me.Controls.Add(Me.txtTotal)
        Me.Controls.Add(Me.txtHarga)
        Me.Controls.Add(Me.txtNama)
        Me.Controls.Add(Me.txtPemesan)
        Me.Controls.Add(Me.txtNomor)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        CType(Me.dgvJual, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JualBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DatabasePenjualanDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtNomor As System.Windows.Forms.TextBox
    Friend WithEvents txtPemesan As System.Windows.Forms.TextBox
    Friend WithEvents txtNama As System.Windows.Forms.TextBox
    Friend WithEvents txtHarga As System.Windows.Forms.TextBox
    Friend WithEvents txtTotal As System.Windows.Forms.TextBox
    Friend WithEvents txtTanggal As System.Windows.Forms.DateTimePicker
    Friend WithEvents btSimpan As System.Windows.Forms.Button
    Friend WithEvents btHapus As System.Windows.Forms.Button
    Friend WithEvents btTambah As System.Windows.Forms.Button
    Friend WithEvents btClose As System.Windows.Forms.Button
    Friend WithEvents dgvJual As System.Windows.Forms.DataGridView
    Friend WithEvents DatabasePenjualanDataSet As FormPenjualan.DatabasePenjualanDataSet
    Friend WithEvents JualBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents JualTableAdapter As FormPenjualan.DatabasePenjualanDataSetTableAdapters.jualTableAdapter
    Friend WithEvents NomorDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PemesanDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NamaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TanggalDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents HargaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TotalDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btEdit As System.Windows.Forms.Button
    Friend WithEvents btBatal As System.Windows.Forms.Button
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FormToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FormPersediaanToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
