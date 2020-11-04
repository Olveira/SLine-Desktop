Public Class Registro
    Dim username As String
    Dim email As String
    Dim password As String
    Dim sexo As String
    Dim fechaNac As Date
    Dim rol As String
    Dim token As Integer
    Private Sub BtnExitRegistro_Click(sender As Object, e As EventArgs) Handles BtnExitRegistro.Click
        Welcome.Show()
        Hide()
        Limpiar()
    End Sub
    Private Sub BtnMinimizeRegistro_Click(sender As Object, e As EventArgs) Handles BtnMinimizeRegistro.Click
        WindowState = FormWindowState.Minimized
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnAceptarReg.Click
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
            Hide()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub MeClose(sender As Object, e As EventArgs) Handles Me.Closed
        Dispose()
    End Sub
    Private Sub PantallaRegistro_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim pantalla = Screen.PrimaryScreen
        Dim width = (pantalla.Bounds.Width / 2) - 360
        Location = New Point(width, 100)
        Try
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
    Private Sub Limpiar()
        Try
            TbxContraseñaReg.Text = ""
            TbxEmailReg.Text = ""
            TbxUserReg.Text = ""
            CbxSexo.Items.Clear()
            CbxRol.Items.Clear()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnback.Click
        Try
            Login.Show()
            Me.Hide()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub tbxUserReg_TextChanged(sender As Object, e As EventArgs) Handles TbxUserReg.Click
        TbxUserReg.Text = ""
    End Sub

    Private Sub tbxEmailReg_TextChanged(sender As Object, e As EventArgs) Handles TbxEmailReg.Click
        TbxEmailReg.Text = ""
    End Sub

    Private Sub tbxContraseñaReg1_TextChanged(sender As Object, e As EventArgs) Handles TbxContraseñaReg.Click
        TbxContraseñaReg.Text = ""
    End Sub
    'textbox'
    Private Sub TbxUserReg_Enter(sender As Object, e As EventArgs) Handles TbxUserReg.Enter
        If TbxUserReg.Text = "Nombre de Usuario" Then
            TbxUserReg.Text = ""
            TbxUserReg.ForeColor = Color.Black
        End If
    End Sub
    Private Sub TbxUserLog_Leave(sender As Object, e As EventArgs) Handles TbxUserReg.Leave
        If TbxUserReg.Text = "" Then
            TbxUserReg.Text = "Nombre de Usuario"
            TbxUserReg.ForeColor = Color.Gray
        End If
    End Sub
    Private Sub TbxPasswordLog_Enter(sender As Object, e As EventArgs) Handles TbxContraseñaReg.Enter
        If TbxContraseñaReg.Text = "Password" Then
            TbxContraseñaReg.Text = ""
            TbxContraseñaReg.ForeColor = Color.Black
            TbxContraseñaReg.PasswordChar = "*"
        End If
    End Sub
    Private Sub TbxPasswordLog_Leave(sender As Object, e As EventArgs) Handles TbxContraseñaReg.Leave
        If TbxContraseñaReg.Text = "" Then
            TbxContraseñaReg.Text = "Password"
            TbxContraseñaReg.PasswordChar = ""
            TbxContraseñaReg.ForeColor = Color.Gray
        End If
    End Sub
    'move'
    Public MoveForm As Boolean
    Public MoveForm_MousePosition As Point

    Public Sub MoveForm_MouseDown(sender As Object, e As MouseEventArgs) Handles _
    MyBase.MouseDown ' Add more handles here (Example: PictureBox1.MouseDown)

        If e.Button = MouseButtons.Left Then
            MoveForm = True
            Me.Cursor = Cursors.NoMove2D
            MoveForm_MousePosition = e.Location
        End If

    End Sub

    Public Sub MoveForm_MouseMove(sender As Object, e As MouseEventArgs) Handles _
    MyBase.MouseMove ' Add more handles here (Example: PictureBox1.MouseMove)

        If MoveForm Then
            Me.Location = Me.Location + (e.Location - MoveForm_MousePosition)
        End If

    End Sub

    Public Sub MoveForm_MouseUp(sender As Object, e As MouseEventArgs) Handles _
    MyBase.MouseUp ' Add more handles here (Example: PictureBox1.MouseUp)

        If e.Button = MouseButtons.Left Then
            MoveForm = False
            Me.Cursor = Cursors.Default
        End If

    End Sub
End Class