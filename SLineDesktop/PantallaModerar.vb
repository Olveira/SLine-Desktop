Public Class PantallaModerar
    Private list As New List(Of caso)
    Private CasoS As New caso
    Private Sub tsmiListar_Click(sender As Object, e As EventArgs) Handles tsmiListar.Click
        Try
            PantallaListar.Show()
            Me.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub
    Private Sub ListarCasos()
        Try
            ListaCasos.Items.Clear()

            Dim logica As New logicaCaso
            list = logica.listarCaso()
            Dim x As Integer
            x = list.Count - 1
            Dim item As ListViewItem
            Dim arra(5) As String


            While x <> -1
                arra(0) = list(x).IdCaso
                arra(1) = list(x).Descripcion
                arra(2) = list(x).IdUsuario
                arra(3) = list(x).Verificado
                arra(4) = list(x).Fecharegistro

                item = New ListViewItem(arra)
                ListaCasos.Items.Add(item)
                x -= 1
            End While
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub MeLoad(sender As Object, e As EventArgs) Handles Me.Load
        ListarCasos()
    End Sub
    Private Sub MeActivated(sender As Object, e As EventArgs) Handles Me.Activated
        ListarCasos()
    End Sub
    Private Sub BtnVerif_Click(sender As Object, e As EventArgs) Handles BtnAcep.Click
        Try
            CasoSelected()
            Dim logicaAceptar As New logicaCaso
            logicaAceptar.aceptarCasos(CasoS.IdCaso)
            ListarCasos()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub BtnDec_Click(sender As Object, e As EventArgs) Handles BtnDec.Click
        Try
            Dim indexSeleccionado As Integer
            indexSeleccionado = ListaCasos.FocusedItem.Index
            CasoSelected()
            'eliminar caso'
            ListarCasos()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub CasoSelected()
        Try
            Dim itemSelected = ListaCasos.SelectedItems.Count
            If itemSelected = 0 Then
                MessageBox.Show("Ninguno seleccionado")
            Else
                CasoS.IdCaso = Convert.ToString(ListaCasos.FocusedItem.SubItems(0).Text)
                CasoS.Descripcion = ListaCasos.FocusedItem.SubItems(1).Text
                CasoS.IdUsuario = Convert.ToString(ListaCasos.FocusedItem.SubItems(2).Text)
                CasoS.Verificado = Convert.ToBoolean(ListaCasos.FocusedItem.SubItems(3).Text)
                CasoS.Fecharegistro = Convert.ToDateTime(ListaCasos.FocusedItem.SubItems(4).Text)
            End If
        Catch ex As Exception

        End Try

    End Sub
End Class