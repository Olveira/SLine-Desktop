Public Class PantallaModerar
    Private Sub tsmiListar_Click(sender As Object, e As EventArgs) Handles tsmiListar.Click
        PantallaListar.LVListadoUsuarios.Clear()
        PantallaListar.Update()
        PantallaListar.Show()

        Me.Hide()
    End Sub

    Private Sub tsmlEliminar_Click(sender As Object, e As EventArgs) Handles tsmlEliminar.Click
        PantallaEliminar.Show()
        Me.Hide()
    End Sub
End Class