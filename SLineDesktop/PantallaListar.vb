Public Class PantallaListar
    Dim user As New usuario
    Private Sub ModerarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles tsmiModerar.Click
        PantallaModerar.Show()
        Me.Hide()
    End Sub

    Private Sub tsmiEliminar_Click(sender As Object, e As EventArgs)
        PantallaEliminar.Show()
        Me.Hide()
    End Sub

    Private Sub PantallaListar_Load(sender As Object, e As EventArgs) Handles Me.Load
        ListarUsiarios()
    End Sub
    Private Sub ListarUsiarios()
        Try
            LVListadoUsuarios.Items.Clear()
            Dim logica As New logicaUsuario
            Dim lista = logica.listarPersona()
            Dim i As Integer
            i = logica.listarPersona.Count - 1
            Dim item As ListViewItem
            Dim arra(7) As String

            While i <> -1
                arra(0) = lista(i).Username
                arra(1) = lista(i).Email
                arra(2) = lista(i).Password
                arra(3) = lista(i).Sexo
                arra(4) = lista(i).FechaNac
                arra(5) = lista(i).Rol
                arra(6) = lista(i).Id.ToString

                item = New ListViewItem(arra)
                LVListadoUsuarios.Items.Add(item)
                i = i - 1
            End While
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub
    Private Sub BtnEditar_Click(sender As Object, e As EventArgs) Handles BtnEditar.Click
        user.Username = LVListadoUsuarios.FocusedItem.SubItems(0).Text
        user.Email = LVListadoUsuarios.FocusedItem.SubItems(1).Text
        user.Password = LVListadoUsuarios.FocusedItem.SubItems(2).Text
        user.Sexo = LVListadoUsuarios.FocusedItem.SubItems(3).Text
        user.FechaNac = Convert.ToDateTime(LVListadoUsuarios.FocusedItem.SubItems(4).Text)
        user.Rol = LVListadoUsuarios.FocusedItem.SubItems(5).Text
        user.Id = Convert.ToInt32(LVListadoUsuarios.FocusedItem.SubItems(6).Text)

        PantallaEliminar.user = user
        PantallaEliminar.Show()
        Me.Hide()
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Try
            user.Username = LVListadoUsuarios.FocusedItem.SubItems(0).Text
            user.Email = LVListadoUsuarios.FocusedItem.SubItems(1).Text
            user.Password = LVListadoUsuarios.FocusedItem.SubItems(2).Text
            user.Sexo = LVListadoUsuarios.FocusedItem.SubItems(3).Text
            user.FechaNac = Convert.ToDateTime(LVListadoUsuarios.FocusedItem.SubItems(4).Text)
            user.Rol = LVListadoUsuarios.FocusedItem.SubItems(5).Text
            user.Id = Convert.ToInt32(LVListadoUsuarios.FocusedItem.SubItems(6).Text)

            Dim logica As New logicaUsuario
            logica.eliminarUsuario(user.Id)
            ListarUsiarios()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub PantallaListar_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        ListarUsiarios()
    End Sub
    Public Sub CloseMe(sender As Object, e As EventArgs) Handles Me.Closed
        welcome.Show()
    End Sub
End Class