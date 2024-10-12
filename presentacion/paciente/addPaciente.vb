Imports entidad
Imports datos

Public Class addPaciente

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

    Private Sub btnAnadir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAnadir.Click
        If Me.txtCedula.Text <> "" And Me.txtNombre.Text <> "" And Me.txtApellido.Text <> "" And Me.txtTelefono.Text <> "" And Me.txtCorreo.Text <> "" And Me.txtResidencia.Text <> "" And (Me.radioMasculino.Checked Or Me.radioFemenino.Checked) Then
            If (Me.txtCedula.TextLength >= 5) And (Me.txtCedula.TextLength <= 10) Then
                ep._cedulaPaciente = Me.txtCedula.Text
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

                EXEerror = fp.agregar(ep._cedulaPaciente, ep._nombre, ep._apellido, ep._telefono, ep._email, ep._fechaDeNacimiento, ep._Sexo, ep._residencia)

                If Not EXEerror Then
                    MsgBox("El paciente se ha agregado correctamente.", MsgBoxStyle.Information, "Ejecución correcta")
                    limpiarControles(True)
                End If

            Else
                MsgBox("La cédula del paciente no puede ser menor a 6 caracteres ni mayor a 25", MsgBoxStyle.Information, "Error")
            End If
        Else
            MsgBox("Tiene que llenar todos los campos para añadir un paciente", MsgBoxStyle.Critical, "Le falta un campo por llenar")
        End If
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

        Me.txtCedula.Text = ep._cedulaPaciente
        Me.txtNombre.Text = ep._nombre
        Me.txtApellido.Text = ep._apellido
        Me.txtTelefono.Text = ep._telefono
        Me.txtCorreo.Text = ep._email
        Me.radioMasculino.Checked = False
        Me.radioFemenino.Checked = False
        Me.fechaNacimiento.Value = CDate(ep._fechaDeNacimiento)
        Me.txtResidencia.Text = ep._residencia
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
    Private Sub txtCedula_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCedula.KeyPress
        soloNumeros(e)
    End Sub

    Private Sub txtResidencia_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtResidencia.KeyPress
        soloNumerosLetrasComasYEspacios(e)
    End Sub
End Class