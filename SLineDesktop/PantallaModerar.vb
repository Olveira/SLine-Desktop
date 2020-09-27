Public Class PantallaModerar

    Dim list As New List(Of caso)

    Private Sub tsmiListar_Click(sender As Object, e As EventArgs) Handles tsmiListar.Click
        PantallaListar.LVListadoUsuarios.Items.Clear()
        PantallaListar.Show()
        Me.Close()
    End Sub

    Private Sub tsmlEliminar_Click(sender As Object, e As EventArgs) Handles Me.Load
        ListCasos.Items.Clear()

        Dim logica As New logicaCaso
        list = logica.listarCaso()
        Dim x As Integer
        x = list.Count
        Dim item As ListViewItem
        Dim arra(3) As String

        While x <> -1
            arra(0) = list(x).IdCaso
            arra(1) = list(x).Descripcion
            arra(2) = list(x).IdUsuario
            arra(3) = list(x).Fecharegistro
            item = New ListViewItem(arra)
            ListCasos.Items.Add(item)
            x = x - 1


        End While
    End Sub



    Private Sub BtnAcep_Click(sender As Object, e As EventArgs) Handles BtnAcep.Click
        PantallaListar.Show()
        Me.Close()
    End Sub


    Private Sub BtnDec_Click(sender As Object, e As EventArgs) Handles BtnDec.Click
        Dim indexSeleccionado As Integer
        indexSeleccionado = ListCasos.FocusedItem.Index
    End Sub

    Public Sub selecValorUser()

    End Sub


End Class