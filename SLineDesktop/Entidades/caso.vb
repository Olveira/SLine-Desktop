Public Class caso
    Private _idCaso As Integer
    Private _coordenadas As String
    Private _titulo As String
    Private _descripcion As String
    Private _idUsuario
    Private _valides As Boolean

    Public Property IdCaso As Integer
        Get
            Return _idCaso
        End Get
        Set(value As Integer)
            _idCaso = value
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

    Public Property Titulo As String
        Get
            Return _titulo
        End Get
        Set(value As String)
            _titulo = value
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

    Public Property idUsuario As Integer
        Get
            Return _idUsuario
        End Get
        Set(value As Integer)
            _titulo = value
        End Set
    End Property

    Public Property valides As Boolean
        Get
            Return _valides
        End Get
        Set(value As Boolean)
            _idCaso = value
        End Set
    End Property

    Public Sub New(idCaso As Integer, coordenadas As String, titulo As String, descripcion As String, idUsuario As Integer, valides As Boolean)
        _idCaso = idCaso
        _coordenadas = coordenadas
        _titulo = titulo
        _descripcion = descripcion
        _idUsuario = idUsuario
        _valides = valides
    End Sub

    Public Sub New()

    End Sub
End Class
