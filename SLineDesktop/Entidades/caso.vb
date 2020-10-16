Public Class caso
    Private _idCaso As Integer
    Private _descripcion As String
    Private _idUsuario As Integer
    Private _verificado As Boolean
    Private _fecharegistro As Date

    Public Property IdCaso As Integer
        Get
            Return _idCaso
        End Get
        Set(value As Integer)
            _idCaso = value
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
    Public Property IdUsuario As Integer
        Get
            Return _idUsuario
        End Get
        Set(value As Integer)
            _idUsuario = value
        End Set
    End Property
    Public Property Verificado As Boolean
        Get
            Return _verificado
        End Get
        Set(value As Boolean)
            _verificado = value
        End Set
    End Property
    Public Property Fecharegistro As Date
        Get
            Return _fecharegistro
        End Get
        Set(value As Date)
            _fecharegistro = value
        End Set
    End Property
    Public Sub New(idCaso As Integer, descripcion As String, idUsuario As Integer, verificado As Boolean, fechaRegistro As Date)
        _idCaso = idCaso
        _descripcion = descripcion
        _idUsuario = idUsuario
        _verificado = verificado
        _fecharegistro = fechaRegistro
    End Sub
    'inicializacion vacia'
    Public Sub New()

    End Sub
End Class
