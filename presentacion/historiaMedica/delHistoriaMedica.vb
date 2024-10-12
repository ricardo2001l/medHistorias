Imports entidad
Imports datos

Public Class delHistoriaMedica

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

    Private Sub btnVolver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVolver.Click
        menuHistoriaMedica.Show()
        Me.Close()
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub delHistoriaMedica_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        llenarCmb(Me.cmbCedula, "CedulaPaciente", "HistoriaMedica")
    End Sub

    Private Sub cmbCedula_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbCedula.SelectedValueChanged
        If Me.cmbCedula.SelectedItem.ToString <> "" Then
            dt = fh.consultarRegistro("CodHistoriaMedica", Me.cmbCedula.SelectedItem.ToString, "HistoriaMedica", True)

            If dt.Rows.Count > 0 Then

                eh._cedulaPaciente = dt(0)("CedulaPaciente").ToString
                eh._antecedentes = dt(0)("Antecedentes").ToString
                eh._antecedentesFamiliares = dt(0)("AntecedentesFamiliares").ToString
                eh._tratamientos = dt(0)("Tratamientos").ToString


                Me.cmbCedula.Text = eh._cedulaPaciente
                Me.txtAntecedentes.Text = eh._antecedentes
                Me.txtAntecedentesFamiliares.Text = eh._antecedentesFamiliares
                Me.txtTratamientos.Text = eh._tratamientos

                Me.btnEliminar.Enabled = True
            Else
                Me.btnEliminar.Enabled = False
                MsgBox("No se encontró el registro en la base de datos", MsgBoxStyle.Exclamation, "Ingrese otro identificador")
            End If
            fh.desconectar()
        End If
    End Sub

    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
        Dim eliminar As Integer
        eliminar = MsgBox("¿Está seguro que desea eliminar esta historia médica?", MsgBoxStyle.OkCancel, "Eliminar historia médica")

        If eliminar = 1 Then
            If Me.cmbCedula.Text.ToString <> "" Then
                eh._codHistoria = Me.cmbCedula.Text

                Try
                    EXEerror = fh.eliminar(eh._codHistoria)
                    If Not EXEerror Then
                        MsgBox("Se ha eliminado correctamente la historia médica.", MsgBoxStyle.OkOnly, "Eliminación corecta")
                    End If


                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try

                If Not EXEerror Then
                    llenarCmb(Me.cmbCedula, "CedulaPaciente", "HistoriaMedica")
                    limpiarControles()
                End If

            Else
                MsgBox("Es necesario elegir la cédula para eliminar sus datos", MsgBoxStyle.Information, "No eligió la cédula del paciente")
            End If
        End If
    End Sub
End Class