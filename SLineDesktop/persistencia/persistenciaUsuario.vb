Public Class persistenciaUsuario
    Dim conection = New Npgsql.NpgsqlConnection
    Public Sub AltaUsuario(users As usuario)
        Try
            Dim clasCnn = New conexion
            Dim cadenaDeComandos As String

            Dim resultado As Integer

            cadenaDeComandos = "insert into users(username,email,password,sexo,fechanac,rol,token) values (@username,@email,@password,@sexo,@fechanac,@rol,@token);"

            conection = clasCnn.abrirConexion()
            Dim cmd As New Npgsql.NpgsqlCommand(cadenaDeComandos)


            cmd.Connection = conection


            cmd.Parameters.Add("@username", NpgsqlTypes.NpgsqlDbType.Varchar, 50).Value = users.Username
            cmd.Parameters.Add("@email", NpgsqlTypes.NpgsqlDbType.Varchar, 70).Value = users.Email
            cmd.Parameters.Add("@password", NpgsqlTypes.NpgsqlDbType.Varchar, 50).Value = users.Password
            cmd.Parameters.Add("@sexo", NpgsqlTypes.NpgsqlDbType.Varchar, 10).Value = users.Sexo
            cmd.Parameters.Add("@fechanac", NpgsqlTypes.NpgsqlDbType.Date).Value = users.FechaNac
            cmd.Parameters.Add("@rol", NpgsqlTypes.NpgsqlDbType.Varchar, 15).Value = users.Rol
            cmd.Parameters.Add("@token", NpgsqlTypes.NpgsqlDbType.Varchar, 100).Value = users.Token


            resultado = cmd.ExecuteNonQuery()

        Catch ex As Exception
            Throw ex
        Finally
            conection.close
        End Try

    End Sub
    Public Function persistenciaLog(user As String, pass As String) As Boolean
        Try
            Dim clasCnn = New conexion
            Dim cadenaDeComandos As String

            Dim reader

            cadenaDeComandos = "select * from users where username=@username and password=@password;"

            conection = clasCnn.abrirConexion()
            Dim cmd As New Npgsql.NpgsqlCommand(cadenaDeComandos)


            cmd.Connection = conection

            cmd.Parameters.AddWithValue("@username", user)
            cmd.Parameters.AddWithValue("@password", pass)



            reader = cmd.ExecuteReader()

            If reader.hasRows() Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            Throw ex
        Finally
            conection.close
        End Try

    End Function
End Class
