Public Class logicaCaso
    Public Function listarCaso() As List(Of caso)
        Dim perListado As New persistenciaCaso
        Return perListado.listarCasos()

    End Function

End Class
