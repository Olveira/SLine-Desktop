﻿Public Class InicioADM
    Private Sub BtnSiguiente_Click(sender As Object, e As EventArgs) Handles BtnSiguiente.Click
        Dim logicaUsuario As New logicaUsuario
        Dim niceLogIn As Int16
        niceLogIn = logicaUsuario.login(tbxUserLog.Text, tbxPasswordLog.Text)

        If niceLogIn Then
            PantallaListar.ShowDialog()
            Me.Close()
        Else

            lblBadLog.Text = "creenciales incorrectas"
        End If

    End Sub

    Private Sub InicioADM_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblBadLog.Text = ""
    End Sub

    Private Sub BtnAtras_Click(sender As Object, e As EventArgs) Handles BtnAtras.Click
        Me.Close()
    End Sub
End Class