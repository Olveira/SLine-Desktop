Public Class conexion
    Public Function abrirConexion() As Npgsql.NpgsqlConnection
        Dim conexionPg As Npgsql.NpgsqlConnection
        Try
            conexionPg = New Npgsql.NpgsqlConnection()

            Dim cadenaDeConexion As String

            'Cambiar conexión dependiendo del puerto que tenga cada quien la DB'

            cadenaDeConexion = "Server=localhost;Port=5433;User Id='postgres';Password='root';Database=sline"

            conexionPg.ConnectionString = cadenaDeConexion

            conexionPg.Open()

        Catch ex As Exception
            Throw ex
        End Try
        Return conexionPg
    End Function
End Class
