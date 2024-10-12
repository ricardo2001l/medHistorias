Imports entidad
Imports datos
Public Class conMedico

    Dim fm As New Fmedico
    Dim em As New Emedico
    Public dt As New DataTable

    Private Sub btnVolver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVolver.Click
        menuMedico.Show()
        Me.Close()
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub conMedico_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.cmbCedula.Items.Add("Todos")
        llenarCmb(Me.cmbCedula, "CedulaMedico", "Medico", False)
    End Sub

    Private Sub btnConsultar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConsultar.Click
        If Me.txtCedula.Text <> "" Then



            em._cedulaMedico = Me.cmbCedula.Text
            If em._cedulaMedico = "Todos" Then
                dt = fm.consultar("Medico")
                dgvMedico.DataSource = dt
            Else
                dt = fm.consultarRegistro("CedulaMedico", Me.txtCedula.Text, "Medico", True)
                If dt.Rows.Count > 0 Then

                    dgvMedico.DataSource = dt

                Else
                    MsgBox("La cédula del médico ingresado no existe (Cambie texto del campo)", MsgBoxStyle.Exclamation, "Ingrese otra cédula")
                End If
                fm.desconectar()
            End If

        End If
    End Sub


    Private Sub txtCedula_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCedula.Leave
        If Me.txtCedula.Text <> "" Then
                dt = fm.consultarRegistro("CedulaMedico", Me.txtCedula.Text, "Medico", True)

                If dt.Rows.Count > 0 Then
                    Me.cmbCedula.SelectedItem = Me.txtCedula.Text
                End If
                fm.desconectar()
        End If
    End Sub

    Private Sub cmbCedula_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbCedula.SelectedValueChanged
        If Me.cmbCedula.Text <> "" Then
            If Me.cmbCedula.Text <> "Todos" Then
                dt = fm.consultarRegistro("CedulaMedico", Me.cmbCedula.SelectedItem.ToString, "Medico", True)

                If dt.Rows.Count > 0 Then
                    Me.txtCedula.Text = Me.cmbCedula.SelectedItem.ToString
                Else
                    MsgBox("La cédula del médico ingresado no existe", MsgBoxStyle.Exclamation, "Ingrese otra cédula")
                    Me.btnConsultar.Enabled = False
                End If
                fm.desconectar()
            Else
                Me.txtCedula.Text = Me.cmbCedula.SelectedItem.ToString
            End If
        End If
    End Sub
End Class