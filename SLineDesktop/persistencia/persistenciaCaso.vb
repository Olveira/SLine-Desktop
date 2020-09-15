Public Class persistenciaCaso
    Dim conection = New Npgsql.NpgsqlConnection

    'Inecesario'
    Public Sub AltaCaso(cases As caso)
        Try
            Dim clasCnn = New conexion
            Dim cadenaDeComandosCase As String
            Dim resultado As Integer

            cadenaDeComandosCase = "insert into cases(idCaso, coordenadas, titulo, descripcion, idUsuario) values (@idCaso, @coordenadas, @titulo, @descripcion, @idUsuario);"

            conection = clasCnn.abrirConexion()
            Dim cmd As New Npgsql.NpgsqlCommand(cadenaDeComandosCase)
            cmd.Connection = conection

            cmd.Parameters.Add("@idCaso", NpgsqlTypes.NpgsqlDbType.Integer).Value = cases.IdCaso
            cmd.Parameters.Add("@coordenadas", NpgsqlTypes.NpgsqlDbType.Varchar, 50).Value = cases.Coordenadas
            cmd.Parameters.Add("@titulo", NpgsqlTypes.NpgsqlDbType.Varchar, 50).Value = cases.Titulo
            cmd.Parameters.Add("@descripcion", NpgsqlTypes.NpgsqlDbType.Varchar, 200).Value = cases.Descripcion
            cmd.Parameters.Add("@idUsuario", NpgsqlTypes.NpgsqlDbType.Integer).Value = cases.idUsuario

            resultado = cmd.ExecuteNonQuery()

        Catch ex As Exception
            Throw ex
        Finally
            conection.close
        End Try
    End Sub

    'Public Function 
    '
    'if aceptar = guarda
    'Declionar = bprra
    'botones
    'listbiu
    '


    Dim scaso As New List(Of caso)
    Public Function listarCasos() As List(Of caso)
        Try
            Dim Caso As New caso
            Dim ConCaso As New conexion
            conection = ConCaso.abrirConexion
            Dim cmd = New Npgsql.NpgsqlCommand
            cmd.Connection = conection
            Dim cadenaDeComandos = "select * from cases "

            cmd.CommandText = cadenaDeComandos
            Dim Visor As Npgsql.NpgsqlDataReader = cmd.ExecuteReader

            While Visor.Read()
                Dim newCaso As New caso
                newCaso.IdCaso = Convert.ToInt32(Visor(8).ToString)
                newCaso.Coordenadas = Visor(1).ToString
                'Como separar latitud de longitud
                newCaso.Titulo = Visor(2).ToString
                newCaso.Descripcion = Visor(3).ToString
                newCaso.idUsuario = Convert.ToInt32(Visor(8).ToString)
                newCaso.IdCaso = Convert.ToInt32(Visor(8).ToString)
            End While

            If IsNothing(scaso) Then
            Else
                Return scaso
            End If
        Catch ex As Exception
            Throw ex
        Finally
            conection.close
        End Try
    End Function

End Class
