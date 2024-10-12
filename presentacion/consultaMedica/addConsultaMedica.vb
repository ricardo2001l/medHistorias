Imports entidad
Imports datos

Public Class addConsultaMedica

    Dim fc As New FconsultaMedica
    Dim ec As New EconsultaMedica
    Dim EXEerror As Boolean
    Public dt As New DataTable

    Private Sub btnVolver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVolver.Click
        menuConsultaMedica.Show()
        Me.Close()
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

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

    Private Sub addConsultaMedica_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        llenarCmb(Me.cmbCedulaMedico, "CedulaMedico", "Medico")
        llenarCmb(Me.cmbCedulaPaciente, "CedulaPaciente", "Paciente")
    End Sub

    Private Sub btnAnadir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAnadir.Click
        If Me.cmbCedulaMedico.Text <> "" And Me.cmbCedulaPaciente.Text <> "" And Me.txtMotivo.Text <> "" And Me.txtPeso.Text <> "" And Me.txtAltura.Text <> "" And Me.txtSintomas.Text <> "" And Me.txtDiagnostico.Text <> "" Then
            ec._cedulaMedico = Me.cmbCedulaMedico.Text
            ec._cedulaPaciente = Me.cmbCedulaPaciente.Text
            Dim fecha As String
            If CInt(Me.fecha.Value.Day) <= 12 Then
                fecha = Me.fecha.Value.Day.ToString & "/" & Me.fecha.Value.Month.ToString & "/" & Me.fecha.Value.Year.ToString
            Else
                fecha = Me.fecha.Value.Month.ToString & "/" & Me.fecha.Value.Day.ToString & "/" & Me.fecha.Value.Year.ToString
            End If
            ec._fecha = fecha
            ec._motivo = Me.txtMotivo.Text
            ec._peso = Me.txtPeso.Text
            ec._altura = Me.txtAltura.Text
            ec._sintomas = Me.txtSintomas.Text
            ec._diagnostico = Me.txtDiagnostico.Text

            ec._codConsulta = ec._cedulaMedico + "-" + ec._cedulaPaciente + "-" + ec._fecha



            EXEerror = fc.agregar(ec._codConsulta, ec._cedulaMedico, ec._cedulaPaciente, ec._fecha, ec._motivo, ec._peso, ec._altura, ec._sintomas, ec._diagnostico)

            If Not EXEerror Then
                MsgBox("La consulta médica se ha agregado correctamente.", MsgBoxStyle.Information, "Ejecución correcta")
                limpiarControles(True)
            End If

        Else
            MsgBox("Tiene que llenar todos los campos para añadir una consulta médica", MsgBoxStyle.Critical, "Le falta un campo por llenar")
        End If
    End Sub

    Private Sub txtMotivo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtMotivo.KeyPress
        soloLetrasYEspacios(e)
    End Sub

    Private Sub txtPeso_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPeso.KeyPress
        soloNumerosLetrasYCaracteres(e)
    End Sub

    Private Sub txtAltura_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtAltura.KeyPress
        soloNumerosLetrasYCaracteres(e)
    End Sub
End Class