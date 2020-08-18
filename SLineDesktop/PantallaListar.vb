Public Class PantallaListar
    Private Sub ModerarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles tsmiModerar.Click
        PantallaModerar.ShowDialog()
    End Sub

    Private Sub tsmiEliminar_Click(sender As Object, e As EventArgs) Handles tsmiEliminar.Click
        PantallaEliminar.ShowDialog()
    End Sub

    Private Sub PantallaListar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim logica As New logicaUsuario
        Dim lista As New List(Of usuario)
        lista = logica.listarPersona()
        Dim i As Integer
        i = logica.listarPersona.Count
        While i <> 0
            Dim item = New ListViewItem(lista(i).Username)
            item.SubItems.Add(lista(i).Email)
            item.SubItems.Add(lista(i).Password)
            item.SubItems.Add(lista(i).Sexo)
            item.SubItems.Add(lista(i).FechaNac)
            item.SubItems.Add(lista(i).Rol)
            LVListadoUsuarios.Items.Add(item)
            i = i - 1
        End While

    End Sub
End Class