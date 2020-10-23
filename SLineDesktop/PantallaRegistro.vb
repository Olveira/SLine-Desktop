Public Class PantallaRegistro
    Dim username As String
    Dim email As String
    Dim password As String
    Dim sexo As String
    Dim fechaNac As Date
    Dim rol As String
    Dim token As Integer
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnSiguienteReg.Click
        Try
            username = tbxUserReg.Text
            email = tbxEmailReg.Text
            password = tbxContraseñaReg1.Text
            sexo = CStr(cbxSexo.SelectedItem)
            rol = CStr(cbxRol.SelectedItem)
            fechaNac = DTPFechaNac.Value

            Dim user As usuario
            user = New usuario(username, email, password, sexo, fechaNac, rol)


            Dim logicaUsuario As New logicaUsuario
            logicaUsuario.AltaUser(user)
            InicioADM.Show()
            Me.Hide()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub MeClose(sender As Object, e As EventArgs) Handles Me.Closed
        welcome.Show()
    End Sub
    Private Sub PantallaRegistro_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            cbxSexo.Items.Add("Masculino")
            cbxSexo.Items.Add("Femenino")
            cbxSexo.Items.Add("Otro")
            cbxRol.Items.Add("admin")
            cbxRol.Items.Add("user")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub CerrarRegistro(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        Try
            cbxSexo.Items.Clear()
            cbxRol.Items.Clear()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnback.Click
        Try
            welcome.Show()
            Me.Hide()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub tbxUserReg_TextChanged(sender As Object, e As EventArgs) Handles tbxUserReg.TextChanged

    End Sub
    Private Sub tbxUserChange(sender As Object, e As KeyPressEventArgs) Handles tbxUserReg.KeyPress
        Dim key = Convert.ToChar(Keys.Delete)
        If e.KeyChar = key And tbxUserReg.Text = "Nombre de Usuario" Then
            tbxUserReg.Text = ""
            tbxUserReg.ForeColor = Color.Black
        End If
        If e.KeyChar = key And tbxUserReg.Text = "" Then
            tbxUserReg.Text = "Nombre de Usuario"
            tbxUserReg.ForeColor = Color.Gray
        End If
    End Sub
End Class