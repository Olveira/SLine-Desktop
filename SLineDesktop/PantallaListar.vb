Public Class PantallaListar
    Private Sub ModerarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles tsmiModerar.Click
        PantallaModerar.ShowDialog()
    End Sub

    Private Sub tsmiEliminar_Click(sender As Object, e As EventArgs) Handles tsmiEliminar.Click
        PantallaEliminar.ShowDialog()
    End Sub
End Class