Public Class Form1
    Public SqlStr As String
    Public Koneksi As New OleDb.OleDbConnection
    Public cmd As New OleDb.OleDbCommand
    Public da As New OleDb.OleDbDataAdapter
    Public dt As New DataTable
    Public KoneksiString As String
    Public Lokasi As String
    Public Sql As String
    Public XTotal As Double

    Private Sub Form1_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        DGV()
        BlankForm()
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DatabasePenjualanDataSet.jual' table. You can move, or remove it, as needed.
        Me.JualTableAdapter.Fill(Me.DatabasePenjualanDataSet.jual)
        Lokasi = System.Environment.CurrentDirectory
        KoneksiString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Lokasi & "\databasePenjualan.accdb"
        Koneksi = New OleDb.OleDbConnection(KoneksiString)
        Koneksi.Open()
        MatikanForm()
    End Sub

    Private Sub DGV()
        Sql = "SELECT * FROM Jual"
        da = New OleDb.OleDbDataAdapter(Sql, Koneksi)
        dt.Clear()
        da.Fill(dt)
        dgvJual.DataSource = dt
    End Sub

    Private Sub BlankForm()
        txtNomor.Text = ""
        txtPemesan.Text = ""
        txtNama.Text = ""
        txtHarga.Text = 0
        txtTanggal.Text = Date.Now
        txtTotal.Text = 0
    End Sub

    Private Sub MatikanForm()
        txtNomor.Enabled = False
        txtPemesan.Enabled = False
        txtNama.Enabled = False
        txtTanggal.Enabled = False
        txtHarga.Enabled = False
        txtTotal.Enabled = False
    End Sub
    Private Sub HidupkanForm()
        txtNomor.Enabled = True
        txtPemesan.Enabled = True
        txtNama.Enabled = True
        txtTanggal.Enabled = True
        txtHarga.Enabled = True
        txtTotal.Enabled = True
    End Sub
    Private Sub btClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btClose.Click
        Me.Close()
    End Sub

    Private Sub txtHarga_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtHarga.TextChanged
        txtTotal.Text = txtHarga.Text
    End Sub

    Private Sub txtNomor_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNomor.Leave
        Sql = "SELECT * FROM Jual WHERE Nomor='" & txtNomor.Text & "'"
        da = New OleDb.OleDbDataAdapter(Sql, Koneksi)
        dt.Clear()
        da.Fill(dt)
        dgvJual.DataSource = dt
        If dt.Rows.Count > 0 Then
            txtPemesan.Text = dgvJual.Rows.Item(dgvJual.CurrentRow.Index).Cells(1).Value
            txtNama.Text = dgvJual.Rows.Item(dgvJual.CurrentRow.Index).Cells(2).Value
            txtTanggal.Text = dgvJual.Rows.Item(dgvJual.CurrentRow.Index).Cells(3).Value
            txtHarga.Text = dgvJual.Rows.Item(dgvJual.CurrentRow.Index).Cells(4).Value
            txtTotal.Text = dgvJual.Rows.Item(dgvJual.CurrentRow.Index).Cells(5).Value
        End If
        DGV()
    End Sub
    Private Sub btSimpan_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btSimpan.Click
        Sql = "SELECT * FROM Jual WHERE Nomor='" & txtNomor.Text & "'"
        da = New OleDb.OleDbDataAdapter(Sql, Koneksi)
        dt.Clear()
        da.Fill(dt)
        dgvJual.DataSource = dt
        If dt.Rows.Count > 0 Then
            Sql = "UPDATE Jual SET Nomor='" & txtNomor.Text & "',Pemesan='" & txtPemesan.Text & "',Nama='" & txtNama.Text & "',Tanggal='" & txtTanggal.Text & "',Harga=" & txtHarga.Text _
                  & ",Total=" & XTotal & "WHERE Nomor='" & txtNomor.Text & "'"
            cmd = New OleDb.OleDbCommand(Sql, Koneksi)
            cmd.ExecuteNonQuery()
        Else
            Sql = "INSERT INTO Jual VALUES ('" & txtNomor.Text & "','" & txtPemesan.Text & "','" & txtNama.Text & "','" & txtTanggal.Value & "'," & txtHarga.Text _
                  & "," & txtTotal.Text & ")"
            cmd = New OleDb.OleDbCommand(Sql, Koneksi)
            cmd.ExecuteNonQuery()
        End If
        Me.Validate()
        Me.JualBindingSource.EndEdit()
        Me.JualTableAdapter.Update(Me.DatabasePenjualanDataSet.jual)
        Call MatikanForm()
        Call BlankForm()
        Call DGV()

    End Sub


    Private Sub btHapus_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btHapus.Click
        If txtNomor.Text = "" Then
            MsgBox("tidak ada data yang dihapus")
            Exit Sub
        Else
            cmd = New OleDb.OleDbCommand("delete from jual where nomor='" & txtNomor.Text & "'", Koneksi)
            cmd.ExecuteNonQuery()
            MsgBox("Data berhasil dihapus")
            Call MatikanForm()
            Call BlankForm()
            Call DGV()
        End If
    End Sub

    Private Sub btTambah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btTambah.Click
        Call HidupkanForm()
        Call BlankForm()
    End Sub

    Private Sub btBatal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btBatal.Click
        Call MatikanForm()
        Call BlankForm()
    End Sub

  
    Private Sub dgvJual_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles dgvJual.CellMouseClick
        On Error Resume Next
        txtNomor.Text = dgvJual.Rows(e.RowIndex).Cells(0).Value
        txtNama.Text = dgvJual.Rows(e.RowIndex).Cells(1).Value
        txtPemesan.Text = dgvJual.Rows(e.RowIndex).Cells(2).Value
        txtTanggal.Value = dgvJual.Rows(e.RowIndex).Cells(3).Value
        txtHarga.Text = dgvJual.Rows(e.RowIndex).Cells(4).Value
        txtTotal.Text = dgvJual.Rows(e.RowIndex).Cells(5).Value

        Call HidupkanForm()
        txtNomor.Enabled = False
    End Sub

    Private Sub btEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btEdit.Click
        If txtNomor.Text = "" Or txtPemesan.Text = "" Or txtNama.Text = "" Or txtHarga.Text = 0 Then
            MsgBox("Data belum lengkap")
            Exit Sub
        Else

            cmd = New OleDb.OleDbCommand("update jual set nomor='" & txtNomor.Text & "', pemesan='" & txtPemesan.Text & "', nama='" & txtNama.Text & "', tanggal='" & txtTanggal.Value & "', harga='" & txtHarga.Text & "' , total='" & txtTotal.Text & "'", Koneksi)
            cmd.ExecuteNonQuery()
            MsgBox("Update data sukses")
        End If
        Call MatikanForm()
        Call BlankForm()
        Call DGV()
    End Sub

  
End Class
