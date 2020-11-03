Public Class PersistenciaCaso
    Private conection = New Npgsql.NpgsqlConnection

    Public Sub AceptarCasos(LCasos As Integer)
        Try
            Dim clasCnn = New Conexion
            Dim cadenaDeComandos As String
            cadenaDeComandos = "UPDATE _case SET verificado = @verificado WHERE id_caso = @idCaso"

            conection = clasCnn.AbrirConexion()
            Dim cmd As New Npgsql.NpgsqlCommand(cadenaDeComandos)
            cmd.Connection = conection
            cmd.Parameters.Add("@idCaso", NpgsqlTypes.NpgsqlDbType.Integer).Value = LCasos
            cmd.Parameters.Add("@verificado", NpgsqlTypes.NpgsqlDbType.Boolean, 10).Value = True

            cmd.ExecuteNonQuery()
        Catch ex As Exception
            Throw ex
        Finally
            conection.close
        End Try
    End Sub
    Public Function ListarCasos() As List(Of caso)
        Dim listcasos As New List(Of caso)
        Try
            Dim Persona As New caso
            Dim ClaseSnl As New Conexion
            conection = ClaseSnl.AbrirConexion
            Dim cmd = New Npgsql.NpgsqlCommand
            cmd.Connection = conection

            Dim cadenaDeComandos = "SELECT * FROM _case"

            cmd.CommandText = cadenaDeComandos
            Dim Lector As Npgsql.NpgsqlDataReader = cmd.ExecuteReader
            While Lector.Read()
                Dim newCaso As New caso With {
                    .IdCaso = Convert.ToInt32(Lector(0).ToString),
                    .Descripcion = Lector(4).ToString,
                    .IdUsuario = Convert.ToInt32(Lector(5).ToString),
                    .Verificado = Convert.ToBoolean(Lector(6).ToString),
                    .Fecharegistro = Convert.ToDateTime(Lector(7).ToString)
                }
                listcasos.Add(newCaso)
            End While
        Catch ex As Exception
            Throw ex
        Finally
            conection.close
        End Try
        Return listcasos
    End Function
    Public Sub EliminarCaso(idCaso As Integer)
        Try
            Dim clasCnn = New Conexion
            Dim cadenaDeComandos As String
            Dim eliminador As Integer

            cadenaDeComandos = "DELETE FROM _case WHERE id_caso = @idCaso"

            conection = clasCnn.AbrirConexion()
            Dim cmd As New Npgsql.NpgsqlCommand(cadenaDeComandos)
            cmd.Connection = conection

            cmd.Parameters.Add("@idCaso", NpgsqlTypes.NpgsqlDbType.Integer).Value = idCaso
            eliminador = cmd.ExecuteNonQuery()

        Catch ex As Exception
            Throw ex
        Finally
            conection.close
        End Try
    End Sub
End Class
