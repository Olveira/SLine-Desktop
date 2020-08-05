Public Class logicaUsuario
    Public Sub AltaUser(users As usuario)
        Dim persistencia As New persistenciaUsuario
        persistencia.AltaUsuario(users)
    End Sub
    Public Function login(user As String, pass As String) As Boolean
        Dim niceLog As Boolean
        Dim persistencia As New persistenciaUsuario
        niceLog = persistencia.persistenciaLog(user, pass)

        Return niceLog

    End Function
End Class
