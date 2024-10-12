Imports entidad
Imports datos

Public Class conPuesto

    Dim fp As New Fpuesto
    Dim ep As New Epuesto
    Public dt As New DataTable

    Private Sub btnConsultar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConsultar.Click
        ep._nombre = Me.cmbPuesto.Text
        If ep._nombre = "Todos" Then
            dt = fp.consultar("Puesto")
            dgvPuesto.DataSource = dt
        Else
            dt = fp.consultarRegistro("CodPuesto", ep._nombre, "Puesto", True)
            dgvPuesto.DataSource = dt
        End If
    End Sub

    Private Sub btnVolver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVolver.Click
        puesto.Show()
        Me.Close()
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub conPuesto_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.cmbPuesto.Items.Add("Todos")
        llenarCmb(Me.cmbPuesto, "Nombre", "Puesto", False)
    End Sub
End Class