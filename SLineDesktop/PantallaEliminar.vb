Public Class PantallaEliminar
    Public user As usuario
    Private Sub ListarToolStripMenuItem_Click(sender As Object, e As EventArgs)
        PantallaListar.LVListadoUsuarios.Clear()
        PantallaListar.Update()
        PantallaListar.Show()

        Me.Hide()

    End Sub

    Private Sub ModerarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ModerarToolStripMenuItem.Click

        PantallaModerar.Show()
        Me.Hide()
    End Sub

    'Hiciste cagada gil Att: Lea
    'Cambia el MyBase porque no sirve en este caso

    'Private Sub PantallaEliminar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    'tbxContraseñaMod.Text = user.Password
    'tbxEmailMod.Text = user.Email
    'tbxUserMod.Text = user.Username
    'cbxRolMod.Text = user.Rol
    'cbxSexoMod.Text = user.Sexo
    'DTPFechaNacMod.Value = user.FechaNac
    'End Sub

    Private Sub BtnAceptarMod_Click(sender As Object, e As EventArgs) Handles BtnAceptarMod.Click
        user.Email = tbxEmailMod.Text
        user.FechaNac = DTPFechaNacMod.Value
        user.Sexo = cbxSexoMod.Text
        user.Rol = cbxRolMod.Text
        user.Password = tbxContraseñaMod.Text
        user.Username = tbxUserMod.Text
        Dim logica As New logicaUsuario
        logica.ModificarUsuario(user)
    End Sub

    Private Sub btnCancelarMod_Click(sender As Object, e As EventArgs) Handles btnCancelarMod.Click
        PantallaListar.LVListadoUsuarios.Clear()
        PantallaListar.Update()
        PantallaListar.Show()

        Me.Hide()
    End Sub
End Class