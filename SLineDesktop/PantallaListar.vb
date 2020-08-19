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
        i = logica.listarPersona.Count - 1
        Dim item As ListViewItem
        Dim arra(7) As String

        While i <> -1
            arra(0) = lista(i).Username
            arra(1) = lista(i).Email
            arra(2) = lista(i).Password
            arra(3) = lista(i).Sexo
            arra(4) = lista(i).FechaNac
            arra(5) = lista(i).Rol
            arra(6) = lista(i).Token
            arra(7) = lista(i).Id

            item = New ListViewItem(arra)
            LVListadoUsuarios.Items.Add(item)
            i = i - 1

        End While

    End Sub
End Class