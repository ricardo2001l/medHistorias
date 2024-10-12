Imports entidad

Public Class Fpuesto
    Inherits Fgeneral

    Public Function agregar(ByVal codPuesto As String, ByVal nombre As String, ByVal descripcion As String, ByVal sueldo As String) As Boolean
        Dim yaExiste = existe("CodPuesto", "Puesto", codPuesto)

        If Not yaExiste Then
            conectar()

            cmd.Connection = conn
            cmd.CommandType = CommandType.Text
            'Dim Eclave As String = generarClaveSHA1(clave)

            sql = "INSERT INTO Puesto (CodPuesto, Nombre, Descripcion, Sueldo)"
            sql += "VALUES ('" & codPuesto & "','" & nombre & "','" & descripcion & "','" & sueldo & "');"
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
            MsgBox("El puesto ya existe, elija otro", MsgBoxStyle.Critical, "ERROR")
            EXEerror = True
        End If
        Return EXEerror
    End Function

    Public Function modificar(ByVal codPuesto As String, ByVal nombre As String, ByVal descripcion As String, ByVal sueldo As String) As Boolean
        Dim yaExiste = existe("CodPuesto", "Puesto", codPuesto)

        If yaExiste Then
            conectar()

            ' MODIFICA LA TABLA INVENTARIO COMPRA
            cmd.Connection = conn
            cmd.CommandType = CommandType.Text

            sql = "UPDATE Puesto "
            sql += "SET Nombre='" & nombre & "', "
            sql += "Descripcion='" & descripcion & "', "
            sql += "Sueldo='" & sueldo & "' "
            sql += "WHERE CodPuesto='" & codPuesto & "';"
            cmd.CommandText = sql
            Try
                cmd.ExecuteNonQuery()
                EXEerror = False
            Catch ex As Exception
                MsgBox(ex.Message)
                EXEerror = True
            End Try
        Else
            MsgBox("El puesto ingresado no existe", MsgBoxStyle.Information, "Puesto no existe")
            EXEerror = True
        End If
        desconectar()
        Return EXEerror
    End Function
    Public Function eliminar(ByVal codPuesto As String) As Boolean
        Dim yaExiste = existe("CodPuesto", "Puesto", codPuesto)

        If yaExiste Then
            conectar()

            cmd.Connection = conn
            cmd.CommandType = CommandType.Text

            sql = "DELETE FROM Puesto WHERE CodPuesto='" & codPuesto & "'"
            cmd.CommandText = sql
            Try
                cmd.ExecuteNonQuery()
                EXEerror = False
            Catch ex As Exception
                MsgBox(ex.Message)
                EXEerror = True
            End Try
        Else
            MsgBox("El puesto ingresado no existe", MsgBoxStyle.Information, "Puesto no existe")
            EXEerror = True
        End If
        desconectar()

        Return EXEerror
    End Function
End Class
