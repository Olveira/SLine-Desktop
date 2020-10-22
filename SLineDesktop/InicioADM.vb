Public Class InicioADM
    Private Sub BtnSiguiente_Click(sender As Object, e As EventArgs) Handles BtnSiguiente.Click
        Try
            Dim logicaUsuario As New logicaUsuario
            Dim niceLogIn As Boolean
            niceLogIn = logicaUsuario.login(tbxUserLog.Text, tbxPasswordLog.Text)

            If niceLogIn Then
                PantallaListar.Show()
                Me.Hide()
            Else
                tbxPasswordLog.Text = ""
                MessageBox.Show("Creenciales incorrectas")
            End If
        Catch ex As Exception
            MessageBox.Show("Fallo interno")
        End Try
    End Sub
    Private Sub InicioADM_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            lblBadLog.Text = ""
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub BtnAtras_Click(sender As Object, e As EventArgs) Handles BtnAtras.Click
        Me.Close()
        welcome.Show()
    End Sub
    Private Sub CloseMe(sender As Object, e As EventArgs) Handles Me.Closed
        tbxPasswordLog.Text = ""
        tbxUserLog.Text = ""
    End Sub
End Class