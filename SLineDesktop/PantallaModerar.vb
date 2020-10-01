Public Class PantallaModerar

    Dim list As New List(Of caso)
    Dim CasoE As New caso

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
    Private Sub tsmlEliminar2_Click(sender As Object, e As EventArgs) Handles Me.Activated
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
        Try


            CasoE.IdCaso = Convert.ToString(ListaCasos.FocusedItem.SubItems(0).Text)
            CasoE.Descripcion = ListaCasos.FocusedItem.SubItems(1).Text
            CasoE.IdUsuario = Convert.ToString(ListaCasos.FocusedItem.SubItems(2).Text)
            CasoE.Verificado = Convert.ToBoolean(ListaCasos.FocusedItem.SubItems(3).Text)
            CasoE.Fecharegistro = Convert.ToDateTime(ListaCasos.FocusedItem.SubItems(4).Text)

            Dim logicaAceptar As New logicaCaso
            logicaAceptar.aceptarCasos(CasoE.IdCaso)

        Catch ex As Exception

        End Try
    End Sub


    Private Sub BtnDec_Click(sender As Object, e As EventArgs) Handles BtnDec.Click
        Dim indexSeleccionado As Integer
        indexSeleccionado = ListaCasos.FocusedItem.Index

        CasoE.IdCaso = ListaCasos.FocusedItem.SubItems(0).Text
        CasoE.Descripcion = ListaCasos.FocusedItem.SubItems(1).Text
        CasoE.IdUsuario = ListaCasos.FocusedItem.SubItems(2).Text
        CasoE.Verificado = ListaCasos.FocusedItem.SubItems(3).Text
        CasoE.Fecharegistro = ListaCasos.FocusedItem.SubItems(4).Text

        Dim logica As New logicaCaso
        logica.eliminarCaso(CasoE.IdCaso)
        ListaCasos.Items.Clear()
        Dim lista As New List(Of caso)
        lista = logica.listarCaso()
        Dim x As Integer
        x = logica.listarCaso.Count - 1
        Dim item As ListViewItem
        Dim arra(6) As String

        While x <> -1
            arra(0) = lista(x).IdCaso
            arra(1) = lista(x).Descripcion
            arra(2) = lista(x).IdUsuario
            arra(3) = lista(x).Verificado
            arra(4) = lista(x).Fecharegistro

            item = New ListViewItem(arra)
            ListaCasos.Items.Add(item)
            x = x - 1

        End While
    End Sub

    Public Sub selecValorUser()

    End Sub


End Class