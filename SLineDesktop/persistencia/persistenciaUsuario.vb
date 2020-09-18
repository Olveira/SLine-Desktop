Public Class persistenciaUsuario
    Dim conection = New Npgsql.NpgsqlConnection

    Public Sub AltaUsuario(users As usuario)
        Try
            Dim clasCnn = New conexion
            Dim cadenaDeComandos As String

            Dim resultado As Integer

            cadenaDeComandos = "insert into users(username,email,password,sexo,fechanac,rol) values (@username,@email,@password,@sexo,@fechanac,@rol);"

            conection = clasCnn.abrirConexion()
            Dim cmd As New Npgsql.NpgsqlCommand(cadenaDeComandos)


            cmd.Connection = conection


            cmd.Parameters.Add("@username", NpgsqlTypes.NpgsqlDbType.Varchar, 50).Value = users.Username
            cmd.Parameters.Add("@email", NpgsqlTypes.NpgsqlDbType.Varchar, 70).Value = users.Email
            cmd.Parameters.Add("@password", NpgsqlTypes.NpgsqlDbType.Varchar, 50).Value = users.Password
            cmd.Parameters.Add("@sexo", NpgsqlTypes.NpgsqlDbType.Varchar, 10).Value = users.Sexo
            cmd.Parameters.Add("@fechanac", NpgsqlTypes.NpgsqlDbType.Date).Value = users.FechaNac
            cmd.Parameters.Add("@rol", NpgsqlTypes.NpgsqlDbType.Varchar, 15).Value = users.Rol

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

            cadenaDeComandos = "select * from users where username=@username and password=@password and rol=@rol;"

            conection = clasCnn.abrirConexion()
            Dim cmd As New Npgsql.NpgsqlCommand(cadenaDeComandos)


            cmd.Connection = conection

            cmd.Parameters.AddWithValue("@username", user)
            cmd.Parameters.AddWithValue("@password", pass)
            cmd.Parameters.AddWithValue("@rol", "admin")

            reader = cmd.ExecuteReader
            Dim variable As Boolean
            variable = reader.hasRows()

            Return variable

        Catch ex As Exception
            Throw ex
        Finally
            conection.close
        End Try
    End Function

    Public Function listarPersonas() As List(Of usuario)
        Dim xss As New List(Of usuario)
        Try
            Dim Persona As New usuario
            Dim ClaseSnl As New conexion
            conection = ClaseSnl.abrirConexion
            Dim cmd = New Npgsql.NpgsqlCommand
            cmd.Connection = conection

            Dim cadenaDeComandos = "select * from users "

            cmd.CommandText = cadenaDeComandos
            Dim Lector As Npgsql.NpgsqlDataReader = cmd.ExecuteReader

            While Lector.Read()
                Dim newPersona As New usuario
                newPersona.Username = Lector(0).ToString
                newPersona.Email = Lector(1).ToString
                newPersona.Password = Lector(2).ToString
                newPersona.Sexo = Lector(3).ToString
                newPersona.FechaNac = Lector(5).ToString
                newPersona.Rol = Lector(6).ToString
                newPersona.Id = Convert.ToInt32(Lector(7).ToString)
                xss.Add(newPersona)
            End While

            If IsNothing(xss) Then
            Else

            End If
        Catch ex As Exception
            Throw ex
        Finally
            conection.close
        End Try
        Return xss
    End Function
    Public Sub modificarPersona(user As usuario)
        Try
            Dim clasCnn = New conexion
            Dim cadenaDeComandos As String

            Dim resultado As Integer

            cadenaDeComandos = "update users set username = @username, email = @email, password = @password, sexo = @sexo, fechanac = @fechanac, rol = @rol where id = @id"

            conection = clasCnn.abrirConexion()
            Dim cmd As New Npgsql.NpgsqlCommand(cadenaDeComandos)


            cmd.Connection = conection


            cmd.Parameters.Add("@username", NpgsqlTypes.NpgsqlDbType.Varchar, 50).Value = user.Username
            cmd.Parameters.Add("@email", NpgsqlTypes.NpgsqlDbType.Varchar, 70).Value = user.Email
            cmd.Parameters.Add("@password", NpgsqlTypes.NpgsqlDbType.Varchar, 50).Value = user.Password
            cmd.Parameters.Add("@sexo", NpgsqlTypes.NpgsqlDbType.Varchar, 10).Value = user.Sexo
            cmd.Parameters.Add("@fechanac", NpgsqlTypes.NpgsqlDbType.Date).Value = user.FechaNac
            cmd.Parameters.Add("@rol", NpgsqlTypes.NpgsqlDbType.Varchar, 15).Value = user.Rol
            cmd.Parameters.Add("@id", NpgsqlTypes.NpgsqlDbType.Integer).Value = user.Id

            resultado = cmd.ExecuteNonQuery()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Public Sub eliminarUsuario(id As Integer)
        Try
            Dim clasCnn = New conexion
            Dim cadenaDeComandos As String

            Dim resultado As Integer

            cadenaDeComandos = "delete from users where id = @id"

            conection = clasCnn.abrirConexion()
            Dim cmd As New Npgsql.NpgsqlCommand(cadenaDeComandos)


            cmd.Connection = conection


            cmd.Parameters.Add("@id", NpgsqlTypes.NpgsqlDbType.Integer).Value = id

            resultado = cmd.ExecuteNonQuery()

        Catch ex As Exception
            Throw ex
        Finally
            conection.close
        End Try
    End Sub
End Class
