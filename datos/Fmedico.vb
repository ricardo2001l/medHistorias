Imports entidad
Public Class Fmedico
    Inherits Fgeneral

    Public Function agregar(ByVal cedulaMedico As String, ByVal nombre As String, ByVal apellido As String, ByVal telefono As String, ByVal email As String, ByVal fechaNacimiento As String, ByVal fechaIngreso As String, ByVal sexo As String, ByVal codPuesto As String) As Boolean
        Dim yaExiste = existe("CedulaMedico", "Medico", cedulaMedico)

        If Not yaExiste Then
            conectar()

            cmd.Connection = conn
            cmd.CommandType = CommandType.Text
            'Dim Eclave As String = generarClaveSHA1(clave)

            sql = "INSERT INTO Medico (CedulaMedico, Nombre, Apellido, Telefono, Email, FechaDeNacimiento, FechaDeIngreso, Sexo, CodPuesto)"
            sql += "VALUES ('" & cedulaMedico & "','" & nombre & "','" & apellido & "','" & telefono & "','" & email & "','" & fechaNacimiento & "','" & fechaIngreso & "','" & sexo & "','" & codPuesto & "');"
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
            MsgBox("La cédula de médico ingresada ya existe, elija otro", MsgBoxStyle.Critical, "ERROR")
            EXEerror = True
        End If
        Return EXEerror
    End Function

    Public Function modificar(ByVal cedulaMedico As String, ByVal nombre As String, ByVal apellido As String, ByVal telefono As String, ByVal email As String, ByVal fechaNacimiento As String, ByVal fechaIngreso As String, ByVal sexo As String, ByVal codPuesto As String) As Boolean


        Dim yaExiste = existe("CedulaMedico", "Medico", cedulaMedico)

        If yaExiste Then
            ' MODIFICA LA TABLA INVENTARIO COMPRA
            conectar()
            cmd.Connection = conn
            cmd.CommandType = CommandType.Text

            sql = "UPDATE Medico "
            sql += "SET Nombre='" & nombre & "', "
            sql += "Apellido='" & apellido & "', "
            sql += "Telefono='" & telefono & "', "
            'If modificarClave Then
            'Dim Eclave As String = generarClaveSHA1(clave)
            sql += "Email='" & email & "', "
            'End If
            sql += "FechaDeNacimiento='" & fechaNacimiento & "', "
            sql += "FechaDeIngreso='" & fechaIngreso & "', "
            sql += "Sexo='" & sexo & "', "
            sql += "CodPuesto='" & codPuesto & "' "
            sql += "WHERE CedulaMedico='" & cedulaMedico & "';"
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
            MsgBox("La cédula de médico ingresada  no existe", MsgBoxStyle.Information, "El médico no existe")
            EXEerror = True
        End If
        Return EXEerror
    End Function
    Public Function eliminar(ByVal cedulaMedico As String) As Boolean
        Dim yaExiste = existe("CedulaMedico", "Medico", cedulaMedico)

        If yaExiste Then
            conectar()

            cmd.Connection = conn
            cmd.CommandType = CommandType.Text

            sql = "DELETE FROM Medico WHERE CedulaMedico='" & cedulaMedico & "'"
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
            MsgBox("La cédula de médico ingresada  ingresado no existe", MsgBoxStyle.Information, "El médico no existe")
            EXEerror = True
        End If
        Return EXEerror

    End Function
End Class
