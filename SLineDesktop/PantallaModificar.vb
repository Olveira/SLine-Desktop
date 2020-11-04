Public Class PantallaModificar
    Public user As New usuario
    Private Sub BtnExitMod_Click(sender As Object, e As EventArgs) Handles BtnExitMod.Click
        PantallaListar.Show()
        Hide()
    End Sub
    Private Sub BtnMinimizeMod_Click(sender As Object, e As EventArgs) Handles BtnMinimizeMod.Click
        WindowState = FormWindowState.Minimized
    End Sub
    Private Sub BtnBuscarMod_Click(sender As Object, e As EventArgs) Handles BtnBuscarMod.Click
        Dim logica As New LogicaUsuario
        If TbxUserMod.Text <> "" Then
            SetUser(logica.BuscarPorUserEmail(TbxUserMod.Text, True))
        ElseIf TbxEmailMod.Text <> "" Then
            SetUser(logica.BuscarPorUserEmail(TbxEmailMod.Text, False))
        End If
    End Sub
    Private Sub MeLoad_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim pantalla = Screen.PrimaryScreen
        Dim width = (pantalla.Bounds.Width / 2) - 370
        Location = New Point(width, 100)
    End Sub
    Public Sub SetUser(Usuario As usuario)
        Try
            user = Usuario
            TbxContraseñaMod.Text = user.Password
            TbxEmailMod.Text = user.Email
            TbxUserMod.Text = user.Username
            CbxRolMod.Text = user.Rol
            CbxSexoMod.Text = user.Sexo
            DTPFechaNacMod.Value = user.FechaNac
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
            Dim logica As New LogicaUsuario
            logica.ModificarUsuario(user)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
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