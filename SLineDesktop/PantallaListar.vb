Public Class PantallaListar
    Public user As New usuario
    Private Sub ModerarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles tsmiModerar.Click
        PantallaModerar.Show()
        Me.Hide()
    End Sub
    Private Sub tsmiEliminar_Click(sender As Object, e As EventArgs)
        PantallaModificar.Show()
        Me.Hide()
    End Sub
    Private Sub PantallaListar_Load(sender As Object, e As EventArgs) Handles Me.Load
        ListarUsuarios()
    End Sub
    Public Sub ListarUsuarios()
        Try
            LVListadoUsuarios.Items.Clear()
            Dim logica As New logicaUsuario
            Dim lista = logica.listarPersona()
            Dim i = lista.Count - 1
            Dim arra(7) As String
            While i <> -1
                arra(0) = lista(i).Username
                arra(1) = lista(i).Email
                arra(2) = lista(i).Password
                arra(3) = lista(i).Sexo
                arra(4) = lista(i).FechaNac
                arra(5) = lista(i).Rol
                arra(6) = lista(i).Id.ToString
                Dim item = New ListViewItem(arra)
                LVListadoUsuarios.Items.Add(item)
                i -= 1
            End While
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub BtnEditar_Click(sender As Object, e As EventArgs) Handles BtnEditar.Click
        tomarUsuarioLV()
        PantallaModificar.user = user
        PantallaModificar.Show()
        Me.Hide()
    End Sub
    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        tomarUsuarioLV()
        Dim logica As New logicaUsuario
        logica.eliminarUsuario(user.Id)
        ListarUsuarios()
    End Sub
    Private Sub CloseMe(sender As Object, e As EventArgs) Handles Me.Closed
        welcome.Show()
    End Sub
    Private Sub tomarUsuarioLV()
        Try
            Dim itemSelected = LVListadoUsuarios.SelectedItems.Count
            If itemSelected = 0 Then
                MessageBox.Show("Primero selecciona un usuario")
            Else
                user.Username = LVListadoUsuarios.FocusedItem.SubItems(0).Text
                user.Email = LVListadoUsuarios.FocusedItem.SubItems(1).Text
                user.Password = LVListadoUsuarios.FocusedItem.SubItems(2).Text
                user.Sexo = LVListadoUsuarios.FocusedItem.SubItems(3).Text
                user.FechaNac = Convert.ToDateTime(LVListadoUsuarios.FocusedItem.SubItems(4).Text)
                user.Rol = LVListadoUsuarios.FocusedItem.SubItems(5).Text
                user.Id = Convert.ToInt32(LVListadoUsuarios.FocusedItem.SubItems(6).Text)
            End If
        Catch ex As Exception
            MessageBox.Show("error interno")
        End Try
    End Sub
End Class