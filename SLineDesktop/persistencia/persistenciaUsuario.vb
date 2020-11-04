Public Class PersistenciaUsuario
    Private conection = New Npgsql.NpgsqlConnection
    Public Sub AltaUsuario(user As usuario)
        Try
            conection = New Conexion().AbrirConexion()
            Dim cmd = New Npgsql.NpgsqlCommand("insert into _user(username,email,password,sexo,fecha_nacimiento,rol) values (@username,@email,@password,@sexo,@fechanac,@rol);") With {
                .Connection = conection
            }
            cmd.Parameters.Add("@username", NpgsqlTypes.NpgsqlDbType.Varchar, 50).Value = user.Username
            cmd.Parameters.Add("@email", NpgsqlTypes.NpgsqlDbType.Varchar, 70).Value = user.Email
            Dim contraseña As String = BCrypt.Net.BCrypt.HashPassword(user.Password, workFactor:=10)
            cmd.Parameters.Add("@password", NpgsqlTypes.NpgsqlDbType.Varchar, 60).Value = contraseña
            cmd.Parameters.Add("@sexo", NpgsqlTypes.NpgsqlDbType.Varchar, 10).Value = user.Sexo
            cmd.Parameters.Add("@fechanac", NpgsqlTypes.NpgsqlDbType.Date).Value = user.FechaNac
            cmd.Parameters.Add("@rol", NpgsqlTypes.NpgsqlDbType.Varchar, 15).Value = user.Rol
            Dim resultado = cmd.ExecuteNonQuery()
        Catch ex As Exception
            Throw ex
        Finally
            conection.close
        End Try
    End Sub
    Public Function PersistenciaLog(user As String, pass As String) As Boolean
        Try
            conection = New Conexion().AbrirConexion()
            Dim cmd As New Npgsql.NpgsqlCommand("select * from _user where username=@username and rol='Admin';") With {
                .Connection = conection
            }
            cmd.Parameters.AddWithValue("@username", user)
            Dim reader = cmd.ExecuteReader
            Dim password As String
            If reader.Read Then
                password = reader(2).ToString.Trim
                Return BCrypt.Net.BCrypt.Verify(pass, password)
            Else
                Return False
            End If
        Catch ex As Exception
            Throw ex
        Finally
            conection.close
        End Try
    End Function
    Public Function ListarPersonas() As List(Of usuario)
        Dim xss As New List(Of usuario)
        Try
            conection = New Conexion().AbrirConexion
            Dim cmd = New Npgsql.NpgsqlCommand("select * from _user") With {
                .Connection = conection
            }
            Dim Lector As Npgsql.NpgsqlDataReader = cmd.ExecuteReader
            While Lector.Read()
                Dim newPersona = New usuario With {
                    .Username = Lector(0).ToString,
                    .Email = Lector(1).ToString,
                    .Password = Lector(2).ToString,
                    .Sexo = Lector(3).ToString,
                    .FechaNac = Lector(5).ToString,
                    .Id = Convert.ToInt32(Lector(6).ToString),
                    .Rol = Lector(7).ToString
                }
                xss.Add(newPersona)
            End While
        Catch ex As Exception
            Throw ex
        Finally
            conection.close
        End Try

        Return xss
    End Function
    Public Sub ModificarPersona(user As usuario)
        Try
            conection = New Conexion().AbrirConexion()
            Dim cmd As New Npgsql.NpgsqlCommand("update _user set username = @username, email = @email, password = @password, sexo = @sexo, fecha_nacimiento = @fechanac, rol = @rol where id = @id") With {
                .Connection = conection
            }
            cmd.Parameters.Add("@username", NpgsqlTypes.NpgsqlDbType.Varchar, 50).Value = user.Username
            cmd.Parameters.Add("@email", NpgsqlTypes.NpgsqlDbType.Varchar, 70).Value = user.Email
            Dim contraseña As String = BCrypt.Net.BCrypt.HashPassword(user.Password, workFactor:=10)
            cmd.Parameters.Add("@password", NpgsqlTypes.NpgsqlDbType.Varchar, 60).Value = contraseña
            cmd.Parameters.Add("@sexo", NpgsqlTypes.NpgsqlDbType.Varchar, 10).Value = user.Sexo
            cmd.Parameters.Add("@fechanac", NpgsqlTypes.NpgsqlDbType.Date).Value = user.FechaNac
            cmd.Parameters.Add("@rol", NpgsqlTypes.NpgsqlDbType.Varchar, 15).Value = user.Rol
            cmd.Parameters.Add("@id", NpgsqlTypes.NpgsqlDbType.Integer).Value = user.Id
            Dim resultado = cmd.ExecuteNonQuery()
        Catch ex As Exception
            Throw ex
        Finally
            conection.close
        End Try
    End Sub
    Public Sub EliminarUsuario(id As Integer)
        Try
            conection = New Conexion().AbrirConexion()
            Dim cmd As New Npgsql.NpgsqlCommand("delete from _user where id = @id") With {
                .Connection = conection
            }
            cmd.Parameters.Add("@id", NpgsqlTypes.NpgsqlDbType.Integer).Value = id
            Dim resultado = cmd.ExecuteNonQuery()
        Catch ex As Exception
            Throw ex
        Finally
            conection.close
        End Try
    End Sub
    Public Function BuscarPorUserEmail(UnEm As String, Selector As Boolean)
        Dim Usuario As New usuario
        If Selector Then
            Try
                conection = New Conexion().AbrirConexion()
                Dim cmd = New Npgsql.NpgsqlCommand("select * from _user where username = @username") With {
                    .Connection = conection
                }
                cmd.Parameters.Add("@username", NpgsqlTypes.NpgsqlDbType.Varchar, 50).Value = UnEm
                Dim Lector = cmd.ExecuteReader
                If Lector.Read() Then
                    Usuario = New usuario With {
                    .Username = Lector(0).ToString,
                    .Email = Lector(1).ToString,
                    .Password = Lector(2).ToString,
                    .Sexo = Lector(3).ToString,
                    .FechaNac = Lector(5).ToString,
                    .Id = Convert.ToInt32(Lector(6).ToString),
                    .Rol = Lector(7).ToString
                }
                End If
                Return Usuario
            Catch ex As Exception
                Throw ex
            Finally
                conection.close
            End Try
        Else
            Try
                conection = New Conexion().AbrirConexion()
                Dim cmd = New Npgsql.NpgsqlCommand("select * from _user where email = @email") With {
                    .Connection = conection
                }
                cmd.Parameters.Add("@email", NpgsqlTypes.NpgsqlDbType.Varchar, 70).Value = UnEm
                Dim Lector = cmd.ExecuteReader
                If Lector.Read() Then
                    Usuario = New usuario With {
                    .Username = Lector(0).ToString,
                    .Email = Lector(1).ToString,
                    .Password = Lector(2).ToString,
                    .Sexo = Lector(3).ToString,
                    .FechaNac = Lector(5).ToString,
                    .Id = Convert.ToInt32(Lector(6).ToString),
                    .Rol = Lector(7).ToString
                }
                End If
                Return Usuario
            Catch ex As Exception
                Throw ex
            Finally
                conection.close
            End Try
        End If
    End Function
End Class
