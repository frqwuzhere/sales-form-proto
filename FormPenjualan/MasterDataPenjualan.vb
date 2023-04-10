Public Class MasterDataPenjualan
    Public SqlStr As String
    Public Koneksi As New OleDb.OleDbConnection
    Public cmd As New OleDb.OleDbCommand
    Public da As New OleDb.OleDbDataAdapter
    Public dt As New DataTable
    Public KoneksiString As String
    Public Lokasi As String
    Public Sql As String
    Public XTotal As Double

    Private Sub MasterDataPenjualan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DatabasePenjualanDataSet.jual' table. You can move, or remove it, as needed.
        Me.JualTableAdapter.Fill(Me.DatabasePenjualanDataSet.jual)
        Lokasi = System.Environment.CurrentDirectory
        KoneksiString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Lokasi & "\databasePenjualan.accdb"
        Koneksi = New OleDb.OleDbConnection(KoneksiString)
        Koneksi.Open()
        DGV()
    End Sub

    Private Sub DGV()
        Sql = "SELECT * FROM Jual"
        da = New OleDb.OleDbDataAdapter(Sql, Koneksi)
        dt.Clear()
        da.Fill(dt)
        dgvLaporan.DataSource = dt
    End Sub

    Private Sub KembaliToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KembaliToolStripMenuItem.Click
        Me.Hide()
    End Sub

    Private Sub btPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btPrint.Click
        FormLaporan.Show()
    End Sub
End Class