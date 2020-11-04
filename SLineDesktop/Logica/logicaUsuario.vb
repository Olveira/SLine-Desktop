Public Class LogicaUsuario
    Public Sub AltaUser(users As usuario)
        Dim persistencia As New PersistenciaUsuario
        persistencia.AltaUsuario(users)
    End Sub
    Public Function ListarPersona() As List(Of usuario)
        Dim persistencia As New PersistenciaUsuario
        Return persistencia.ListarPersonas()
    End Function
    Public Function Login(user As String, pass As String) As Boolean
        Dim persistencia As New PersistenciaUsuario
        Return persistencia.PersistenciaLog(user, pass)
    End Function
    Public Function BuscarPorUserEmail(UnEm As String, Selector As Boolean)
        Dim persistencia As New PersistenciaUsuario
        Return persistencia.BuscarPorUserEmail(UnEm, Selector)
    End Function
    Public Sub ModificarUsuario(user As usuario)
        Dim persistencia As New PersistenciaUsuario
        persistencia.ModificarPersona(user)
    End Sub
    Public Sub EliminarUsuario(id As Integer)
        Dim persistencia As New PersistenciaUsuario
        persistencia.EliminarUsuario(id)
    End Sub
End Class
