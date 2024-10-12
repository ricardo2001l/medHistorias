Imports entidad
Imports datos


Public Class modHistoriaMedica

    Dim fh As New FhistoriaMedica
    Dim eh As New EhistoriaMedica
    Dim EXEerror As Boolean
    Public dt As New DataTable

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


    Private Sub enableControles(ByVal valor As Boolean)
        Me.btnModificar.Enabled = valor
        If Not valor Then
            ' REINICIAR COMBO USERNAME 
            eh._cedulaPaciente = ""
            Me.cmbCedula.Text = eh._cedulaPaciente
            Me.txtAntecedentes.Enabled = False
            Me.txtAntecedentesFamiliares.Enabled = False
            Me.txtTratamientos.Enabled = False
        Else
            Me.txtAntecedentes.Enabled = True
            Me.txtAntecedentesFamiliares.Enabled = True
            Me.txtTratamientos.Enabled = True
        End If
    End Sub

    Private Sub btnVolver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVolver.Click
        menuHistoriaMedica.Show()
        Me.Close()
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub modHistoriaMedica_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        llenarCmb(Me.cmbCedula, "CedulaPaciente", "HistoriaMedica")
    End Sub

    Private Sub cmbCedula_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbCedula.SelectedValueChanged
        If Me.cmbCedula.SelectedItem.ToString <> "" Then
            dt = fh.consultarRegistro("CodHistoriaMedica", Me.cmbCedula.SelectedItem.ToString, "HistoriaMedica", True)

            If dt.Rows.Count > 0 Then
                Me.txtCedula.Text = Me.cmbCedula.SelectedItem.ToString


                eh._cedulaPaciente = dt(0)("CedulaPaciente").ToString
                eh._antecedentes = dt(0)("Antecedentes").ToString
                eh._antecedentesFamiliares = dt(0)("AntecedentesFamiliares").ToString
                eh._tratamientos = dt(0)("Tratamientos").ToString


                Me.cmbCedula.Text = eh._cedulaPaciente
                Me.txtAntecedentes.Text = eh._antecedentes
                Me.txtAntecedentesFamiliares.Text = eh._antecedentesFamiliares
                Me.txtTratamientos.Text = eh._tratamientos

                enableControles(True)
            Else
                enableControles(False)
                MsgBox("No se encontró el registro en la base de datos", MsgBoxStyle.Exclamation, "Ingrese otro identificador")
            End If
            fh.desconectar()
        End If
    End Sub

    Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click
        If Me.cmbCedula.Text <> "" And Me.txtAntecedentes.Text <> "" And Me.txtAntecedentesFamiliares.Text <> "" And Me.txtTratamientos.Text <> "" Then
            eh._codHistoria = Me.cmbCedula.Text
            eh._cedulaPaciente = eh._codHistoria
            eh._antecedentes = Me.txtAntecedentes.Text
            eh._antecedentesFamiliares = Me.txtAntecedentesFamiliares.Text
            eh._tratamientos = Me.txtTratamientos.Text

            EXEerror = fh.modificar(eh._codHistoria, eh._cedulaPaciente, eh._antecedentes, eh._antecedentesFamiliares, eh._tratamientos)

            If Not EXEerror Then
                MsgBox("la historia Médica se ha modificado correctamente.", MsgBoxStyle.Information, "Ejecución correcta")
                limpiarControles(True)
            End If

        Else
            MsgBox("Tiene que llenar todos los campos para modificar una historia médica", MsgBoxStyle.Critical, "Le falta un campo por llenar")
        End If
    End Sub

    Private Sub txtCedula_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCedula.Leave
        If Me.txtCedula.Text <> "" Then
            dt = fh.consultarRegistro("CedulaPaciente", Me.txtCedula.Text, "Paciente", True)

            If dt.Rows.Count > 0 Then
                Me.cmbCedula.SelectedItem = Me.txtCedula.Text

                eh._cedulaPaciente = dt(0)("CedulaPaciente").ToString
                eh._antecedentes = dt(0)("Antecedentes").ToString
                eh._antecedentesFamiliares = dt(0)("AntecedentesFamiliares").ToString
                eh._tratamientos = dt(0)("Tratamientos").ToString


                Me.cmbCedula.Text = eh._cedulaPaciente
                Me.txtAntecedentes.Text = eh._antecedentes
                Me.txtAntecedentesFamiliares.Text = eh._antecedentesFamiliares
                Me.txtTratamientos.Text = eh._tratamientos

                enableControles(True)
            Else
                MsgBox("La cédula del paciente ingresada no existe", MsgBoxStyle.Exclamation, "Ingrese otra cédula")
                enableControles(False)
                limpiarControles()
            End If
            fh.desconectar()
        End If
    End Sub
End Class