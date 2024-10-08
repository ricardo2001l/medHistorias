Imports entidad
Imports datos

Public Class modUsuario

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

    Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click
        If Me.cmbNombreUsuario.Text <> "" And Me.txtClave.Text <> "" And Me.txtNombre.Text <> "" And Me.txtApellido.Text <> "" And Me.txtTelefono.Text <> "" And Me.txtCorreo.Text <> "" And (Me.radioAdmin.Checked Or Me.radioMedico.Checked) Then
            If (Me.txtClave.TextLength >= 6) And (Me.txtClave.TextLength <= 30) Then
                eu._nombreUsuario = Me.cmbNombreUsuario.Text
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

                EXEerror = fu.modificar(eu._nombreUsuario, eu._contrasena, eu._nombre, eu._apellido, eu._telefono, eu._email, eu._administrador, eu._fechaDeNacimiento)
                If Not EXEerror Then
                    MsgBox("El usuario se ha modificado correctamente.", MsgBoxStyle.Information, "Ejecución correcta")
                    limpiarControles(True)
                End If
            Else
                MsgBox("La contraseña del usuario no puede ser menor a 6 caracteres ni mayor a 30", MsgBoxStyle.Information, "Error")
            End If
        Else
            MsgBox("Tiene que llenar todos los campos para modificar un usuario", MsgBoxStyle.Critical, "Le falta un campo por llenar")
        End If
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

                enableControles(True)
            Else
                enableControles(False)
                MsgBox("No se encontró el registro en la base de datos", MsgBoxStyle.Exclamation, "Ingrese otro identificador")
            End If
            fu.desconectar()
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


        enableControles(False)
    End Sub

    ' ACTIVA Y DESACTIVA LOS CONTROLES
    Private Sub enableControles(ByVal valor As Boolean)
        Me.btnModificar.Enabled = valor
        If Not valor Then
            ' REINICIAR COMBO USERNAME 
            eu._nombreUsuario = ""
            Me.txtNombre.Enabled = False
            Me.txtApellido.Enabled = False
            Me.txtClave.Enabled = False
            Me.txtTelefono.Enabled = False
            Me.txtCorreo.Enabled = False
            Me.radioAdmin.Enabled = False
            Me.radioMedico.Enabled = False
            Me.fechaNacimiento.Enabled = False
            Me.btnModificar.Enabled = False
        Else
            Me.txtNombre.Enabled = True
            Me.txtApellido.Enabled = True
            Me.txtClave.Enabled = True
            Me.txtTelefono.Enabled = True
            Me.txtCorreo.Enabled = True
            Me.radioAdmin.Enabled = True
            Me.radioMedico.Enabled = True
            Me.fechaNacimiento.Enabled = True
            Me.btnModificar.Enabled = True
        End If
    End Sub

    Private Sub modUsuario_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        llenarCmb(Me.cmbNombreUsuario, "NombreDeUsuario", "Usuario")
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

                enableControles(True)
            Else
                MsgBox("El nombre de usuario ingresado no existe", MsgBoxStyle.Exclamation, "Ingrese otro usuario")
                enableControles(False)
                limpiarControles()
            End If
            fu.desconectar()
        End If
    End Sub
End Class