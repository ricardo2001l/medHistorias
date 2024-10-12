Imports entidad
Imports datos

Public Class delConsultaMedica

    Dim fc As New FconsultaMedica
    Dim ec As New EconsultaMedica
    Dim EXEerror As Boolean
    Public dt As New DataTable

    Private Sub limpiarControles(Optional ByVal limpiarNombrUsuario As Boolean = True)
        ec._codConsulta = ""
        ec._CedulaMedico = ""
        ec._cedulaPaciente = ""
        ec._fecha = Date.Today.ToString
        ec._motivo = ""
        ec._peso = ""
        ec._altura = ""
        ec._sintomas = ""
        ec._diagnostico = ""

        Me.cmbCedulaMedico.Items.Add("")
        Me.cmbCedulaPaciente.Items.Add("")
        Me.cmbCedulaMedico.Text = ec._CedulaMedico
        Me.cmbCedulaPaciente.Text = ec._cedulaPaciente

        Me.fecha.Text = ec._fecha
        Me.txtMotivo.Text = ec._motivo
        Me.txtPeso.Text = ec._peso
        Me.txtAltura.Text = ec._altura
        Me.txtSintomas.Text = ec._sintomas
        Me.txtDiagnostico.Text = ec._diagnostico
    End Sub

    Private Sub btnVolver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVolver.Click
        menuConsultaMedica.Show()
        Me.Close()
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub delConsultaMedica_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        llenarCmb(Me.cmbCodConsulta, "CodConsulta", "Consulta")
        llenarCmb(Me.cmbCedulaMedico, "CedulaMedico", "Medico")
        llenarCmb(Me.cmbCedulaPaciente, "CedulaPaciente", "Paciente")
    End Sub


    Private Sub cmbCodConsulta_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbCodConsulta.SelectedValueChanged
        If Me.cmbCodConsulta.SelectedItem.ToString <> "" Then
            dt = fc.consultarRegistro("CodConsulta", Me.cmbCodConsulta.SelectedItem.ToString, "Consulta", True)

            If dt.Rows.Count > 0 Then
                ec._cedulaMedico = dt(0)("CedulaMedico").ToString
                ec._cedulaPaciente = dt(0)("CedulaPaciente").ToString
                ec._fecha = dt(0)("Fecha").ToString
                ec._motivo = dt(0)("Motivo").ToString
                ec._peso = dt(0)("Peso").ToString
                ec._altura = dt(0)("Altura").ToString
                ec._sintomas = dt(0)("Sintomas").ToString
                ec._diagnostico = dt(0)("Diagnostico").ToString


                Me.cmbCedulaMedico.Text = ec._cedulaMedico
                Me.cmbCedulaPaciente.Text = ec._cedulaPaciente
                Me.fecha.Text = ec._fecha
                Me.txtMotivo.Text = ec._motivo
                Me.txtPeso.Text = ec._peso
                Me.txtAltura.Text = ec._altura
                Me.txtSintomas.Text = ec._sintomas
                Me.txtDiagnostico.Text = ec._diagnostico

                Me.btnEliminar.Enabled = True
            Else
                Me.btnEliminar.Enabled = False
                MsgBox("No se encontró el registro en la base de datos", MsgBoxStyle.Exclamation, "Ingrese otro identificador")
            End If
            fc.desconectar()
        End If
    End Sub

    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
        Dim eliminar As Integer
        eliminar = MsgBox("¿Está seguro que desea eliminar esta consulta médica?", MsgBoxStyle.OkCancel, "Eliminar consulta médica")

        If eliminar = 1 Then
            If Me.cmbCodConsulta.Text.ToString <> "" Then
                ec._codConsulta = Me.cmbCodConsulta.Text

                Try
                    EXEerror = fc.eliminar(ec._codConsulta)
                    If Not EXEerror Then
                        MsgBox("Se ha eliminado correctamente la consulta médica.", MsgBoxStyle.OkOnly, "Eliminación corecta")
                    End If
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try

                If Not EXEerror Then
                    llenarCmb(Me.cmbCodConsulta, "CodConsulta", "Consulta")
                    limpiarControles(True)
                End If

            Else
                MsgBox("Es necesario elegir el código de la consulta para eliminar sus datos", MsgBoxStyle.Information, "No eligió la código de la consulta")
            End If
        End If
    End Sub
End Class