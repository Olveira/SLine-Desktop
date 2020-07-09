Public Class PantallaRegistro
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        InicioADM.ShowDialog()
    End Sub

    Private Sub PantallaRegistro_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cbxSexo.Items.Add("Masculino")
        cbxSexo.Items.Add("Femenino")
        cbxSexo.Items.Add("Otro")
    End Sub

    Private Sub CerrarRegistro(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing

        cbxSexo.Items.Clear()

    End Sub


End Class