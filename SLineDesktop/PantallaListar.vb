Public Class PantallaListar
    Public userLog As New usuario
    Public user As New usuario
    Private Bool As Boolean = False
    Private Sub BtnExitListarPersonas_Click(sender As Object, e As EventArgs) Handles BtnExitListarPersonas.Click
        Welcome.Show()
        LogUser(userLog.Username, userLog.Id, False)
        Close()
    End Sub
    Public Sub LogUser(nombre As String, id As Integer, log As Boolean)
        userLog.Id = id
        userLog.Username = nombre
        userLog.Log = log
    End Sub
    Private Sub BtnMinimizeListarPersonas_Click(sender As Object, e As EventArgs) Handles BtnMinimizeListarPersonas.Click
        WindowState = FormWindowState.Minimized
    End Sub
    Private Sub MeClose(sender As Object, e As EventArgs) Handles Me.Closed
        Dispose()
    End Sub
    Private Sub BtnEditar_Click(sender As Object, e As EventArgs) Handles BtnEditar.Click
        If TomarUsuarioLV() Then
            If userLog.Log Then
                PantallaModificar.Show()
                PantallaModificar.SetUser(user)
                Hide()
            End If
        Else
            If userLog.Log Then
                PantallaModificar.Show()
                Hide()
            End If
        End If
    End Sub
    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        Try
            If Bool Then
                TomarUsuarioLV()
                Dim logica As New LogicaUsuario
                logica.EliminarUsuario(user.Id)
                ListarUsuarios()
            Else
                Registro.Show()
                Hide()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Alerta")
        End Try
    End Sub
    Private Sub BtnModerar_Click(sender As Object, e As EventArgs) Handles BtnModerar.Click
        If TomarUsuarioLV() Then
            If userLog.Log Then
                PantallaModerar.Show()
                PantallaModerar.ListarCasosUsuario(user.Id)
                Hide()
            End If
        End If
    End Sub
    Private Sub PantallaListar_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim pantalla = Screen.PrimaryScreen
        Dim width = (pantalla.Bounds.Width / 2) - 370
        Location = New Point(width, 100)
        BtnEliminar.Text = "Registrar"
        ListarUsuarios()
    End Sub
    Public Sub ListarUsuarios()
        Try
            LVListadoUsuarios.Items.Clear()
            Dim logica As New LogicaUsuario
            Dim lista = logica.ListarPersona()
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
            MessageBox.Show(ex.Message, "Alerta")
        End Try
    End Sub
    Private Sub LVListadoUsuarios_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LVListadoUsuarios.SelectedIndexChanged
        Bool = True
        BtnEliminar.Text = "Eliminar"
    End Sub
    Private Function TomarUsuarioLV()
        Try
            Dim itemSelected = LVListadoUsuarios.SelectedItems.Count
            If itemSelected = 0 Then
                MessageBox.Show("Primero selecciona un usuario")
                Bool = False
            Else
                user.Username = LVListadoUsuarios.FocusedItem.SubItems(0).Text
                user.Email = LVListadoUsuarios.FocusedItem.SubItems(1).Text
                user.Password = LVListadoUsuarios.FocusedItem.SubItems(2).Text
                user.Sexo = LVListadoUsuarios.FocusedItem.SubItems(3).Text
                user.FechaNac = Convert.ToDateTime(LVListadoUsuarios.FocusedItem.SubItems(4).Text)
                user.Rol = LVListadoUsuarios.FocusedItem.SubItems(5).Text
                user.Id = Convert.ToInt32(LVListadoUsuarios.FocusedItem.SubItems(6).Text)
                Bool = True
            End If
        Catch ex As Exception
            MessageBox.Show("error interno", "Alerta")
        End Try
        Return Bool
    End Function
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ListarUsuarios()
    End Sub
    'move'
    Public MoveForm As Boolean
    Public MoveForm_MousePosition As Point
    Public Sub MoveForm_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown
        If e.Button = MouseButtons.Left Then
            MoveForm = True
            Cursor = Cursors.NoMove2D
            MoveForm_MousePosition = e.Location
        End If
    End Sub
    Public Sub MoveForm_MouseMove(sender As Object, e As MouseEventArgs) Handles MyBase.MouseMove
        If MoveForm Then
            Location += e.Location - MoveForm_MousePosition
        End If
    End Sub
    Public Sub MoveForm_MouseUp(sender As Object, e As MouseEventArgs) Handles MyBase.MouseUp
        If e.Button = MouseButtons.Left Then
            MoveForm = False
            Cursor = Cursors.Default
        End If
    End Sub
End Class