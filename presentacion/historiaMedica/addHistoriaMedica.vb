Imports entidad
Imports datos
Public Class addHistoriaMedica

    Dim fh As New FhistoriaMedica
    Dim eh As New EhistoriaMedica
    Dim EXEerror As Boolean
    Public dt As New DataTable

    Private Sub btnVolver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVolver.Click
        menuHistoriaMedica.Show()
        Me.Close()
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub limpiarControles(Optional ByVal limpiarNombrUsuario As Boolean = True)
        eh._codHistoria = ""
        eh._cedulaPaciente = ""
        eh._antecedentes = ""
        eh._antecedentesFamiliares = ""
        eh._tratamientos = ""

        Me.cmbCedula.Items.Add("")
        Me.cmbCedula.Text = eh._cedulaPaciente
        Me.txtAntecedentes.Text = eh._antecedentes
        Me.txtAntecedentesFamiliares.Text = eh._antecedentesFamiliares
        Me.txtTratamientos.Text = eh._tratamientos
    End Sub

    Private Sub cmbCedula_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbCedula.SelectedValueChanged
        ' PROGRAMAR QUE SI SE SELECCIONA UNA CÉDULA DE UN USUARIO YA REGISTRADO, AVISE AL USUARIO Y LIMPIE LOS CAMPOS
        If Me.cmbCedula.SelectedItem.ToString <> "" Then
            dt = fh.consultarRegistro("CodHistoriaMedica", Me.cmbCedula.SelectedItem.ToString, "HistoriaMedica", True)

            If dt.Rows.Count > 0 Then
                MsgBox("No se puede añadir la cedula " + Me.cmbCedula.SelectedItem.ToString + ", porque ya existe en la base de datos", MsgBoxStyle.Exclamation, "Ingrese otro identificador")
                limpiarControles()
            Else
                Me.txtCedula.Text = Me.cmbCedula.SelectedItem.ToString
            End If
            fh.desconectar()
        End If
    End Sub

    Private Sub btnAnadir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAnadir.Click
        If Me.cmbCedula.Text <> "" And Me.txtAntecedentes.Text <> "" And Me.txtAntecedentesFamiliares.Text <> "" And Me.txtTratamientos.Text <> "" Then
            eh._codHistoria = Me.cmbCedula.Text
            eh._cedulaPaciente = eh._codHistoria
            eh._antecedentes = Me.txtAntecedentes.Text
            eh._antecedentesFamiliares = Me.txtAntecedentesFamiliares.Text
            eh._tratamientos = Me.txtTratamientos.Text



            EXEerror = fh.agregar(eh._codHistoria, eh._cedulaPaciente, eh._antecedentes, eh._antecedentesFamiliares, eh._tratamientos)

            If Not EXEerror Then
                MsgBox("La historia médica se ha agregado correctamente.", MsgBoxStyle.Information, "Ejecución correcta")
                limpiarControles(True)
            End If

        Else
            MsgBox("Tiene que llenar todos los campos para añadir una historia médica", MsgBoxStyle.Critical, "Le falta un campo por llenar")
        End If
    End Sub

    Private Sub addHistoriaMedica_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        llenarCmb(Me.cmbCedula, "CedulaPaciente", "Paciente")
    End Sub

    Private Sub txtCedula_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCedula.Leave
        dt = fh.consultarRegistro("CodHistoriaMedica", Me.txtCedula.Text, "HistoriaMedica", True)

        If dt.Rows.Count > 0 Then
            MsgBox("No se puede añadir la cedula " + Me.txtCedula.Text + ", porque ya existe en la base de datos", MsgBoxStyle.Exclamation, "Ingrese otro identificador")
            limpiarControles()
        Else
            Me.cmbCedula.SelectedItem = Me.txtCedula.Text
        End If
        fh.desconectar()
    End Sub
End Class