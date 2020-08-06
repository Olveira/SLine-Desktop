Public Class PantallaEliminar
    Private Sub ListarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListarToolStripMenuItem.Click
        PantallaListar.ShowDialog()
    End Sub

    Private Sub ModerarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ModerarToolStripMenuItem.Click
        PantallaModerar.ShowDialog()
    End Sub
End Class