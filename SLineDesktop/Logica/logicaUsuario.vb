Public Class logicaUsuario
    Public Sub AltaUser(users As usuario)
        Dim persistencia As New persistenciaUsuario
        persistencia.AltaUsuario(users)
    End Sub
    Public Function listarPersona() As List(Of usuario)
        Dim persistencia As New persistenciaUsuario
        Return persistencia.listarPersonas()
    End Function
    Public Function login(user As String, pass As String) As Boolean
        Dim persistencia As New persistenciaUsuario
        Return persistencia.persistenciaLog(user, pass)
    End Function
    Public Sub ModificarUsuario(user As usuario)
        Dim persistencia As New persistenciaUsuario
        persistencia.modificarPersona(user)
    End Sub
    Public Sub eliminarUsuario(id As Integer)
        Dim persistencia As New persistenciaUsuario
        persistencia.eliminarUsuario(id)
    End Sub
End Class
