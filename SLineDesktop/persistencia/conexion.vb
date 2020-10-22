Public Class conexion
    Public Function abrirConexion() As Npgsql.NpgsqlConnection
        Dim conexionPg As Npgsql.NpgsqlConnection
        Try
            conexionPg = New Npgsql.NpgsqlConnection()

            'Cambiar conexión dependiendo del puerto que tenga cada quien la DB'

            conexionPg.ConnectionString = "Server=localhost;Port=5432;User Id='postgres';Password='root';Database=sline"

            conexionPg.Open()

        Catch ex As Exception
            Throw ex
        End Try
        Return conexionPg
    End Function
End Class
