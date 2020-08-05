Public Class welcome
    Private Sub btnGoRegistrar_Click(sender As Object, e As EventArgs) Handles btnGoRegistrar.Click
        PantallaRegistro.ShowDialog()
    End Sub

    Private Sub btnGoLogin_Click(sender As Object, e As EventArgs) Handles btnGoLogin.Click
        InicioADM.ShowDialog()
    End Sub
End Class