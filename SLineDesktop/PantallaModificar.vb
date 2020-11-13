Public Class PantallaModificar
    Public user As New usuario
    Private Sub BtnExitMod_Click(sender As Object, e As EventArgs) Handles BtnExitMod.Click
        PantallaListar.Show()
        PantallaListar.ListarUsuarios()
        Limpiar()
        Hide()
    End Sub
    Private Sub BtnMinimizeMod_Click(sender As Object, e As EventArgs) Handles BtnMinimizeMod.Click
        WindowState = FormWindowState.Minimized
    End Sub
    Private Sub BtnBuscarMod_Click(sender As Object, e As EventArgs) Handles BtnBuscarMod.Click
        Dim logica As New LogicaUsuario
        If TbxUserMod.Text <> "Nombre de Usuario" Then
            SetUser(logica.BuscarPorUserEmail(TbxUserMod.Text, True))
        ElseIf TbxEmailMod.Text <> "Email" Then
            SetUser(logica.BuscarPorUserEmail(TbxEmailMod.Text, False))
        End If
    End Sub
    Private Sub MeLoad_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim pantalla = Screen.PrimaryScreen
        Dim width = (pantalla.Bounds.Width / 2) - 370
        Location = New Point(width, 100)
        Limpiar()
    End Sub
    Public Sub SetUser(Usuario As usuario)
        Try
            user = Usuario
            If user.Email = "" Then
                MessageBox.Show("No Existe el Usuario")
                Limpiar()
            Else
                TbxEmailMod.Text = user.Email
                TbxUserMod.Text = user.Username
                CbxRolMod.Text = user.Rol
                CbxSexoMod.Text = user.Sexo
                DTPFechaNacMod.Value = user.FechaNac
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub BtnAceptarMod_Click(sender As Object, e As EventArgs) Handles BtnAceptarMod.Click
        Try
            user.Email = tbxEmailMod.Text
            user.FechaNac = DTPFechaNacMod.Value
            user.Sexo = cbxSexoMod.Text
            user.Rol = CbxRolMod.Text
            If TbxContraseñaMod.Text = "Contraseña" Then
                MessageBox.Show("No escribiste tu contraseña")
            ElseIf TbxContraseñaMod.Text = "" Then
                MessageBox.Show("escribi algo")
            Else
                user.Password = TbxContraseñaMod.Text
            End If
            user.Password = tbxContraseñaMod.Text
            user.Username = tbxUserMod.Text
            Dim logica As New LogicaUsuario
            logica.ModificarUsuario(user)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub Limpiar()
        CbxSexoMod.Items.Clear()
        CbxRolMod.Items.Clear()
        CbxSexoMod.Items.Add("Masculino")
        CbxSexoMod.Items.Add("Femenino")
        CbxSexoMod.Items.Add("Otro")
        CbxRolMod.Items.Add("Admin")
        CbxRolMod.Items.Add("User")
        CbxRolMod.Text = "Rol"
        CbxSexoMod.Text = "Sexo"
        TextBox()
    End Sub
    Private Sub TextBox()
        TbxContraseñaMod.Text = "Contraseña"
        TbxContraseñaMod.PasswordChar = ""
        TbxContraseñaMod.ForeColor = Color.Gray
        TbxUserMod.Text = "Nombre de Usuario"
        TbxUserMod.ForeColor = Color.Gray
        TbxEmailMod.Text = "Email"
        TbxEmailMod.ForeColor = Color.Gray
    End Sub
    'textbox'
    Private Sub TbxUserReg_Enter(sender As Object, e As EventArgs) Handles TbxUserMod.Enter
        If TbxUserMod.Text = "Nombre de Usuario" Then
            TbxUserMod.Text = ""
            TbxUserMod.ForeColor = Color.Black
        End If
    End Sub
    Private Sub TbxUserReg_Leave(sender As Object, e As EventArgs) Handles TbxUserMod.Leave
        If TbxUserMod.Text = "" Then
            TbxUserMod.Text = "Nombre de Usuario"
            TbxUserMod.ForeColor = Color.Gray
        End If
    End Sub
    Private Sub TbxPasswordReg_Enter(sender As Object, e As EventArgs) Handles TbxContraseñaMod.Enter
        If TbxContraseñaMod.Text = "Contraseña" Then
            TbxContraseñaMod.Text = ""
            TbxContraseñaMod.ForeColor = Color.Black
            TbxContraseñaMod.PasswordChar = "*"
        End If
    End Sub
    Private Sub TbxPasswordReg_Leave(sender As Object, e As EventArgs) Handles TbxContraseñaMod.Leave
        If TbxContraseñaMod.Text = "" Then
            TbxContraseñaMod.Text = "Contraseña"
            TbxContraseñaMod.PasswordChar = ""
            TbxContraseñaMod.ForeColor = Color.Gray
        End If
    End Sub
    Private Sub TbxEmailReg_Enter(sender As Object, e As EventArgs) Handles TbxEmailMod.Enter
        If TbxEmailMod.Text = "Email" Then
            TbxEmailMod.Text = ""
            TbxEmailMod.ForeColor = Color.Black
        End If
    End Sub
    Private Sub TbxEmailReg_Leave(sender As Object, e As EventArgs) Handles TbxEmailMod.Leave
        If TbxEmailMod.Text = "" Then
            TbxEmailMod.Text = "Email"
            TbxEmailMod.ForeColor = Color.Gray
        End If
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