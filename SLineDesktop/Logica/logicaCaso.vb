Public Class LogicaCaso
    Public Function listarCaso() As List(Of caso)
        Dim persistencia As New PersistenciaCaso
        Return persistencia.ListarCasos()
    End Function
    Public Sub eliminarCaso(idCaso As Integer)
        Dim persistencia As New PersistenciaCaso
        persistencia.EliminarCaso(idCaso)
    End Sub
    Public Function aceptarCasos(idCaso As Integer) As List(Of caso)
        Dim persistencia As New PersistenciaCaso
        persistencia.AceptarCasos(idCaso)
        Return persistencia.ListarCasos()
    End Function
End Class