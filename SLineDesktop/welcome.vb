Public Class welcome
    Private Sub btnGoRegistrar_Click(sender As Object, e As EventArgs) Handles btnGoRegistrar.Click
        Try
            PantallaRegistro.Show()
            Me.Hide()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub btnGoLogin_Click(sender As Object, e As EventArgs) Handles btnGoLogin.Click
        Try
            InicioADM.Show()
            Me.Hide()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub MeLoad(sender As Object, e As EventArgs) Handles Me.Load
        PantallaListar.BackColor = Color.Plum
        PantallaModificar.BackColor = Color.Plum
        PantallaModerar.BackColor = Color.Plum
        PantallaRegistro.BackColor = Color.Plum
        InicioADM.BackColor = Color.Plum

    End Sub
End Class