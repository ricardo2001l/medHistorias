Public Class Fgeneral
    Inherits conexion

    Public EXEerror As Boolean
    Dim dt As New DataTable

    Public Function existe(ByVal campo As String, ByVal tabla As String, ByVal valor As String, Optional ByVal isString As Boolean = True, Optional ByVal isFecha As Boolean = False) As Boolean
        Dim yaExiste As Boolean
        yaExiste = False

        conectar()
        cmd.Connection = conn
        cmd.CommandType = CommandType.Text
        If isString Then
            sql = "SELECT " & campo & " FROM " & tabla & " WHERE " & campo & "='" & valor & "'"
        Else
            sql = "SELECT " & campo & " FROM " & tabla & " WHERE " & campo & "=" & valor & ""
        End If

        If isFecha Then
            sql = "SELECT " & campo & " FROM " & tabla & " WHERE " & campo & "=#" & valor & "#"
        End If

        cmd.CommandText = sql
        Try
            cmd.ExecuteNonQuery()
            Using dt As New DataTable
                Using da As New OleDb.OleDbDataAdapter(cmd)
                    da.Fill(dt)
                    If dt.Rows.Count > 0 Then
                        yaExiste = True
                    Else
                        yaExiste = False
                    End If
                    desconectar()
                End Using
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
        Return yaExiste
    End Function

    Public Function consultarId(ByVal id As String, ByVal tabla As String, Optional ByVal repeat As Boolean = True) As DataTable
        conectar()
        cmd.Connection = conn
        cmd.CommandType = CommandType.Text
        If repeat Then
            sql = "SELECT " & id & " FROM " & tabla & ";"
        Else
            sql = "SELECT DISTINCT " & id & " FROM " & tabla & ";"
        End If
        cmd.CommandText = sql
        Try
            cmd.ExecuteNonQuery()
            Using dt As New DataTable
                Using da As New OleDb.OleDbDataAdapter(cmd)
                    da.Fill(dt)
                    Return dt
                End Using
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function

    Public Function consultarRegistro(ByVal campo As String, ByVal valorCampo As String, ByVal tabla As String, ByVal isString As Boolean) As DataTable
        conectar()
        cmd.Connection = conn
        cmd.CommandType = CommandType.Text
        If isString Then
            sql = "SELECT * FROM " & tabla & " WHERE " & campo & "='" & valorCampo & "'"
        Else
            sql = "SELECT * FROM " & tabla & " WHERE " & campo & "=" & valorCampo & ""
        End If
        cmd.CommandText = sql
        Try
            cmd.ExecuteNonQuery()
            Using dt As New DataTable
                Using da As New OleDb.OleDbDataAdapter(cmd)
                    da.Fill(dt)
                    desconectar()
                    Return dt
                End Using
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function
    Public Function consultarRegistro(ByVal campo As String, ByVal campo2 As String, ByVal valor As String, ByVal valor2 As String, ByVal tabla As String, ByVal isString As Boolean) As DataTable
        conectar()
        cmd.Connection = conn
        cmd.CommandType = CommandType.Text
        If isString Then
            sql = "SELECT * FROM " & tabla & " WHERE " & campo & "='" & valor & "' AND " & campo2 & "=#" & valor2 & "#"
        Else
            sql = "SELECT * FROM " & tabla & " WHERE " & campo & "=" & valor & " AND " & campo2 & "=#" & valor2 & "#"
        End If

        cmd.CommandText = sql

        Try
            cmd.ExecuteNonQuery()
            Using dt As New DataTable
                Using da As New OleDb.OleDbDataAdapter(cmd)
                    da.Fill(dt)
                    desconectar()
                    Return dt
                End Using
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function

    Public Function consultar(ByVal tabla As String) As DataTable
        conectar()
        cmd.Connection = conn
        cmd.CommandType = CommandType.Text

        sql = "SELECT * FROM " & tabla

        cmd.CommandText = sql

        Try
            cmd.ExecuteNonQuery()
            Using dt As New DataTable
                Using da As New OleDb.OleDbDataAdapter(cmd)
                    da.Fill(dt)
                    desconectar()
                    Return dt
                End Using
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function

    Public Function consultar(ByVal tabla As String, ByVal conNombrePaciente As Boolean) As DataTable
        conectar()
        cmd.Connection = conn
        cmd.CommandType = CommandType.Text

        sql = "SELECT CodHistoriaMedica, HistoriaMedica.CedulaPaciente AS CedulaPaciente, Paciente.Nombre AS Nombre, Paciente.Apellido AS Apellido, Antecedentes, AntecedentesFamiliares FROM (" & tabla & " LEFT JOIN Paciente ON HistoriaMedica.CedulaPaciente=Paciente.CedulaPaciente)"

        cmd.CommandText = sql

        Try
            cmd.ExecuteNonQuery()
            Using dt As New DataTable
                Using da As New OleDb.OleDbDataAdapter(cmd)
                    da.Fill(dt)
                    desconectar()
                    Return dt
                End Using
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function

    Public Function infHistoriaMedicaTodos() As DataTable
        conectar()
        cmd.Connection = conn
        cmd.CommandType = CommandType.Text

        sql = "SELECT CodHistoriaMedica, HistoriaMedica.CedulaPaciente, Paciente.CedulaPaciente, Nombre, Apellido, Telefono, FechaDeNacimiento, Sexo, Residencia, Antecedentes, AntecedentesFamiliares, Tratamientos "
        sql += "FROM (HistoriaMedica LEFT JOIN Paciente ON HistoriaMedica.CedulaPaciente=Paciente.CedulaPaciente);"

        cmd.CommandText = sql

        Try
            cmd.ExecuteNonQuery()
            Using dt As New DataTable
                Using da As New OleDb.OleDbDataAdapter(cmd)
                    da.Fill(dt)
                    desconectar()
                    Return dt
                End Using
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function

    Public Function infHistoriaMedicaUna(ByVal cedulaPaciente As String) As DataTable
        conectar()
        cmd.Connection = conn
        cmd.CommandType = CommandType.Text

        sql = "SELECT CodHistoriaMedica, HistoriaMedica.CedulaPaciente, Paciente.CedulaPaciente, Nombre, Apellido, Telefono, FechaDeNacimiento, Sexo, Residencia, Antecedentes, AntecedentesFamiliares, Tratamientos "
        sql += "FROM (HistoriaMedica LEFT JOIN Paciente ON HistoriaMedica.CedulaPaciente=Paciente.CedulaPaciente) WHERE HistoriaMedica.CedulaPaciente='" & cedulaPaciente & "';"

        cmd.CommandText = sql

        Try
            cmd.ExecuteNonQuery()
            Using dt As New DataTable
                Using da As New OleDb.OleDbDataAdapter(cmd)
                    da.Fill(dt)
                    desconectar()
                    Return dt
                End Using
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function

    Public Function infMedicoTodos() As DataTable
        conectar()
        cmd.Connection = conn
        cmd.CommandType = CommandType.Text

        sql = "SELECT * "
        sql += "FROM Medico;"

        cmd.CommandText = sql

        Try
            cmd.ExecuteNonQuery()
            Using dt As New DataTable
                Using da As New OleDb.OleDbDataAdapter(cmd)
                    da.Fill(dt)
                    desconectar()
                    Return dt
                End Using
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function

    Public Function infMedicoUno(ByVal cedulaMedico As String) As DataTable
        conectar()
        cmd.Connection = conn
        cmd.CommandType = CommandType.Text

        sql = "SELECT * "
        sql += "FROM Medico WHERE CedulaMedico='" & cedulaMedico & "';"

        cmd.CommandText = sql

        Try
            cmd.ExecuteNonQuery()
            Using dt As New DataTable
                Using da As New OleDb.OleDbDataAdapter(cmd)
                    da.Fill(dt)
                    desconectar()
                    Return dt
                End Using
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function
    Public Function infPacienteTodos() As DataTable
        conectar()
        cmd.Connection = conn
        cmd.CommandType = CommandType.Text

        sql = "SELECT * "
        sql += "FROM Paciente;"

        cmd.CommandText = sql

        Try
            cmd.ExecuteNonQuery()
            Using dt As New DataTable
                Using da As New OleDb.OleDbDataAdapter(cmd)
                    da.Fill(dt)
                    desconectar()
                    Return dt
                End Using
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function

    Public Function infPacienteUno(ByVal cedulaPaciente As String) As DataTable
        conectar()
        cmd.Connection = conn
        cmd.CommandType = CommandType.Text

        sql = "SELECT * "
        sql += "FROM Paciente WHERE CedulaPaciente='" & cedulaPaciente & "';"

        cmd.CommandText = sql

        Try
            cmd.ExecuteNonQuery()
            Using dt As New DataTable
                Using da As New OleDb.OleDbDataAdapter(cmd)
                    da.Fill(dt)
                    desconectar()
                    Return dt
                End Using
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function
    Public Function infConsultaMedicaTodos() As DataTable
        conectar()
        cmd.Connection = conn
        cmd.CommandType = CommandType.Text

        sql = "SELECT * FROM Consulta"

        cmd.CommandText = sql

        Try
            cmd.ExecuteNonQuery()
            Using dt As New DataTable
                Using da As New OleDb.OleDbDataAdapter(cmd)
                    da.Fill(dt)
                    desconectar()
                    Return dt
                End Using
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function
    Public Function infConsultaMedicaUna(ByVal codConsultaMedica As String) As DataTable
        conectar()
        cmd.Connection = conn
        cmd.CommandType = CommandType.Text

        sql = "SELECT * FROM Consulta WHERE CodConsulta='" & codConsultaMedica & "';"

        cmd.CommandText = sql

        Try
            cmd.ExecuteNonQuery()
            Using dt As New DataTable
                Using da As New OleDb.OleDbDataAdapter(cmd)
                    da.Fill(dt)
                    desconectar()
                    Return dt
                End Using
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function

    Public Function infConsultaMedicaFechas(ByVal fechaInicial As String, ByVal fechaFinal As String) As DataTable
        conectar()
        cmd.Connection = conn
        cmd.CommandType = CommandType.Text

        sql = "SELECT * FROM Consulta WHERE Fecha >= #" & fechaInicial & "# AND Fecha <= #" & fechaFinal & "#;"
        MsgBox(sql)
        cmd.CommandText = sql

        Try
            cmd.ExecuteNonQuery()
            Using dt As New DataTable
                Using da As New OleDb.OleDbDataAdapter(cmd)
                    da.Fill(dt)
                    desconectar()
                    Return dt
                End Using
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function

    Public Function infConsultaMedicaMedico(ByVal cedulaMedico As String) As DataTable
        conectar()
        cmd.Connection = conn
        cmd.CommandType = CommandType.Text

        sql = "SELECT * FROM Consulta WHERE CedulaMedico='" & cedulaMedico & "';"

        cmd.CommandText = sql

        Try
            cmd.ExecuteNonQuery()
            Using dt As New DataTable
                Using da As New OleDb.OleDbDataAdapter(cmd)
                    da.Fill(dt)
                    desconectar()
                    Return dt
                End Using
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function
    Public Function infConsultaMedicaPaciente(ByVal cedulaPaciente As String) As DataTable
        conectar()
        cmd.Connection = conn
        cmd.CommandType = CommandType.Text

        sql = "SELECT * FROM Consulta WHERE CedulaPaciente='" & cedulaPaciente & "';"

        cmd.CommandText = sql

        Try
            cmd.ExecuteNonQuery()
            Using dt As New DataTable
                Using da As New OleDb.OleDbDataAdapter(cmd)
                    da.Fill(dt)
                    desconectar()
                    Return dt
                End Using
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function
End Class
