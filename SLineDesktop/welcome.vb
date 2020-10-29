Public Class Welcome
    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles BtnExit.Click
        Application.Exit()
    End Sub
    Private Sub BtnMinimize_Click(sender As Object, e As EventArgs) Handles BtnMinimize.Click
        WindowState = FormWindowState.Minimized
    End Sub
    Private Sub btnGoRegistrar_Click(sender As Object, e As EventArgs) Handles btnGoRegistrar.Click
        Dim pantalla = Screen.PrimaryScreen
        Dim height = pantalla.Bounds.Height / 2 - 210
        Dim width = pantalla.Bounds.Width / 2 - 360
        Try
            With Registro
                .Location = New Point(width, height)
                .StartPosition = FormStartPosition.Manual
            End With
            Registro.Show()
            Me.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub btnGoLogin_Click(sender As Object, e As EventArgs) Handles btnGoLogin.Click
        Dim pantalla = Screen.PrimaryScreen
        Dim height = (pantalla.Bounds.Height / 2) - 190
        Dim width = (pantalla.Bounds.Width / 2) - 360
        Try
            With Inicio
                .Location = New Point(width, height)
                .StartPosition = FormStartPosition.Manual
            End With
            Inicio.Show()
            Me.Hide()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class