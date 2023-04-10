Public Class MainMenu


    Private Sub FormPenjualanToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FormPenjualanToolStripMenuItem.Click
        Form1.Show()
    End Sub

    Private Sub KeluarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KeluarToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub DataPenjualanToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DataPenjualanToolStripMenuItem.Click
        MasterDataPenjualan.Show()
    End Sub

    Private Sub GantiAkunToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles GantiAkunToolStripMenuItem.Click
        Me.Hide()
        LoginForm.Show()
    End Sub
End Class