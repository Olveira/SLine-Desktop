Public Class Inicio
    'botones'
    Private Sub BtnExitLogin_Click(sender As Object, e As EventArgs) Handles BtnExitLogin.Click
        Dim pantalla = Screen.PrimaryScreen
        Dim width = pantalla.Bounds.Width / 2 - 370
        Welcome.Show()
        TbxPasswordLog.Text = "Nombre de Usuario"
        TbxUserLog.Text = "Contraseña"
        Hide()
    End Sub
    Private Sub BtnMinimizeLogin_Click(sender As Object, e As EventArgs) Handles BtnMinimizeLogin.Click
        WindowState = FormWindowState.Minimized
    End Sub
    Private Sub BtnAceptar_Click(sender As Object, e As EventArgs) Handles BtnAceptar.Click
        Try
            Dim logicaUsuario As New LogicaUsuario
            Dim niceLogIn As Boolean
            niceLogIn = logicaUsuario.Login(TbxUserLog.Text, TbxPasswordLog.Text)

            If niceLogIn Then
                PantallaListar.Show()
                Hide()
            Else
                TbxPasswordLog.Text = ""
                MessageBox.Show("Creenciales incorrectas")
            End If
        Catch ex As Exception
            MessageBox.Show("Fallo interno")
        End Try
    End Sub
    'textbox'
    Private Sub TbxUserLog_Enter(sender As Object, e As EventArgs) Handles TbxUserLog.Enter
        If TbxUserLog.Text = "Nombre de Usuario" Then
            TbxUserLog.Text = ""
            TbxUserLog.ForeColor = Color.Black
        End If
    End Sub
    Private Sub TbxUserLog_Leave(sender As Object, e As EventArgs) Handles TbxUserLog.Leave
        If TbxUserLog.Text = "" Then
            TbxUserLog.Text = "Nombre de Usuario"
            TbxUserLog.ForeColor = Color.Gray
        End If
    End Sub
    Private Sub TbxPasswordLog_Enter(sender As Object, e As EventArgs) Handles TbxPasswordLog.Enter
        If TbxPasswordLog.Text = "Contraseña" Then
            TbxPasswordLog.Text = ""
            TbxPasswordLog.ForeColor = Color.Black
            TbxPasswordLog.PasswordChar = "*"
        End If
    End Sub
    Private Sub TbxPasswordLog_Leave(sender As Object, e As EventArgs) Handles TbxPasswordLog.Leave
        If TbxPasswordLog.Text = "" Then
            TbxPasswordLog.Text = "Contraseña"
            TbxPasswordLog.PasswordChar = ""
            TbxPasswordLog.ForeColor = Color.Gray
        End If
    End Sub

    Private Sub Registrar_Click(sender As Object, e As EventArgs) Handles Registrar.Click
        Registro.Show()
        Hide()
    End Sub
    Private Sub MeLoad(sender As Object, e As EventArgs) Handles Me.Load
        Dim pantalla = Screen.PrimaryScreen
        Dim width = (pantalla.Bounds.Width / 2) - 360
        Location = New Point(width, 100)
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