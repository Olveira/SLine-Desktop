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
        Dim niceLog As Int16
        Dim persistencia As New persistenciaUsuario
        niceLog = persistencia.persistenciaLog(user, pass)

        Return niceLog

    End Function
End Class
