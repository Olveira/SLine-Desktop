Public Class logicaCaso
    Public Function listarCaso() As List(Of caso)
        Dim persistencia As New persistenciaCaso
        Return persistencia.listarCasos()
    End Function

    Public Sub eliminarCaso(idCaso As Integer)
        Dim persistencia As New persistenciaCaso
        persistencia.eliminarCaso(idCaso)
    End Sub

End Class
