Public Class logicaUsuario
    Public Sub AltaUser(users As usuario)
        Dim persistencia As New persistenciaUsuario
        persistencia.AltaUsuario(users)
    End Sub
End Class
