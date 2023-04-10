Public Class LoginForm

    Private Sub btLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btLogin.Click
        If txtUser.Text = "user" And txtPassword.Text = "user" Then
            MsgBox("Anda berhasil login sebagai user")
            MainMenu.Show()
            Me.Hide()
        ElseIf txtUser.Text = "admin" And txtPassword.Text = "admin" Then
            MsgBox("Anda berhasil login sebagai admin")
            MainMenu.Show()
            Me.Hide()
        Else
            MsgBox("Username atau Password yang anda masukkan salah")
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class