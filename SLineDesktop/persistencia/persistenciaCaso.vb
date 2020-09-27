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
        Try
            Dim ConCaso As New conexion
            conection = ConCaso.abrirConexion
            Dim cmd = New Npgsql.NpgsqlCommand
            cmd.Connection = conection
            Dim cadenaDeComandos = "SELECT * FROM CASES "

            cmd.CommandText = cadenaDeComandos
            Dim Visor As Npgsql.NpgsqlDataReader = cmd.ExecuteReader

            While Visor.Read()
                Dim newCaso As New caso
                newCaso.IdCaso = Convert.ToInt32(Visor(0).ToString)
                'newCaso.Coordenadas = Convert.ToInt32(Visor(1).ToString)
                newCaso.Descripcion = Visor(2).ToString
                newCaso.IdUsuario = Convert.ToInt32(Visor(3).ToString)
                'newCaso.Verificado = Visor(4).ToString
                newCaso.Fecharegistro = Visor(5).ToString
                scaso.Add(newCaso)
            End While
        Catch ex As Exception
            Throw ex
        Finally
            conection.close
        End Try
        Return scaso
    End Function

End Class
