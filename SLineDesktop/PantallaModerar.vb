Public Class PantallaModerar

    Dim list As New List(Of caso)

    Private Sub tsmiListar_Click(sender As Object, e As EventArgs) Handles tsmiListar.Click
        PantallaListar.LVListadoUsuarios.Items.Clear()
        PantallaListar.Show()
        Me.Close()
    End Sub

    Private Sub tsmlEliminar_Click(sender As Object, e As EventArgs) Handles Me.Load
        ListaCasos.Items.Clear()

        Dim logica As New logicaCaso
        list = logica.listarCaso()
        Dim x As Integer
        x = list.Count
        Dim item As ListViewItem
        Dim arra(5) As String
        x = x - 1


        While x <> -1
            arra(0) = list(x).IdCaso
            arra(1) = list(x).Descripcion
            arra(2) = list(x).IdUsuario
            arra(3) = list(x).Verificado
            arra(4) = list(x).Fecharegistro

            item = New ListViewItem(arra)
            ListaCasos.Items.Add(item)
            x = x - 1
        End While
    End Sub



    Private Sub BtnAcep_Click(sender As Object, e As EventArgs) Handles BtnAcep.Click
        PantallaListar.Show()
        Me.Close()
    End Sub


    Private Sub BtnDec_Click(sender As Object, e As EventArgs) Handles BtnDec.Click
        Dim indexSeleccionado As Integer
        indexSeleccionado = ListaCasos.FocusedItem.Index
    End Sub

    Public Sub selecValorUser()

    End Sub


End Class