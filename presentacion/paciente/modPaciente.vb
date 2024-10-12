Imports entidad
Imports datos
Public Class modPaciente

    Dim fp As New Fpaciente
    Dim ep As New Epaciente
    Dim EXEerror As Boolean
    Public dt As New DataTable

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub btnVolver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVolver.Click
        menuPaciente.Show()
        Me.Close()
    End Sub

    Private Sub limpiarControles(Optional ByVal limpiarNombrUsuario As Boolean = True)
        ep._cedulaPaciente = ""
        ep._nombre = ""
        ep._apellido = ""
        ep._telefono = ""
        ep._email = ""
        ep._fechaDeNacimiento = Date.Today.ToString
        ep._Sexo = ""
        ep._residencia = ""

        Me.cmbCedula.Text = ep._cedulaPaciente
        Me.txtNombre.Text = ep._nombre
        Me.txtApellido.Text = ep._apellido
        Me.txtTelefono.Text = ep._telefono
        Me.txtCorreo.Text = ep._email
        Me.radioMasculino.Checked = False
        Me.radioFemenino.Checked = False
        Me.fechaNacimiento.Value = CDate(ep._fechaDeNacimiento)
        Me.txtResidencia.Text = ep._residencia


        enableControles(False)
    End Sub
    ' ACTIVA Y DESACTIVA LOS CONTROLES
    Private Sub enableControles(ByVal valor As Boolean)
        Me.btnModificar.Enabled = valor
        If Not valor Then
            ' REINICIAR COMBO USERNAME 
            ep._cedulaPaciente = ""
            Me.cmbCedula.Text = ep._cedulaPaciente
            Me.txtNombre.Enabled = False
            Me.txtApellido.Enabled = False
            Me.txtTelefono.Enabled = False
            Me.txtCorreo.Enabled = False
            Me.radioMasculino.Enabled = False
            Me.radioFemenino.Enabled = False
            Me.fechaNacimiento.Enabled = False
            Me.txtResidencia.Enabled = False
        Else
            Me.txtNombre.Enabled = True
            Me.txtApellido.Enabled = True
            Me.txtTelefono.Enabled = True
            Me.txtCorreo.Enabled = True
            Me.radioMasculino.Enabled = True
            Me.radioFemenino.Enabled = True
            Me.fechaNacimiento.Enabled = True
            Me.txtResidencia.Enabled = True
        End If
    End Sub

    Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click
        If Me.cmbCedula.Text <> "" And Me.txtNombre.Text <> "" And Me.txtApellido.Text <> "" And Me.txtTelefono.Text <> "" And Me.txtCorreo.Text <> "" And Me.txtResidencia.Text <> "" And (Me.radioMasculino.Checked Or Me.radioFemenino.Checked) Then
            ep._cedulaPaciente = Me.cmbCedula.Text
            ep._nombre = Me.txtNombre.Text
            ep._apellido = Me.txtApellido.Text
            ep._telefono = Me.txtTelefono.Text
            ep._email = Me.txtCorreo.Text
            If Me.radioMasculino.Checked Then
                ep._Sexo = "Masculino"
            Else
                ep._Sexo = "Femenino"
            End If
            ep._fechaDeNacimiento = Me.fechaNacimiento.Value.Day.ToString + "/" + Me.fechaNacimiento.Value.Month.ToString + "/" + Me.fechaNacimiento.Value.Year.ToString
            ep._residencia = Me.txtResidencia.Text

            EXEerror = fp.modificar(ep._cedulaPaciente, ep._nombre, ep._apellido, ep._telefono, ep._email, ep._fechaDeNacimiento, ep._Sexo, ep._residencia)

            If Not EXEerror Then
                MsgBox("El paciente se ha modificado correctamente.", MsgBoxStyle.Information, "Ejecución correcta")
                limpiarControles(True)
            End If
        Else
            MsgBox("Tiene que llenar todos los campos para modificar un paciente", MsgBoxStyle.Critical, "Le falta un campo por llenar")
        End If
    End Sub

    Private Sub modPaciente_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        llenarCmb(Me.cmbCedula, "CedulaPaciente", "Paciente")
    End Sub

    Private Sub cmbCedula_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbCedula.SelectedValueChanged
        If Me.cmbCedula.SelectedItem.ToString <> "" Then
            dt = fp.consultarRegistro("CedulaPaciente", Me.cmbCedula.SelectedItem.ToString, "Paciente", True)

            If dt.Rows.Count > 0 Then
                Me.txtCedula.Text = Me.cmbCedula.SelectedItem.ToString


                ep._nombre = dt(0)("Nombre").ToString
                ep._apellido = dt(0)("Apellido").ToString
                ep._telefono = dt(0)("Telefono").ToString
                ep._email = dt(0)("Email").ToString
                ep._fechaDeNacimiento = dt(0)("FechaDeNacimiento").ToString
                ep._Sexo = dt(0)("Sexo").ToString
                ep._residencia = dt(0)("Residencia").ToString


                Me.txtNombre.Text = ep._nombre
                Me.txtApellido.Text = ep._apellido
                Me.txtTelefono.Text = ep._telefono
                Me.txtCorreo.Text = ep._email
                Me.fechaNacimiento.Text = ep._fechaDeNacimiento
                Me.txtResidencia.Text = ep._residencia
                If ep._Sexo = "Masculino" Then
                    Me.radioMasculino.Checked = True
                    Me.radioFemenino.Checked = False
                Else
                    Me.radioMasculino.Checked = False
                    Me.radioFemenino.Checked = True
                End If

                enableControles(True)
            Else
                enableControles(False)
                MsgBox("No se encontró el registro en la base de datos", MsgBoxStyle.Exclamation, "Ingrese otro identificador")
            End If
            fp.desconectar()
        End If
    End Sub

    Private Sub txtApellido_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtApellido.KeyPress
        soloLetrasYEspacios(e)
    End Sub

    Private Sub txtNombre_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNombre.KeyPress
        soloLetrasYEspacios(e)
    End Sub

    Private Sub txtCorreo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCorreo.KeyPress
        soloNumerosLetrasYCaracteres(e)
    End Sub

    Private Sub txtResidencia_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtResidencia.KeyPress
        soloNumerosLetrasComasYEspacios(e)
    End Sub

    Private Sub txtCedula_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCedula.Leave
        If Me.txtCedula.Text <> "" Then
            dt = fp.consultarRegistro("CedulaPaciente", Me.txtCedula.Text, "Paciente", True)

            If dt.Rows.Count > 0 Then
                Me.cmbCedula.SelectedItem = Me.txtCedula.Text

                ep._nombre = dt(0)("Nombre").ToString
                ep._apellido = dt(0)("Apellido").ToString
                ep._telefono = dt(0)("Telefono").ToString
                ep._email = dt(0)("Email").ToString
                ep._fechaDeNacimiento = dt(0)("FechaDeNacimiento").ToString
                ep._Sexo = dt(0)("Sexo").ToString
                ep._residencia = dt(0)("Residencia").ToString


                Me.txtNombre.Text = ep._nombre
                Me.txtApellido.Text = ep._apellido
                Me.txtTelefono.Text = ep._telefono
                Me.txtCorreo.Text = ep._email
                Me.fechaNacimiento.Text = ep._fechaDeNacimiento
                Me.txtResidencia.Text = ep._residencia
                If ep._Sexo = "Masculino" Then
                    Me.radioMasculino.Checked = True
                    Me.radioFemenino.Checked = False
                Else
                    Me.radioMasculino.Checked = False
                    Me.radioFemenino.Checked = True
                End If

                enableControles(True)
            Else
                MsgBox("La cédula del paciente ingresada no existe", MsgBoxStyle.Exclamation, "Ingrese otra cédula")
                enableControles(False)
                limpiarControles()
            End If
            fp.desconectar()
        End If
    End Sub
End Class