Public Class InicioADM
    Private Sub BtnSiguiente_Click(sender As Object, e As EventArgs) Handles BtnSiguiente.Click
        Dim logicaUsuario As New logicaUsuario
        Dim niceLogIn As Boolean
        niceLogIn = logicaUsuario.login(tbxUserLog.Text, tbxUserLog.Text)

        If niceLogIn Then
            PantallaListar.ShowDialog()
            Me.Close()
        Else

        End If
    End Sub
End Class