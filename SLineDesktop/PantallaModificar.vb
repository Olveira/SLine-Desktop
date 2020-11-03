Public Class PantallaModificar
    Public user As New usuario
    Private Sub ListarToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Try
            PantallaListar.LVListadoUsuarios.Clear()
            PantallaListar.Update()
            PantallaListar.Show()
            Me.Hide()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub PantallaEliminar_Load(sender As Object, e As EventArgs) Handles Me.Load
        Try
            Me.user = PantallaListar.user
            tbxContraseñaMod.Text = user.Password
            tbxEmailMod.Text = user.Email
            tbxUserMod.Text = user.Username
            cbxRolMod.Text = user.Rol
            cbxSexoMod.Text = user.Sexo
            DTPFechaNacMod.Value = user.FechaNac
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub MeLoad(sender As Object, e As EventArgs) Handles Me.Closed
        PantallaListar.ListarUsuarios()
        PantallaListar.Show()
    End Sub
    Private Sub ModerarToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Try
            PantallaModerar.Show()
            Me.Hide()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub BtnAceptarMod_Click(sender As Object, e As EventArgs) Handles BtnAceptarMod.Click
        Try
            user.Email = tbxEmailMod.Text
            user.FechaNac = DTPFechaNacMod.Value
            user.Sexo = cbxSexoMod.Text
            user.Rol = cbxRolMod.Text
            user.Password = tbxContraseñaMod.Text
            user.Username = tbxUserMod.Text
            Dim logica As New logicaUsuario
            logica.ModificarUsuario(user)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub btnCancelarMod_Click(sender As Object, e As EventArgs) Handles btnCancelarMod.Click
        Try
            Me.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub lblModificarUsuario_Click(sender As Object, e As EventArgs) Handles lblModificarUsuario.Click

    End Sub

    Private Sub TbxEmailMod_TextChanged(sender As Object, e As EventArgs) Handles TbxEmailMod.TextChanged

    End Sub
End Class