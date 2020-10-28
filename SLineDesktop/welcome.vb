Public Class Welcome
    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles BtnExit.Click
        Application.Exit()
    End Sub
    Private Sub BtnMinimize_Click(sender As Object, e As EventArgs) Handles BtnMinimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
    Private Sub btnGoRegistrar_Click(sender As Object, e As EventArgs) Handles btnGoRegistrar.Click
        Try
            Registro.Show()
            Me.Hide()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub btnGoLogin_Click(sender As Object, e As EventArgs) Handles btnGoLogin.Click
        Try
            Login.Show()
            Me.Hide()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class