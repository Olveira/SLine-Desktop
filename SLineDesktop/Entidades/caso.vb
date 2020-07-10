Public Class caso
    Private _nombre As String
    Private _id As Integer
    Private _descripcion As String
    Private _coordenadas As String


    Public Property Nombre As String
        Get
            Return _nombre
        End Get
        Set(value As String)
            _nombre = value
        End Set
    End Property
    Public Property Id As Integer
        Get
            Return _id
        End Get
        Set(value As Integer)
            _id = value
        End Set
    End Property

    Public Property Descripcion As String
        Get
            Return _descripcion
        End Get
        Set(value As String)
            _descripcion = value
        End Set
    End Property

    Public Property Coordenadas As String
        Get
            Return _coordenadas
        End Get
        Set(value As String)
            _coordenadas = value
        End Set
    End Property

    Public Sub New(nombre As String, id As Integer, descripcion As String, coordenadas As String)
        _nombre = nombre
        _id = id
        _descripcion = descripcion
        _coordenadas = coordenadas
    End Sub

    Public Sub New()

    End Sub
End Class
