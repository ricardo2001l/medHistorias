Imports entidad
Public Class Fpaciente
    Inherits Fgeneral


    Public Function agregar(ByVal cedulaPaciente As String, ByVal nombre As String, ByVal apellido As String, ByVal telefono As String, ByVal email As String, ByVal fechaNacimiento As String, ByVal sexo As String, ByVal residencia As String) As Boolean
        Dim yaExiste = existe("CedulaPaciente", "Paciente", cedulaPaciente)

        If Not yaExiste Then
            conectar()

            cmd.Connection = conn
            cmd.CommandType = CommandType.Text
            'Dim Eclave As String = generarClaveSHA1(clave)

            sql = "INSERT INTO Paciente (CedulaPaciente, Nombre, Apellido, Telefono, Email, FechaDeNacimiento, Sexo, Residencia)"
            sql += "VALUES ('" & cedulaPaciente & "','" & nombre & "','" & apellido & "','" & telefono & "','" & email & "','" & fechaNacimiento & "','" & sexo & "','" & residencia & "');"
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
            MsgBox("La cédula del paciente ingresada ya existe, elija otro", MsgBoxStyle.Critical, "ERROR")
            EXEerror = True
        End If
        Return EXEerror
    End Function

    Public Function modificar(ByVal cedulaPaciente As String, ByVal nombre As String, ByVal apellido As String, ByVal telefono As String, ByVal email As String, ByVal fechaNacimiento As String, ByVal sexo As String, ByVal residencia As String) As Boolean


        Dim yaExiste = existe("CedulaPaciente", "Paciente", cedulaPaciente)

        If yaExiste Then
            ' MODIFICA LA TABLA INVENTARIO COMPRA
            conectar()
            cmd.Connection = conn
            cmd.CommandType = CommandType.Text

            sql = "UPDATE Paciente "
            sql += "SET Nombre='" & nombre & "', "
            sql += "Apellido='" & apellido & "', "
            sql += "Telefono='" & telefono & "', "
            'If modificarClave Then
            'Dim Eclave As String = generarClaveSHA1(clave)
            sql += "Email='" & email & "', "
            'End If
            sql += "FechaDeNacimiento='" & fechaNacimiento & "', "
            sql += "Sexo='" & sexo & "', "
            sql += "Residencia='" & residencia & "' "
            sql += "WHERE CedulaPaciente='" & cedulaPaciente & "';"
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
            MsgBox("La cédula de paciente ingresada  no existe", MsgBoxStyle.Information, "El paciente no existe")
            EXEerror = True
        End If
        Return EXEerror
    End Function
    Public Function eliminar(ByVal cedulaPaciente As String) As Boolean
        Dim yaExiste = existe("CedulaPaciente", "Paciente", cedulaPaciente)

        If yaExiste Then
            conectar()

            cmd.Connection = conn
            cmd.CommandType = CommandType.Text

            sql = "DELETE FROM Paciente WHERE CedulaPaciente='" & cedulaPaciente & "'"
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
            MsgBox("La cédula de paciente ingresada  ingresado no existe", MsgBoxStyle.Information, "El paciente no existe")
            EXEerror = True
        End If

        Return EXEerror
    End Function
End Class
