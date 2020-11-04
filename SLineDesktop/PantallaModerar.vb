Public Class PantallaModerar
    Private list As New List(Of caso)
    Private CasoS As New caso
    Private Sub BtnExitListarPersonas_Click(sender As Object, e As EventArgs) Handles BtnExitModerarCasos.Click
        PantallaListar.Show()
        Hide()
    End Sub
    Private Sub BtnMinimizeListarPersonas_Click(sender As Object, e As EventArgs) Handles BtnMinimizeModerarCasos.Click
        WindowState = FormWindowState.Minimized
    End Sub
    Private Sub TsmiListar_Click(sender As Object, e As EventArgs)
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

            Dim logica As New LogicaCaso
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
        Dim pantalla = Screen.PrimaryScreen
        Dim width = (pantalla.Bounds.Width / 2) - 370
        Location = New Point(width, 100)
        ListarCasos()
    End Sub
    Private Sub BtnVerif_Click(sender As Object, e As EventArgs) Handles BtnAcep.Click
        Try
            CasoSelected()
            Dim logicaAceptar As New LogicaCaso
            logicaAceptar.aceptarCasos(CasoS.IdCaso)
            ListarCasos()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub BtnDec_Click(sender As Object, e As EventArgs) Handles BtnDec.Click
        Try
            CasoSelected()
            Dim logicaEliminar As New LogicaCaso
            logicaEliminar.eliminarCaso(CasoS.IdCaso)
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
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub MeClosed(sender As Object, e As EventArgs) Handles Me.Closed
        PantallaListar.Show()
    End Sub
    'move'
    Public MoveForm As Boolean
    Public MoveForm_MousePosition As Point
    Public Sub MoveForm_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown
        If e.Button = MouseButtons.Left Then
            MoveForm = True
            Cursor = Cursors.NoMove2D
            MoveForm_MousePosition = e.Location
        End If
    End Sub
    Public Sub MoveForm_MouseMove(sender As Object, e As MouseEventArgs) Handles MyBase.MouseMove
        If MoveForm Then
            Location += e.Location - MoveForm_MousePosition
        End If
    End Sub

    Public Sub MoveForm_MouseUp(sender As Object, e As MouseEventArgs) Handles MyBase.MouseUp
        If e.Button = MouseButtons.Left Then
            MoveForm = False
            Cursor = Cursors.Default
        End If
    End Sub
End Class