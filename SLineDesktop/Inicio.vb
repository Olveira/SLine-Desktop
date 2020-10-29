Public Class Inicio
    'botones'
    Private Sub BtnExitLogin_Click(sender As Object, e As EventArgs) Handles BtnExitLogin.Click
        Welcome.Show()
        TbxPasswordLog.Text = ""
        TbxUserLog.Text = ""
        Me.Dispose()
    End Sub
    Private Sub BtnMinimizeLogin_Click(sender As Object, e As EventArgs) Handles BtnMinimizeLogin.Click
        WindowState = FormWindowState.Minimized
    End Sub
    Private Sub BtnAceptar_Click(sender As Object, e As EventArgs) Handles BtnAceptar.Click
        Try
            Dim logicaUsuario As New logicaUsuario
            Dim niceLogIn As Boolean
            niceLogIn = logicaUsuario.login(TbxUserLog.Text, TbxPasswordLog.Text)

            If niceLogIn Then
                PantallaListar.Show()
                Me.Hide()
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
        Me.Close()
    End Sub
End Class