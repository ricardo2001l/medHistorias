Imports entidad
Imports datos

Public Class conHistoriaMedica

    Dim fh As New FhistoriaMedica
    Dim eh As New EhistoriaMedica
    Public dt As New DataTable

    Private Sub btnVolver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVolver.Click
        menuHistoriaMedica.Show()
        Me.Close()
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub conHistoriaMedica_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.cmbCedula.Items.Add("Todos")
        llenarCmb(Me.cmbCedula, "CodHistoriaMedica", "HistoriaMedica", False)
    End Sub

    Private Sub btnConsultar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConsultar.Click
        If Me.txtCedula.Text <> "" Then



            eh._codHistoria = Me.cmbCedula.Text
            If eh._codHistoria = "Todos" Then
                dt = fh.consultar("HistoriaMedica", True)
                dgvHistoriaMedica.DataSource = dt
            Else
                dt = fh.consultarRegistro("CodHistoriaMedica", Me.txtCedula.Text, "HistoriaMedica", True)
                If dt.Rows.Count > 0 Then
                    dgvHistoriaMedica.DataSource = dt
                Else
                    MsgBox("La cédula del paciente ingresado no existe (Cambie texto del campo)", MsgBoxStyle.Exclamation, "Ingrese otra cédula")
                End If
                fh.desconectar()
            End If
        End If
    End Sub

    Private Sub txtCedula_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCedula.Leave
        If Me.txtCedula.Text <> "" Then
                dt = fh.consultarRegistro("CodHistoriaMedica", Me.txtCedula.Text, "HistoriaMedica", True)

                If dt.Rows.Count > 0 Then
                    Me.cmbCedula.SelectedItem = Me.txtCedula.Text
                End If
                fh.desconectar()
        End If
    End Sub

    Private Sub cmbCedula_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbCedula.SelectedValueChanged
        If Me.cmbCedula.Text <> "" Then
            If Me.cmbCedula.Text <> "Todos" Then
                dt = fh.consultarRegistro("CodHistoriaMedica", Me.cmbCedula.SelectedItem.ToString, "HistoriaMedica", True)

                If dt.Rows.Count > 0 Then
                    Me.txtCedula.Text = Me.cmbCedula.SelectedItem.ToString
                Else
                    MsgBox("La cédula del paciente ingresado no existe", MsgBoxStyle.Exclamation, "Ingrese otra cédula")
                    Me.btnConsultar.Enabled = False
                End If
                fh.desconectar()
            Else
                Me.txtCedula.Text = Me.cmbCedula.SelectedItem.ToString
            End If
        End If
    End Sub
End Class