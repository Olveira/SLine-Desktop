﻿Public Class PantallaModerar
    Private list As New List(Of caso)
    Private ReadOnly CasoS As New caso
    Private Todos As Boolean = False
    Private Sub BtnExitListarPersonas_Click(sender As Object, e As EventArgs) Handles BtnExitModerarCasos.Click
        PantallaListar.Show()
        PantallaListar.ListarUsuarios()
        Hide()
    End Sub
    Private Sub BtnMinimizeListarPersonas_Click(sender As Object, e As EventArgs) Handles BtnMinimizeModerarCasos.Click
        WindowState = FormWindowState.Minimized
    End Sub
    Private Sub MeLoad(sender As Object, e As EventArgs) Handles Me.Load
        Dim pantalla = Screen.PrimaryScreen
        Dim width = (pantalla.Bounds.Width / 2) - 370
        Location = New Point(width, 100)
    End Sub
    Private Sub BtnVerif_Click(sender As Object, e As EventArgs) Handles BtnAcep.Click
        Try
            CasoSelected()
            Dim logicaAceptar As New LogicaCaso
            logicaAceptar.aceptarCasos(CasoS.IdCaso)
            ListarCasos()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Alerta")
        End Try
    End Sub
    Private Sub BtnDec_Click(sender As Object, e As EventArgs) Handles BtnDec.Click
        Try
            CasoSelected()
            Dim Msg, Style, Title, Response
            Msg = "¿Seguro que quieres Declinar?"
            Style = vbOKCancel + vbCritical + vbDefaultButton1
            Title = "Alert"
            Response = MsgBox(Msg, Style, Title)
            If Response = vbOK Then
                Dim logicaEliminar As New LogicaCaso
                logicaEliminar.EliminarCaso(CasoS.IdCaso)
            Else
            End If
            ListarCasos()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub BtnTodos_Click(sender As Object, e As EventArgs) Handles BtnTodos.Click
        If Todos Then
            PantallaListar.Show()
            Hide()
        Else
            ListarCasos()
        End If
    End Sub
    Private Sub ListarCasos()
        Todos = True
        BtnTodos.Text = "Por Usuario"
        Try
            ListaCasos.Items.Clear()
            Dim logica As New LogicaCaso
            list = logica.ListarCasos()
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
            MessageBox.Show(ex.Message, "Alerta")
        End Try
    End Sub
    Public Sub ListarCasosUsuario(id As Integer)
        Todos = False
        BtnTodos.Text = "Todos"
        Try
            ListaCasos.Items.Clear()
            Dim logica As New LogicaCaso
            list = logica.ListarCasosUsuario(id)
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
            MessageBox.Show(ex.Message, "Alerta")
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
            MessageBox.Show(ex.Message, "Alerta")
        End Try
    End Sub
    Private Sub MeClosed(sender As Object, e As EventArgs) Handles Me.Closed
        PantallaListar.Show()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ListarCasos()
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