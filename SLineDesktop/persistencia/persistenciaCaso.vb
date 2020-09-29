Public Class persistenciaCaso
    Dim conection = New Npgsql.NpgsqlConnection

    Public Function aceptarCasos(idCaso As Integer) As List(Of caso)
        Try
            Dim clasCnn = New conexion
            Dim cadenaDeComandos As String
            Dim AcepCaso As Integer

            cadenaDeComandos = "UPDATE CASES SET verificado = @verificado WHERE idCaso = @idCaso"

            conection = clasCnn.abrirConexion()
            Dim cmd As New Npgsql.NpgsqlCommand(cadenaDeComandos)

            cmd.Connection = conection

            cmd.Parameters.Add("@idCaso", NpgsqlTypes.NpgsqlDbType.Integer).Value = idCaso
            cmd.Parameters.Add("@verificado", NpgsqlTypes.NpgsqlDbType.Boolean).Value = True
            AcepCaso = cmd.ExecuteNonQuery()

        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Dim listcasos As New List(Of caso)
    Public Function listarCasos() As List(Of caso)
        Try
            Dim Persona As New caso
            Dim ClaseSnl As New conexion
            conection = ClaseSnl.abrirConexion
            Dim cmd = New Npgsql.NpgsqlCommand
            cmd.Connection = conection

            Dim cadenaDeComandos = "SELECT * FROM CASES"

            cmd.CommandText = cadenaDeComandos
            Dim Lector As Npgsql.NpgsqlDataReader = cmd.ExecuteReader

            While Lector.Read()
                Dim newCaso As New caso
                newCaso.IdCaso = Convert.ToInt32(Lector(0).ToString)
                newCaso.Descripcion = Lector(2).ToString
                newCaso.IdUsuario = Convert.ToInt32(Lector(3).ToString)
                newCaso.Verificado = Convert.ToBoolean(Lector(4).ToString)
                newCaso.Fecharegistro = Convert.ToDateTime(Lector(5).ToString)

                listcasos.Add(newCaso)
            End While
        Catch ex As Exception
            Throw ex
        Finally
            conection.close
        End Try
        Return listcasos
    End Function


    Public Sub eliminarCaso(idCaso As Integer)
        Try
            Dim clasCnn = New conexion
            Dim cadenaDeComandos As String
            Dim eliminador As Integer

            cadenaDeComandos = "DELETE FROM CASES WHERE idCaso = @idCaso"

            conection = clasCnn.abrirConexion()
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
