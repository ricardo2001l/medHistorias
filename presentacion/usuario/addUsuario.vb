Imports entidad
Imports datos


Public Class addUsuario

    Dim fu As New Fusuario
    Dim eu As New Eusuario
    Public dt As New DataTable
    Dim EXEerror As Boolean

    Private Sub btnVolver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVolver.Click
        menuUsuario.Show()
        Me.Close()
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub btnAnadir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAnadir.Click
        If Me.txtNombreUsuario.Text <> "" And Me.txtClave.Text <> "" And Me.txtNombre.Text <> "" And Me.txtApellido.Text <> "" And Me.txtTelefono.Text <> "" And Me.txtCorreo.Text <> "" And (Me.radioAdmin.Checked Or Me.radioMedico.Checked) Then
            If (Me.txtNombreUsuario.TextLength >= 6) And (Me.txtNombreUsuario.TextLength <= 25) Then
                If (Me.txtClave.TextLength >= 6) And (Me.txtClave.TextLength <= 30) Then
                    eu._nombreUsuario = Me.txtNombreUsuario.Text
                    eu._nombre = Me.txtNombre.Text
                    eu._apellido = Me.txtApellido.Text
                    eu._telefono = Me.txtTelefono.Text
                    eu._email = Me.txtCorreo.Text
                    If Me.radioAdmin.Checked Then
                        eu._administrador = "True"
                    Else
                        eu._administrador = "False"
                    End If
                    eu._contrasena = Me.txtClave.Text
                    eu._fechaDeNacimiento = Me.fechaNacimiento.Value.Day.ToString + "/" + Me.fechaNacimiento.Value.Month.ToString + "/" + Me.fechaNacimiento.Value.Year.ToString

                    EXEerror = fu.agregar(eu._nombreUsuario, eu._contrasena, eu._nombre, eu._apellido, eu._telefono, eu._email, eu._administrador, eu._fechaDeNacimiento)
                    If Not EXEerror Then
                        MsgBox("El usuario se ha agregado correctamente.", MsgBoxStyle.Information, "Ejecución correcta")
                        limpiarControles(True)
                    End If
                Else
                    MsgBox("La contraseña del usuario no puede ser menor a 6 caracteres ni mayor a 30", MsgBoxStyle.Information, "Error")
                End If
            Else
                MsgBox("El nombre de usuario no puede ser menor a 6 caracteres ni mayor a 25", MsgBoxStyle.Information, "Error")
            End If
        Else
            MsgBox("Tiene que llenar todos los campos para añadir un usuario", MsgBoxStyle.Critical, "Le falta un campo por llenar")
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

        Me.txtNombreUsuario.Text = eu._nombreUsuario
        Me.txtNombre.Text = eu._nombre
        Me.txtApellido.Text = eu._apellido
        Me.txtClave.Text = eu._contrasena
        Me.txtTelefono.Text = eu._telefono
        Me.txtCorreo.Text = eu._email
        Me.radioAdmin.Checked = False
        Me.radioMedico.Checked = False
        Me.fechaNacimiento.Value = CDate(eu._fechaDeNacimiento)
    End Sub

    Private Sub txtApellido_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtApellido.KeyPress
        soloLetrasYEspacios(e)
    End Sub

    Private Sub txtClave_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtClave.KeyPress
        soloNumerosLetrasYCaracteres(e)
    End Sub

    Private Sub txtCorreo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCorreo.KeyPress
        soloNumerosLetrasYCaracteres(e)
    End Sub

    Private Sub txtNombre_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNombre.KeyPress
        soloLetrasYEspacios(e)
    End Sub

    Private Sub txtNombreUsuario_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNombreUsuario.KeyPress
        soloNumerosYletras(e)
    End Sub

    Private Sub txtNombreUsuario_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNombreUsuario.Leave
        If Me.txtNombreUsuario.Text.ToString <> "" Then
            dt = fu.consultarRegistro("NombreDeUsuario", Me.txtNombreUsuario.Text.ToString, "Usuario", True)
            If dt.Rows.Count > 0 Then
                MsgBox("El usuario ya existe, ingrese otro nombre de usuario", MsgBoxStyle.Information, "El nombre de usuario ya existe")
                Me.btnAnadir.Enabled = False
            Else
                Me.btnAnadir.Enabled = True
            End If
        End If
    End Sub
End Class