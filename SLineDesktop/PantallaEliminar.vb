﻿Public Class PantallaEliminar
    Private Sub ListarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListarToolStripMenuItem.Click
        PantallaListar.Show()
        Me.Hide()

    End Sub

    Private Sub ModerarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ModerarToolStripMenuItem.Click

        PantallaModerar.Show()
        Me.Hide()
    End Sub

    Private Sub PantallaEliminar_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class