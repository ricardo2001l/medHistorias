Imports entidad

Public Class FconsultaMedica
    Inherits Fgeneral



    Public Function agregar(ByVal codConsulta As String, ByVal cedulaMedico As String, ByVal cedulaPaciente As String, ByVal fecha As String, ByVal motivo As String, ByVal peso As String, ByVal altura As String, ByVal sintomas As String, ByVal diagnostico As String) As Boolean
        Dim yaExiste = existe("CodConsulta", "Consulta", codConsulta)

        If Not yaExiste Then
            conectar()

            cmd.Connection = conn
            cmd.CommandType = CommandType.Text

            sql = "INSERT INTO Consulta (CodConsulta, CedulaMedico, CedulaPaciente, Fecha, Motivo, Peso, Altura, Sintomas, Diagnostico)"
            sql += "VALUES ('" & codConsulta & "','" & cedulaMedico & "','" & cedulaPaciente & "','" & fecha & "','" & motivo & "','" & peso & "','" & altura & "','" & sintomas & "','" & diagnostico & "');"
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
            MsgBox("La consulta ingresada ya existe cómo historia médica, elija otro", MsgBoxStyle.Critical, "ERROR")
            EXEerror = True
        End If
        Return EXEerror
    End Function

    Public Function modificar(ByVal codConsulta As String, ByVal cedulaMedico As String, ByVal cedulaPaciente As String, ByVal fecha As String, ByVal motivo As String, ByVal peso As String, ByVal altura As String, ByVal sintomas As String, ByVal diagnostico As String) As Boolean


        Dim yaExiste = existe("CodConsulta", "Consulta", codConsulta)

        If yaExiste Then
            conectar()
            cmd.Connection = conn
            cmd.CommandType = CommandType.Text

            sql = "UPDATE Consulta "
            sql += "SET CedulaMedico='" & cedulaMedico & "', "
            sql += "CedulaPaciente='" & cedulaPaciente & "', "
            sql += "Fecha='" & fecha & "', "
            sql += "Motivo='" & motivo & "', "
            sql += "Peso='" & peso & "', "
            sql += "Altura='" & altura & "', "
            sql += "Sintomas='" & sintomas & "', "
            sql += "Diagnostico='" & diagnostico & "' "
            sql += "WHERE CodConsulta='" & codConsulta & "';"
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
            MsgBox("La consulta ingresada no existe cómo historia médica", MsgBoxStyle.Information, "La consulta no existe")
            EXEerror = True
        End If
        Return EXEerror
    End Function
    Public Function eliminar(ByVal codConsulta As String) As Boolean
        Dim yaExiste = existe("CodConsulta", "Consulta", codConsulta)

        If yaExiste Then
            conectar()

            cmd.Connection = conn
            cmd.CommandType = CommandType.Text

            sql = "DELETE FROM Consulta WHERE CodConsulta='" & codConsulta & "'"
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
            MsgBox("La consulta ingresada ingresado no existe cómo historia médica", MsgBoxStyle.Information, "La consulta no existe")
            EXEerror = True
        End If

        Return EXEerror
    End Function
End Class
