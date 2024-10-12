Imports entidad
Imports datos


Public Class conConsultaMedica
    Dim fc As New FconsultaMedica
    Dim ec As New EconsultaMedica
    Public dt As New DataTable
    Private Sub btnVolver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVolver.Click
        menuConsultaMedica.Show()
        Me.Close()
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub conConsultaMedica_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.cmbCodConsulta.Items.Add("Todos")
        llenarCmb(Me.cmbCodConsulta, "CodConsulta", "Consulta", False)
    End Sub

    Private Sub btnConsultar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConsultar.Click
        ec._codConsulta = Me.cmbCodConsulta.Text
        If ec._codConsulta = "Todos" Then
            dt = fc.consultar("Consulta")
            dgvConsultaMedica.DataSource = dt
        Else
            dt = fc.consultarRegistro("CodConsulta", ec._codConsulta, "Consulta", True)
            dgvConsultaMedica.DataSource = dt
        End If
    End Sub
End Class