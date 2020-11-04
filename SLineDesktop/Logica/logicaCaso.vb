Public Class LogicaCaso
    Public Function ListarCasos()
        Dim persistencia As New PersistenciaCaso
        Return persistencia.ListarCasos()
    End Function
    Public Function ListarCasosUsuario(id As Integer)
        Dim persistencia As New PersistenciaCaso
        Return persistencia.ListarCasosUsuario(id)
    End Function
    Public Sub EliminarCaso(idCaso As Integer)
        Dim persistencia As New PersistenciaCaso
        persistencia.EliminarCaso(idCaso)
    End Sub
    Public Function AceptarCasos(idCaso As Integer)
        Dim persistencia As New PersistenciaCaso
        persistencia.AceptarCasos(idCaso)
        Return persistencia.ListarCasos()
    End Function
End Class