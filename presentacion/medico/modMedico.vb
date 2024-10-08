Imports entidad
Imports datos

Public Class modMedico
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

        Me.cmbCedula.Text = em._cedulaMedico
        Me.txtNombre.Text = em._nombre
        Me.txtApellido.Text = em._apellido
        Me.txtTelefono.Text = em._telefono
        Me.txtCorreo.Text = em._email
        Me.radioMasculino.Checked = False
        Me.radioFemenino.Checked = False
        Me.fechaNacimiento.Value = CDate(em._fechaDeNacimiento)
        Me.fechaIngreso.Value = CDate(em._fechaDeIngreso)
        Me.cmbPuesto.Text = em._CodPuesto


        enableControles(False)
    End Sub
    ' ACTIVA Y DESACTIVA LOS CONTROLES
    Private Sub enableControles(ByVal valor As Boolean)
        Me.btnModificar.Enabled = valor
        If Not valor Then
            ' REINICIAR COMBO USERNAME 
            em._cedulaMedico = ""
            Me.cmbCedula.Text = em._cedulaMedico
            Me.txtNombre.Enabled = False
            Me.txtApellido.Enabled = False
            Me.txtTelefono.Enabled = False
            Me.txtCorreo.Enabled = False
            Me.radioMasculino.Enabled = False
            Me.radioFemenino.Enabled = False
            Me.fechaNacimiento.Enabled = False
            Me.fechaIngreso.Enabled = False
            Me.cmbPuesto.Enabled = False
        Else
            Me.txtNombre.Enabled = True
            Me.txtApellido.Enabled = True
            Me.txtTelefono.Enabled = True
            Me.txtCorreo.Enabled = True
            Me.radioMasculino.Enabled = True
            Me.radioFemenino.Enabled = True
            Me.fechaNacimiento.Enabled = True
            Me.fechaIngreso.Enabled = True
            Me.cmbPuesto.Enabled = True
        End If
    End Sub

    Private Sub modMedico_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        llenarCmb(Me.cmbPuesto, "CodPuesto", "Puesto")
        llenarCmb(Me.cmbCedula, "CedulaMedico", "Medico")
    End Sub

    Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click
        If Me.cmbCedula.Text <> "" And Me.txtNombre.Text <> "" And Me.txtApellido.Text <> "" And Me.txtTelefono.Text <> "" And Me.txtCorreo.Text <> "" And Me.cmbPuesto.Text <> "" And (Me.radioMasculino.Checked Or Me.radioFemenino.Checked) Then
            em._cedulaMedico = Me.cmbCedula.Text
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

            EXEerror = fm.modificar(em._cedulaMedico, em._nombre, em._apellido, em._telefono, em._email, em._fechaDeNacimiento, em._fechaDeIngreso, em._Sexo, em._CodPuesto)

            If Not EXEerror Then
                MsgBox("El médico se ha modificado correctamente.", MsgBoxStyle.Information, "Ejecución correcta")
                limpiarControles(True)
            End If
        Else
            MsgBox("Tiene que llenar todos los campos para modificar un médico", MsgBoxStyle.Critical, "Le falta un campo por llenar")
        End If
    End Sub

    Private Sub cmbCedula_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbCedula.SelectedValueChanged
        If Me.cmbCedula.SelectedItem.ToString <> "" Then
            dt = fm.consultarRegistro("CedulaMedico", Me.cmbCedula.SelectedItem.ToString, "Medico", True)

            If dt.Rows.Count > 0 Then
                Me.txtCedula.Text = Me.cmbCedula.SelectedItem.ToString


                em._nombre = dt(0)("Nombre").ToString
                em._apellido = dt(0)("Apellido").ToString
                em._telefono = dt(0)("Telefono").ToString
                em._email = dt(0)("Email").ToString
                em._fechaDeNacimiento = dt(0)("FechaDeNacimiento").ToString
                em._fechaDeIngreso = dt(0)("FechaDeIngreso").ToString
                em._Sexo = dt(0)("Sexo").ToString
                em._CodPuesto = dt(0)("CodPuesto").ToString


                Me.txtNombre.Text = em._nombre
                Me.txtApellido.Text = em._apellido
                Me.txtTelefono.Text = em._telefono
                Me.txtCorreo.Text = em._email
                Me.fechaNacimiento.Text = em._fechaDeNacimiento
                Me.fechaIngreso.Text = em._fechaDeIngreso
                Me.cmbPuesto.Text = em._CodPuesto
                If em._Sexo = "Masculino" Then
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
            fm.desconectar()
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

    Private Sub fechaNacimiento_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles fechaNacimiento.Leave
        Dim hoy As Date = Date.Today
        Dim nacimiento As Date = Me.fechaNacimiento.Value
        Dim hace18anos As Date = hoy.AddYears(-18)
        Dim esMayorEdad As Integer

        esMayorEdad = Date.Compare(nacimiento, hace18anos)
        If esMayorEdad = 1 Then
            MsgBox("El médico no puede ser menor de edad, ingrese una fecha de nacimiento válida.", MsgBoxStyle.Information, "Fecha de nacimiento no válida")
            Me.btnModificar.Enabled = False
        Else
            Me.btnModificar.Enabled = True
        End If
    End Sub

    Private Sub txtCedula_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCedula.Leave
        If Me.txtCedula.Text <> "" Then
            dt = fm.consultarRegistro("CedulaMedico", Me.txtCedula.Text, "Medico", True)

            If dt.Rows.Count > 0 Then
                Me.cmbCedula.SelectedItem = Me.txtCedula.Text

                em._nombre = dt(0)("Nombre").ToString
                em._apellido = dt(0)("Apellido").ToString
                em._telefono = dt(0)("Telefono").ToString
                em._email = dt(0)("Email").ToString
                em._fechaDeNacimiento = dt(0)("FechaDeNacimiento").ToString
                em._fechaDeIngreso = dt(0)("FechaDeIngreso").ToString
                em._Sexo = dt(0)("Sexo").ToString
                em._CodPuesto = dt(0)("CodPuesto").ToString


                Me.txtNombre.Text = em._nombre
                Me.txtApellido.Text = em._apellido
                Me.txtTelefono.Text = em._telefono
                Me.txtCorreo.Text = em._email
                Me.fechaNacimiento.Text = em._fechaDeNacimiento
                Me.fechaIngreso.Text = em._fechaDeIngreso
                Me.cmbPuesto.Text = em._CodPuesto
                If em._Sexo = "Masculino" Then
                    Me.radioMasculino.Checked = True
                    Me.radioFemenino.Checked = False
                Else
                    Me.radioMasculino.Checked = False
                    Me.radioFemenino.Checked = True
                End If

                enableControles(True)
            Else
                MsgBox("El nombre de médico ingresado no existe", MsgBoxStyle.Exclamation, "Ingrese otra cédula")
                enableControles(False)
                limpiarControles()
            End If
            fm.desconectar()
        End If
    End Sub
End Class