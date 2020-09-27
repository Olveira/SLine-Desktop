Public Class logicaCaso
    Public Function listarCaso() As List(Of caso)
        Dim persistencia As New persistenciaCaso
        Return persistencia.listarCaso()

    End Function

End Class
