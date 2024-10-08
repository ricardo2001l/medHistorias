Imports entidad
Public Class Fusuario
    Inherits Fgeneral


    Public Function validarUsuario(ByVal dts As Eusuario) As DataTable
        conectar()
        cmd.Connection = conn
        cmd.CommandType = CommandType.Text

        sql = "SELECT * FROM Usuario WHERE NombreDeUsuario='" & dts._nombreUsuario & "' AND Clave='" & dts._contrasena & "';"
        cmd.CommandText = Sql
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
    Public Function agregar(ByVal nombreUsuario As String, ByVal clave As String, ByVal nombre As String, ByVal apellido As String, ByVal telefono As String, ByVal email As String, ByVal administrador As String, ByVal fechaNacimiento As String) As Boolean
        Dim yaExiste = existe("NombreDeUsuario", "Usuario", nombreUsuario)

        If Not yaExiste Then
            conectar()

            cmd.Connection = conn
            cmd.CommandType = CommandType.Text
            'Dim Eclave As String = generarClaveSHA1(clave)

            sql = "INSERT INTO Usuario (NombreDeUsuario, Clave, Nombre, Apellido, Telefono, Email, Administrador, FechaDeNacimiento)"
            sql += "VALUES ('" & nombreUsuario & "','" & clave & "','" & nombre & "','" & apellido & "','" & telefono & "','" & email & "','" & administrador & "','" & fechaNacimiento & "');"
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
            MsgBox("El nombre de usuario ya existe, elija otro", MsgBoxStyle.Critical, "ERROR")
            EXEerror = True
        End If
        Return EXEerror
    End Function

    Public Function modificar(ByVal nombreUsuario As String, ByVal clave As String, ByVal nombre As String, ByVal apellido As String, ByVal telefono As String, ByVal email As String, ByVal administrador As String, ByVal fechaDeNacimiento As String) As Boolean
        Dim yaExiste = existe("NombreDeUsuario", "Usuario", nombreUsuario)

        If yaExiste Then
            conectar()

            ' MODIFICA LA TABLA INVENTARIO COMPRA
            cmd.Connection = conn
            cmd.CommandType = CommandType.Text

            sql = "UPDATE Usuario "
            sql += "SET Clave='" & clave & "', "
            sql += "Nombre='" & nombre & "', "
            sql += "Apellido='" & apellido & "', "
            'If modificarClave Then
            'Dim Eclave As String = generarClaveSHA1(clave)
            sql += "Telefono='" & telefono & "', "
            'End If
            sql += "Email='" & email & "', "
            sql += "Administrador='" & administrador & "', "
            sql += "FechaDeNacimiento='" & fechaDeNacimiento & "' "
            sql += "WHERE NombreDeUsuario='" & nombreUsuario & "';"
            cmd.CommandText = sql

            Try
                cmd.ExecuteNonQuery()
                EXEerror = False
            Catch ex As Exception
                MsgBox(ex.Message)
                EXEerror = True
            End Try
        Else
            MsgBox("El nombre de usuario ingresado no existe", MsgBoxStyle.Information, "Usuario no existe")
            EXEerror = True
        End If
        desconectar()
        Return EXEerror
    End Function
    Public Function eliminar(ByVal NombreUsuario As String) As Boolean
        Dim yaExiste = existe("NombreDeUsuario", "Usuario", NombreUsuario)

        If yaExiste Then
            conectar()

            cmd.Connection = conn
            cmd.CommandType = CommandType.Text

            sql = "DELETE FROM Usuario WHERE NombreDeUsuario='" & NombreUsuario & "'"
            cmd.CommandText = sql
            Try
                cmd.ExecuteNonQuery()
                EXEerror = False
            Catch ex As Exception
                MsgBox(ex.Message)
                EXEerror = True
            End Try
        Else
            MsgBox("El nombre de usuario ingresado no existe", MsgBoxStyle.Information, "Usuario no existe")
            EXEerror = True
        End If
        desconectar()
        Return EXEerror
    End Function
End Class
