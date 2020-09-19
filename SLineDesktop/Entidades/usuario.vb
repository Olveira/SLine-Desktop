Public Class usuario
    Private _username As String
    Private _email As String
    Private _password As String
    Private _sexo As String
    Private _fechaNac As Date
    Private _rol As String
    Private _id As Integer

    Public Property Username As String
        Get
            Return _username
        End Get
        Set(value As String)
            _username = value
        End Set
    End Property
    Public Property Email As String
        Get
            Return _email
        End Get
        Set(value As String)
            _email = value
        End Set
    End Property
    Public Property Password As String
        Get
            Return _password
        End Get
        Set(value As String)
            _password = value
        End Set
    End Property
    Public Property Sexo As String
        Get
            Return _sexo
        End Get
        Set(value As String)
            _sexo = value
        End Set
    End Property
    Public Property FechaNac As Date
        Get
            Return _fechaNac
        End Get
        Set(value As Date)
            _fechaNac = value
        End Set
    End Property
    Public Property Rol As String
        Get
            Return _rol
        End Get
        Set(value As String)
            _rol = value
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

    Public Sub New(username As String, email As String, password As String, sexo As String, fechaNac As Date, rol As String)
        _username = username
        _email = email
        _password = password
        _sexo = sexo
        _fechaNac = fechaNac
        _rol = rol
    End Sub
    Public Sub New()

    End Sub
End Class
