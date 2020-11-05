Public Class Registro
    Dim username As String
    Dim email As String
    Dim password As String
    Dim sexo As String
    Dim fechaNac As Date
    Dim rol As String
    Private Sub BtnExitRegistro_Click(sender As Object, e As EventArgs) Handles BtnExitRegistro.Click
        Welcome.Show()
        Limpiar()
        Hide()
    End Sub
    Private Sub BtnMinimizeRegistro_Click(sender As Object, e As EventArgs) Handles BtnMinimizeRegistro.Click
        WindowState = FormWindowState.Minimized
    End Sub
    Private Sub BtnAceptarReg_Click(sender As Object, e As EventArgs) Handles btnAceptarReg.Click
        Try
            username = TbxUserReg.Text
            email = TbxEmailReg.Text
            password = TbxContraseñaReg.Text
            sexo = CStr(CbxSexo.SelectedItem)
            rol = CStr(CbxRol.SelectedItem)
            fechaNac = DTPFechaNac.Value
            Dim user As usuario
            user = New usuario(username, email, password, sexo, fechaNac, rol)
            Dim logicaUsuario As New LogicaUsuario
            logicaUsuario.AltaUser(user)
            Login.Show()
            Limpiar()
            Hide()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub MeClose(sender As Object, e As EventArgs) Handles Me.Closed
        Limpiar()
        Dispose()
    End Sub
    Private Sub PantallaRegistro_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim pantalla = Screen.PrimaryScreen
        Dim width = (pantalla.Bounds.Width / 2) - 360
        Location = New Point(width, 100)
        Limpiar()
    End Sub
    Private Sub Limpiar()
        Try
            TextBox()
            CbxSexo.Items.Clear()
            CbxRol.Items.Clear()
            CbxSexo.Items.Add("Masculino")
            CbxSexo.Items.Add("Femenino")
            CbxSexo.Items.Add("Otro")
            CbxRol.Items.Add("Admin")
            CbxRol.Items.Add("User")
            CbxRol.Text = "Rol"
            CbxSexo.Text = "Sexo"
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub TextBox()
        TbxContraseñaReg.Text = "Contraseña"
        TbxContraseñaReg.PasswordChar = ""
        TbxContraseñaReg.ForeColor = Color.Gray
        TbxUserReg.Text = "Nombre de Usuario"
        TbxUserReg.ForeColor = Color.Gray
        TbxEmailReg.Text = "Email"
        TbxEmailReg.ForeColor = Color.Gray
    End Sub
    Private Sub Contraseña()
        TbxContraseñaReg.Text = "Contraseña"
        TbxContraseñaReg.PasswordChar = ""
        TbxContraseñaReg.ForeColor = Color.Gray
    End Sub
    Private Sub BtnBack_Click(sender As Object, e As EventArgs) Handles btnback.Click
        Try
            Login.Show()
            Contraseña()
            Hide()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    'textbox'
    Private Sub TbxUserReg_Enter(sender As Object, e As EventArgs) Handles TbxUserReg.Enter
        If TbxUserReg.Text = "Nombre de Usuario" Then
            TbxUserReg.Text = ""
            TbxUserReg.ForeColor = Color.Black
        End If
    End Sub
    Private Sub TbxUserReg_Leave(sender As Object, e As EventArgs) Handles TbxUserReg.Leave
        If TbxUserReg.Text = "" Then
            TbxUserReg.Text = "Nombre de Usuario"
            TbxUserReg.ForeColor = Color.Gray
        End If
    End Sub
    Private Sub TbxPasswordReg_Enter(sender As Object, e As EventArgs) Handles TbxContraseñaReg.Enter
        If TbxContraseñaReg.Text = "Contraseña" Then
            TbxContraseñaReg.Text = ""
            TbxContraseñaReg.ForeColor = Color.Black
            TbxContraseñaReg.PasswordChar = "*"
        End If
    End Sub
    Private Sub TbxPasswordReg_Leave(sender As Object, e As EventArgs) Handles TbxContraseñaReg.Leave
        If TbxContraseñaReg.Text = "" Then
            TbxContraseñaReg.Text = "Contraseña"
            TbxContraseñaReg.PasswordChar = ""
            TbxContraseñaReg.ForeColor = Color.Gray
        End If
    End Sub
    Private Sub TbxEmailReg_Enter(sender As Object, e As EventArgs) Handles TbxEmailReg.Enter
        If TbxEmailReg.Text = "Email" Then
            TbxEmailReg.Text = ""
            TbxEmailReg.ForeColor = Color.Black
        End If
    End Sub
    Private Sub TbxEmailReg_Leave(sender As Object, e As EventArgs) Handles TbxEmailReg.Leave
        If TbxEmailReg.Text = "" Then
            TbxEmailReg.Text = "Email"
            TbxEmailReg.ForeColor = Color.Gray
        End If
    End Sub
    'move'
    Public MoveForm As Boolean
    Public MoveForm_MousePosition As Point

    Public Sub MoveForm_MouseDown(sender As Object, e As MouseEventArgs) Handles _
    MyBase.MouseDown ' Add more handles here (Example: PictureBox1.MouseDown)

        If e.Button = MouseButtons.Left Then
            MoveForm = True
            Cursor = Cursors.NoMove2D
            MoveForm_MousePosition = e.Location
        End If

    End Sub

    Public Sub MoveForm_MouseMove(sender As Object, e As MouseEventArgs) Handles _
    MyBase.MouseMove ' Add more handles here (Example: PictureBox1.MouseMove)

        If MoveForm Then
            Location += e.Location - MoveForm_MousePosition
        End If

    End Sub

    Public Sub MoveForm_MouseUp(sender As Object, e As MouseEventArgs) Handles _
    MyBase.MouseUp ' Add more handles here (Example: PictureBox1.MouseUp)

        If e.Button = MouseButtons.Left Then
            MoveForm = False
            Cursor = Cursors.Default
        End If

    End Sub
End Class