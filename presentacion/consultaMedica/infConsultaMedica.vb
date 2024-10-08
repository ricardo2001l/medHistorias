Imports entidad
Imports datos

Public Class infConsultaMedica
    Dim fpdf As New Fpdf
    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub btnVolver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVolver.Click
        menuConsultaMedica.Show()
        Me.Close()
    End Sub

    Private Sub infConsultaMedica_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.cmbCodConsulta.Items.Add("Todos")
        llenarCmb(Me.cmbCodConsulta, "CodConsulta", "Consulta", False)
        llenarCmb(Me.cmbCedulaMedico, "CedulaMedico", "Medico")
        llenarCmb(Me.cmbCedulaPaciente, "CedulaPaciente", "Paciente")
    End Sub

    Private Sub radioConsulta_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles radioConsulta.CheckedChanged
        If Me.radioConsulta.Checked Then
            Me.cmbCodConsulta.Enabled = True
            Me.fechaInicial.Enabled = False
            Me.fechaFinal.Enabled = False
            Me.cmbCedulaMedico.Enabled = False
            Me.cmbCedulaPaciente.Enabled = False
        End If
    End Sub

    Private Sub radioFecha_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles radioFecha.CheckedChanged
        If Me.radioFecha.Checked Then
            Me.cmbCodConsulta.Enabled = False
            Me.fechaInicial.Enabled = True
            Me.fechaFinal.Enabled = True
            Me.cmbCedulaMedico.Enabled = False
            Me.cmbCedulaPaciente.Enabled = False
        End If
    End Sub

    Private Sub radioMedico_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles radioMedico.CheckedChanged
        If Me.radioMedico.Checked Then
            Me.cmbCodConsulta.Enabled = False
            Me.fechaInicial.Enabled = False
            Me.fechaFinal.Enabled = False
            Me.cmbCedulaMedico.Enabled = True
            Me.cmbCedulaPaciente.Enabled = False
        End If
    End Sub

    Private Sub radioPaciente_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles radioPaciente.CheckedChanged
        If Me.radioPaciente.Checked Then
            Me.cmbCodConsulta.Enabled = False
            Me.fechaInicial.Enabled = False
            Me.fechaFinal.Enabled = False
            Me.cmbCedulaMedico.Enabled = False
            Me.cmbCedulaPaciente.Enabled = True
        End If
    End Sub

    Private Sub btnInforme_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInforme.Click
        If Me.radioConsulta.Checked Then
            If Me.cmbCodConsulta.Text = "Todos" Then
                fpdf.iniciarPdf("ConsultaMedica", "Todos")
            Else
                fpdf.iniciarPdf("ConsultaMedica", "Una", codConsultaMedica:=Me.cmbCodConsulta.Text)
            End If
        ElseIf Me.radioFecha.Checked Then
            Dim fechai, fechaf As String
            If CInt(Me.fechaInicial.Value.Day) <= 12 Then
                fechai = Me.fechaInicial.Value.Day.ToString & "/" & Me.fechaInicial.Value.Month.ToString & "/" & Me.fechaInicial.Value.Year.ToString
            Else
                fechai = Me.fechaInicial.Value.Month.ToString & "/" & Me.fechaInicial.Value.Day.ToString & "/" & Me.fechaInicial.Value.Year.ToString
            End If
            If CInt(Me.fechaFinal.Value.Day) <= 12 Then
                fechaf = Me.fechaFinal.Value.Day.ToString & "/" & Me.fechaFinal.Value.Month.ToString & "/" & Me.fechaFinal.Value.Year.ToString
            Else
                fechaf = Me.fechaFinal.Value.Month.ToString & "/" & Me.fechaFinal.Value.Day.ToString & "/" & Me.fechaFinal.Value.Year.ToString
            End If
            'Dim finicial = Me.fechaInicial.Value.Day.ToString + "/" + Me.fechaInicial.Value.Month.ToString + "/" + Me.fechaInicial.Value.Year.ToString
            'Dim ffinal = Me.fechaFinal.Value.Day.ToString + "/" + Me.fechaFinal.Value.Month.ToString + "/" + Me.fechaFinal.Value.Year.ToString
            fpdf.iniciarPdf("ConsultaMedica", "Fechas", fechaInicial:=fechai, fechaFinal:=fechaf)
        ElseIf Me.radioMedico.Checked Then
            fpdf.iniciarPdf("ConsultaMedica", "Medico", cedulaMedico:=Me.cmbCedulaMedico.Text)
        ElseIf Me.radioPaciente.Checked Then
            fpdf.iniciarPdf("ConsultaMedica", "Paciente", cedulaPaciente:=Me.cmbCedulaPaciente.Text)
        End If

        MsgBox("El archivo se encuentra en 'Documentos\Informe.pdf'. Cuidado, si desea realizar otro informe, mueva el archivo 'informe.pdf' o cámbiele el nombre.", MsgBoxStyle.Information, "Creación exitosa")
    End Sub
End Class