Public Class Conexion
    Public Function AbrirConexion() As Npgsql.NpgsqlConnection
        Dim conexionPg As Npgsql.NpgsqlConnection
        Try
            'Cambiar conexión dependiendo del puerto que tenga cada quien la DB'
            conexionPg = New Npgsql.NpgsqlConnection With {
                .ConnectionString = "Server=10.1.13.206;Port=5432;User Id='postgres';Password='root';Database=sline"
            }
            conexionPg.Open()
        Catch ex As Exception
            Throw ex
        End Try
        Return conexionPg
    End Function
End Class
