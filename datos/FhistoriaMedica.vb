Imports entidad

Public Class FhistoriaMedica
    Inherits Fgeneral



    Public Function agregar(ByVal codHistoriaMedica As String, ByVal cedulaPaciente As String, ByVal antecedentes As String, ByVal antecedentesFamiliares As String, ByVal tratamientos As String) As Boolean
        Dim yaExiste = existe("CodHistoriaMedica", "HistoriaMedica", codHistoriaMedica)

        If Not yaExiste Then
            conectar()

            cmd.Connection = conn
            cmd.CommandType = CommandType.Text

            sql = "INSERT INTO HistoriaMedica (CodHistoriaMedica, CedulaPaciente, Antecedentes, AntecedentesFamiliares, Tratamientos)"
            sql += "VALUES ('" & codHistoriaMedica & "','" & cedulaPaciente & "','" & antecedentes & "','" & antecedentesFamiliares & "','" & tratamientos & "');"
            cmd.CommandText = sql
            Try
                cmd.ExecuteNonQuery()
                EXEerror = False
            Catch ex As Exception
                MsgBox(ex.Message)
                EXEerror = True
            End Try
            desconectar()
        Else
            MsgBox("La cédula del paciente ingresada ya existe cómo historia médica, elija otro", MsgBoxStyle.Critical, "ERROR")
            EXEerror = True
        End If
        Return EXEerror
    End Function

    Public Function modificar(ByVal codHistoriaMedica As String, ByVal cedulaPaciente As String, ByVal antecedentes As String, ByVal antecedentesFamiliares As String, ByVal tratamientos As String) As Boolean


        Dim yaExiste = existe("CodHistoriaMedica", "HistoriaMedica", codHistoriaMedica)

        If yaExiste Then
            conectar()
            cmd.Connection = conn
            cmd.CommandType = CommandType.Text

            sql = "UPDATE HistoriaMedica "
            sql += "SET CedulaPaciente='" & cedulaPaciente & "', "
            sql += "Antecedentes='" & antecedentes & "', "
            sql += "AntecedentesFamiliares='" & antecedentesFamiliares & "', "
            sql += "Tratamientos='" & tratamientos & "' "
            sql += "WHERE CodHistoriaMedica='" & codHistoriaMedica & "';"
            cmd.CommandText = sql

            Try
                cmd.ExecuteNonQuery()
                EXEerror = False
            Catch ex As Exception
                MsgBox(ex.Message)
                EXEerror = True
            End Try
            desconectar()
        Else
            MsgBox("La cédula de paciente ingresada no existe cómo historia médica", MsgBoxStyle.Information, "La historia médica no existe")
            EXEerror = True
        End If
        Return EXEerror
    End Function
    Public Function eliminar(ByVal codHistoriaMedica As String) As Boolean
        Dim yaExiste = existe("CodHistoriaMedica", "HistoriaMedica", codHistoriaMedica)

        If yaExiste Then
            conectar()

            cmd.Connection = conn
            cmd.CommandType = CommandType.Text

            sql = "DELETE FROM HistoriaMedica WHERE CodHistoriaMedica='" & codHistoriaMedica & "'"
            cmd.CommandText = sql
            Try
                cmd.ExecuteNonQuery()
                EXEerror = False
            Catch ex As Exception
                MsgBox(ex.Message)
                EXEerror = True
            End Try
            desconectar()
        Else
            MsgBox("La cédula de paciente ingresada ingresado no existe cómo historia médica", MsgBoxStyle.Information, "La historia médica no existe")
            EXEerror = True
        End If

        Return EXEerror

    End Function
End Class
