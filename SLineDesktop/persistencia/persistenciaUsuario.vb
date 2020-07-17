Public Class persistenciaUsuario
    Dim conection = New Npgsql.NpgsqlConnection
    Public Sub AltaUsuario(users As usuario)
        Try
            Dim clasCnn = New conexion
            conection = clasCnn.abrirConexion()
            Dim cmd As New Npgsql.NpgsqlCommand

            cmd.Connection = conection
            Dim cadenaDeComandos As String
            cadenaDeComandos = "insert into users(username,email,password,sexo,fechanac,rol,token) values (@username,@email,@password,@sexo,@fechanac,@rol,@token);"

            cmd.Parameters.Add("@username", NpgsqlTypes.NpgsqlDbType.Varchar, 50).Value = users.Username
            cmd.Parameters.Add("@email", NpgsqlTypes.NpgsqlDbType.Varchar, 70).Value = users.Email
            cmd.Parameters.Add("@password", NpgsqlTypes.NpgsqlDbType.Varchar, 50).Value = users.Password
            cmd.Parameters.Add("@sexo", NpgsqlTypes.NpgsqlDbType.Varchar, 10).Value = users.Sexo
            cmd.Parameters.Add("@fechanac", NpgsqlTypes.NpgsqlDbType.Date).Value = CDate("23/10/2002")
            cmd.Parameters.Add("@rol", NpgsqlTypes.NpgsqlDbType.Varchar, 15).Value = users.Rol
            cmd.Parameters.Add("@token", NpgsqlTypes.NpgsqlDbType.Integer).Value = users.Token



            cmd.ExecuteNonQuery()
        Catch ex As Exception
            Throw ex
        Finally
            conection.close
        End Try

    End Sub
End Class
