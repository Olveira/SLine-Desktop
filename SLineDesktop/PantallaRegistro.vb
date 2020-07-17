Public Class PantallaRegistro
    Dim username As String
    Dim email As String
    Dim password As String
    Dim sexo As String
    Dim fechaNac As Date
    Dim rol As String
    Dim token As Integer
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnSiguienteReg.Click
        username = tbxUserReg.Text
        email = tbxEmailReg.Text
        password = tbxContraseñaReg1.Text
        token = tbxToken.Text
        sexo = CStr(cbxSexo.SelectedItem)
        rol = CStr(cbxRol.SelectedItem)
        fechaNac = DTPFechaNac.Value.ToString

        Dim user As usuario
        user = New usuario(username, email, password, sexo, fechaNac, rol, token)
        'user.Username = username
        'user.Email = email
        'user.Password = password
        'user.Sexo = sexo
        'user.Rol = rol
        'user.Token = token
        'user.FechaNac = fechaNac

        Dim logicaUsuario As New logicaUsuario
        logicaUsuario.AltaUser(user)

    End Sub

    Private Sub PantallaRegistro_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cbxSexo.Items.Add("Masculino")
        cbxSexo.Items.Add("Femenino")
        cbxSexo.Items.Add("Otro")
        cbxRol.Items.Add("admin")
        cbxRol.Items.Add("user")

        tbxUserReg.Text = "agustin"
        tbxEmailReg.Text = "agustin@gmail.com"
        tbxContraseñaReg1.Text = "agustin1234"
        tbxToken.Text = "1234"
        cbxRol.Text = "admin"
        cbxSexo.Text = "masculino"


    End Sub

    Private Sub CerrarRegistro(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing

        cbxSexo.Items.Clear()
        cbxRol.Items.Clear()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Label2.Text = fechaNac
    End Sub
End Class