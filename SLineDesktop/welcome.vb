Public Class welcome
    Private Sub btnGoRegistrar_Click(sender As Object, e As EventArgs) Handles btnGoRegistrar.Click
        PantallaRegistro.Show()

        Me.Hide()
    End Sub
    Private Sub btnGoLogin_Click(sender As Object, e As EventArgs) Handles btnGoLogin.Click
        InicioADM.Show()
        Me.Hide()
    End Sub
End Class