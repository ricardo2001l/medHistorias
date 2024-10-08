Imports entidad
Imports datos


Public Class addMedico

    Dim fm As New Fmedico
    Dim em As New Emedico
    Dim EXEerror As Boolean

    Public dt As New DataTable

    Private Sub btnVolver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVolver.Click
        menuMedico.Show()
        Me.Close()
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub btnAnadir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAnadir.Click
        If Me.txtCedula.Text <> "" And Me.txtNombre.Text <> "" And Me.txtApellido.Text <> "" And Me.txtTelefono.Text <> "" And Me.txtCorreo.Text <> "" And Me.cmbPuesto.Text <> "" And (Me.radioMasculino.Checked Or Me.radioFemenino.Checked) Then
            If (Me.txtCedula.TextLength >= 5) And (Me.txtCedula.TextLength <= 10) Then
                em._cedulaMedico = Me.txtCedula.Text
                em._nombre = Me.txtNombre.Text
                em._apellido = Me.txtApellido.Text
                em._telefono = Me.txtTelefono.Text
                em._email = Me.txtCorreo.Text
                If Me.radioMasculino.Checked Then
                    em._Sexo = "Masculino"
                Else
                    em._Sexo = "Femenino"
                End If
                em._fechaDeNacimiento = Me.fechaNacimiento.Value.Day.ToString + "/" + Me.fechaNacimiento.Value.Month.ToString + "/" + Me.fechaNacimiento.Value.Year.ToString
                em._fechaDeIngreso = Me.fechaIngreso.Value.Day.ToString + "/" + Me.fechaIngreso.Value.Month.ToString + "/" + Me.fechaIngreso.Value.Year.ToString
                em._CodPuesto = Me.cmbPuesto.Text

                EXEerror = fm.agregar(em._cedulaMedico, em._nombre, em._apellido, em._telefono, em._email, em._fechaDeNacimiento, em._fechaDeIngreso, em._Sexo, em._CodPuesto)
                If Not EXEerror Then
                    MsgBox("El médico se ha agregado correctamente.", MsgBoxStyle.Information, "Ejecución correcta")
                    limpiarControles(True)
                End If
            Else
                MsgBox("La cédula del médico no puede ser menor a 6 caracteres ni mayor a 25", MsgBoxStyle.Information, "Error")
            End If
        Else
            MsgBox("Tiene que llenar todos los campos para añadir un médico", MsgBoxStyle.Critical, "Le falta un campo por llenar")
        End If
    End Sub

    Private Sub limpiarControles(Optional ByVal limpiarNombrUsuario As Boolean = True)
        em._cedulaMedico = ""
        em._nombre = ""
        em._apellido = ""
        em._telefono = ""
        em._email = ""
        em._fechaDeNacimiento = Date.Today.ToString
        em._fechaDeIngreso = Date.Today.ToString
        em._Sexo = ""
        em._CodPuesto = ""

        Me.txtCedula.Text = em._cedulaMedico
        Me.txtNombre.Text = em._nombre
        Me.txtApellido.Text = em._apellido
        Me.txtTelefono.Text = em._telefono
        Me.txtCorreo.Text = em._email
        Me.radioMasculino.Checked = False
        Me.radioFemenino.Checked = False
        Me.fechaNacimiento.Value = CDate(em._fechaDeNacimiento)
        Me.fechaIngreso.Value = CDate(em._fechaDeIngreso)
        Me.cmbPuesto.Text = em._CodPuesto
    End Sub

    Private Sub addMedico_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        llenarCmb(Me.cmbPuesto, "CodPuesto", "Puesto")
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

    Private Sub fechaNacimiento_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles fechaNacimiento.Leave
        Dim hoy As Date = Date.Today
        Dim nacimiento As Date = Me.fechaNacimiento.Value
        Dim hace18anos As Date = hoy.AddYears(-18)
        Dim esMayorEdad As Integer

        esMayorEdad = Date.Compare(nacimiento, hace18anos)
        If esMayorEdad = 1 Then
            MsgBox("El médico no puede ser menor de edad, ingrese una fecha de nacimiento válida.", MsgBoxStyle.Information, "Fecha de nacimiento no válida")
            Me.btnAnadir.Enabled = False
        Else
            Me.btnAnadir.Enabled = True
        End If
    End Sub
End Class