Public Class PantallaEliminar
    Public user As usuario
    Private Sub ListarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListarToolStripMenuItem.Click
        PantallaListar.Show()
        Me.Hide()

    End Sub

    Private Sub ModerarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ModerarToolStripMenuItem.Click

        PantallaModerar.Show()
        Me.Hide()
    End Sub

    Private Sub PantallaEliminar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tbxContraseñaMod.Text = user.Password
        tbxEmailMod.Text = user.Email
        tbxUserMod.Text = user.Username
        cbxRolMod.Text = user.Rol
        cbxSexoMod.Text = user.Sexo
        DTPFechaNacMod.Value = user.FechaNac
    End Sub
End Class