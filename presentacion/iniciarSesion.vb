Imports entidad
Imports datos
Public Class iniciarSesion
    Dim fu As New Fusuario
    Dim eu As New Eusuario

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub btnIniciar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIniciar.Click
        If Me.txtUsuario.Text <> "" And Me.txtClave.Text <> "" Then
            Dim dt As New DataTable

            eu._nombreUsuario = Me.txtUsuario.Text
            eu._contrasena = Me.txtClave.Text
            dt = fu.validarUsuario(eu)

            If dt.Rows.Count > 0 Then
                Dim isAdmin As String
                isAdmin = dt.Rows(0)("Administrador").ToString
                If isAdmin = "False" Then
                    admin = "False"

                    'mainMenu.btnBaseDatos.Enabled = False
                    'mainMenu.btnMedico.Enabled = False
                    'mainMenu.btnUsuario.Enabled = False
                Else
                    admin = "True"

                    'mainMenu.btnBaseDatos.Enabled = True
                    'mainMenu.btnMedico.Enabled = True
                    'mainMenu.btnUsuario.Enabled = True
                End If
                mainMenu.Show()
                Me.Close()
            Else
                MsgBox("Usuario o Contraseña erroneos.", MsgBoxStyle.Information, "Cuidado")
            End If
        Else
            MsgBox("Ingrese los datos requeridos en los campos.", MsgBoxStyle.Information, "No se pueden enviar campos vacíos")
        End If
    End Sub

    Private Sub iniciarSesion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
