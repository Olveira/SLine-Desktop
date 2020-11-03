Public Class PantallaListar
    Public user As New usuario
    Private Sub BtnEditar_Click(sender As Object, e As EventArgs) Handles BtnEditar.Click
        tomarUsuarioLV()
        PantallaModificar.Show()
        Me.Hide()
    End Sub
    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        tomarUsuarioLV()
        Dim logica As New LogicaUsuario
        logica.EliminarUsuario(user.Id)
        ListarUsuarios()
    End Sub
    Private Sub BtnModerar_Click(sender As Object, e As EventArgs) Handles BtnModerar.Click
        PantallaModerar.Show()
        Hide()
    End Sub
    Private Sub BtnExitListarPersonas_Click(sender As Object, e As EventArgs) Handles BtnExitListarPersonas.Click
        Welcome.Show()
        Me.Hide()
    End Sub
    Private Sub BtnMinimizeListarPersonas_Click(sender As Object, e As EventArgs) Handles BtnMinimizeListarPersonas.Click
        WindowState = FormWindowState.Minimized
    End Sub
    Private Sub PantallaListar_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim pantalla = Screen.PrimaryScreen
        Dim width = (pantalla.Bounds.Width / 2) - 370
        Location = New Point(width, 100)
        ListarUsuarios()
    End Sub
    Public Sub ListarUsuarios()
        Try
            LVListadoUsuarios.Items.Clear()
            Dim logica As New LogicaUsuario
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
    'move'
    Public MoveForm As Boolean
    Public MoveForm_MousePosition As Point
    Public Sub MoveForm_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown
        If e.Button = MouseButtons.Left Then
            MoveForm = True
            Me.Cursor = Cursors.NoMove2D
            MoveForm_MousePosition = e.Location
        End If
    End Sub
    Public Sub MoveForm_MouseMove(sender As Object, e As MouseEventArgs) Handles MyBase.MouseMove
        If MoveForm Then
            Me.Location = Me.Location + (e.Location - MoveForm_MousePosition)
        End If
    End Sub

    Public Sub MoveForm_MouseUp(sender As Object, e As MouseEventArgs) Handles MyBase.MouseUp
        If e.Button = MouseButtons.Left Then
            MoveForm = False
            Me.Cursor = Cursors.Default
        End If
    End Sub
End Class