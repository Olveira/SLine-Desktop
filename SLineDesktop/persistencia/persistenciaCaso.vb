Public Class persistenciaCaso
    Dim conection = New Npgsql.NpgsqlConnection


    Public Function aceptarCasos(idCaso As Integer) As List(Of caso)
        Try
            Dim cadenadecomandosModificar = "UPDATE CASES SET verificado = TRUE WHERE idcaso = @idCaso;"
            Dim clasCnn = New conexion
            clasCnn = conection
            Dim cmd As New Npgsql.NpgsqlCommand(cadenadecomandosModificar)
            cmd.Connection = conection

            Dim verificado As Integer
            cmd.Parameters.Add("@idCaso", NpgsqlTypes.NpgsqlDbType.Integer).Value = idCaso
            verificado = cmd.ExecuteNonQuery()

        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Dim scaso As New List(Of caso)
    Public Function listarCasos() As List(Of caso)
        Dim xss As New List(Of caso)
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
                newCaso.IdCaso = Lector(0).ToString
                newCaso.Descripcion = Lector(1).ToString
                newCaso.IdUsuario = Lector(2).ToString

                xss.Add(newCaso)
            End While
        Catch ex As Exception
            Throw ex
        Finally
            conection.close
        End Try
        Return xss
    End Function

End Class
