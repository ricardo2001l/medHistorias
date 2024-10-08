Imports entidad
Imports datos
Public Class delUsuario

    Dim fu As New Fusuario
    Dim eu As New Eusuario
    Dim EXEerror As Boolean
    Public dt As New DataTable

    Private Sub btnVolver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVolver.Click
        menuUsuario.Show()
        Me.Close()
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
        Dim eliminar As Integer
        eliminar = MsgBox("¿Está seguro que desea eliminar este usuario?", MsgBoxStyle.OkCancel, "Eliminar usuario")

        If eliminar = 1 Then
            If Me.cmbNombreUsuario.Text.ToString <> "" Then
                eu._nombreUsuario = Me.cmbNombreUsuario.Text

                Try

                    EXEerror = fu.eliminar(eu._nombreUsuario)
                    If Not EXEerror Then
                        MsgBox("Se ha eliminado correctamente el usuario.", MsgBoxStyle.OkOnly, "Eliminación corecta")
                    End If


                Catch ex As Exception
                    MsgBox(ex.Message)
                    EXEerror = True
                End Try

                If Not EXEerror Then
                    llenarCmb(Me.cmbNombreUsuario, "NombreDeUsuario", "Usuario")
                    limpiarControles(True)
                End If
            Else
                MsgBox("Es necesario elegir el nombre del usuario para eliminar sus datos", MsgBoxStyle.Information, "No eligió el nombre del usuario")
            End If
        End If
    End Sub

    Private Sub limpiarControles(Optional ByVal limpiarNombrUsuario As Boolean = True)
        eu._nombreUsuario = ""
        eu._nombre = ""
        eu._apellido = ""
        eu._telefono = ""
        eu._email = ""
        eu._administrador = ""
        eu._contrasena = ""
        eu._fechaDeNacimiento = Date.Today.ToString

        Me.cmbNombreUsuario.Text = eu._nombreUsuario
        Me.txtNombre.Text = eu._nombre
        Me.txtApellido.Text = eu._apellido
        Me.txtClave.Text = eu._contrasena
        Me.txtTelefono.Text = eu._telefono
        Me.txtCorreo.Text = eu._email
        Me.radioAdmin.Checked = False
        Me.radioMedico.Checked = False
        Me.fechaNacimiento.Value = CDate(eu._fechaDeNacimiento)
    End Sub

    Private Sub delUsuario_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        llenarCmb(Me.cmbNombreUsuario, "NombreDeUsuario", "Usuario")
    End Sub

    Private Sub cmbNombreUsuario_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbNombreUsuario.SelectedValueChanged
        If Me.cmbNombreUsuario.SelectedItem.ToString <> "" Then
            dt = fu.consultarRegistro("NombreDeUsuario", Me.cmbNombreUsuario.SelectedItem.ToString, "Usuario", True)

            If dt.Rows.Count > 0 Then
                Me.txtUsuario.Text = Me.cmbNombreUsuario.SelectedItem.ToString

                eu._nombre = dt(0)("Nombre").ToString
                eu._apellido = dt(0)("Apellido").ToString
                eu._telefono = dt(0)("Telefono").ToString
                eu._email = dt(0)("Email").ToString
                eu._administrador = dt(0)("Administrador").ToString
                eu._fechaDeNacimiento = dt(0)("FechaDeNacimiento").ToString

                Me.txtNombre.Text = eu._nombre
                Me.txtApellido.Text = eu._apellido
                Me.txtTelefono.Text = eu._telefono
                Me.txtCorreo.Text = eu._email
                Me.fechaNacimiento.Text = eu._fechaDeNacimiento

                If eu._administrador = "True" Then
                    Me.radioAdmin.Checked = True
                    Me.radioMedico.Checked = False
                Else
                    Me.radioAdmin.Checked = False
                    Me.radioMedico.Checked = True
                End If
                Me.btnEliminar.Enabled = True
            Else
                Me.btnEliminar.Enabled = False
                MsgBox("No se encontró el registro en la base de datos", MsgBoxStyle.Exclamation, "Ingrese otro identificador")
            End If
            fu.desconectar()
        End If
    End Sub

    Private Sub txtUsuario_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtUsuario.Leave
        If Me.txtUsuario.Text <> "" Then
            dt = fu.consultarRegistro("NombreDeUsuario", Me.txtUsuario.Text, "Usuario", True)

            If dt.Rows.Count > 0 Then
                Me.cmbNombreUsuario.SelectedItem = Me.txtUsuario.Text

                eu._nombre = dt(0)("Nombre").ToString
                eu._apellido = dt(0)("Apellido").ToString
                eu._telefono = dt(0)("Telefono").ToString
                eu._email = dt(0)("Email").ToString
                eu._administrador = dt(0)("Administrador").ToString
                eu._fechaDeNacimiento = dt(0)("FechaDeNacimiento").ToString

                Me.txtNombre.Text = eu._nombre
                Me.txtApellido.Text = eu._apellido
                Me.txtTelefono.Text = eu._telefono
                Me.txtCorreo.Text = eu._email
                Me.fechaNacimiento.Text = eu._fechaDeNacimiento

                If eu._administrador = "True" Then
                    Me.radioAdmin.Checked = True
                    Me.radioMedico.Checked = False
                Else
                    Me.radioAdmin.Checked = False
                    Me.radioMedico.Checked = True
                End If
            Else
                MsgBox("El nombre de usuario ingresado no existe", MsgBoxStyle.Exclamation, "Ingrese otro usuario")
                limpiarControles()
            End If
            fu.desconectar()
        End If
    End Sub
End Class