Public Class PantallaModerar
    Public Property LVListarCasos As Object

    Private Sub tsmiListar_Click(sender As Object, e As EventArgs) Handles tsmiListar.Click
        PantallaListar.LVListadoUsuarios.Items.Clear()
        PantallaListar.Activate()
        PantallaListar.Show()

        Me.Hide()
    End Sub

    Private Sub tsmlEliminar_Click(sender As Object, e As EventArgs) Handles MyBase.Activated
        LVListarCasos.Items.Clear()
        PantallaEliminar.Show()
        Me.Hide()

        Dim logica As New logicaCaso
        Dim list As New List(Of caso)
        list = logica.listarCaso()
        Dim x As Integer
        x = logica.listarCaso.Count - 1
        Dim item As ListViewItem
        Dim arra(5) As String

        While x <> -1
            arra(0) = list(x).IdCaso
            arra(1) = list(x).Coordenadas
            arra(2) = list(x).IdUsuario
            arra(3) = list(x).Verificado
            arra(4) = list(x).Fecharegistro

            item = New ListViewItem(arra)
            LVListarCasos.Items.Add(item)
            x = x - 1


        End While
    End Sub


    'Aceptar
    Private Sub BtnAcep_Click(sender As Object, e As EventArgs) Handles BtnAcep.Click

    End Sub

    'Declimar
    Private Sub BtnDec_Click(sender As Object, e As EventArgs) Handles BtnDec.Click

    End Sub
End Class