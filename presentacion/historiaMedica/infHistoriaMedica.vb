Imports entidad
Imports datos

Public Class infHistoriaMedica
    Dim fpdf As New Fpdf
    Dim fh As New FhistoriaMedica
    Private Sub btnInforme_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInforme.Click
        If Me.cmbCedula.Text = "Todos" Then
            fpdf.iniciarPdf("HistoriaMedica", "Todos")
        Else
            fpdf.iniciarPdf("HistoriaMedica", "Una", cedulaPaciente:=Me.cmbCedula.Text)
        End If

        MsgBox("El archivo se encuentra en 'Documentos\Informe.pdf'. Cuidado, si desea realizar otro informe, mueva el archivo 'informe.pdf' o cámbiele el nombre.", MsgBoxStyle.Information, "Creación exitosa")
    End Sub

    Private Sub infHistoriaMedica_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.cmbCedula.Items.Add("Todos")
        llenarCmb(Me.cmbCedula, "CedulaPaciente", "HistoriaMedica", False)
    End Sub


    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub btnVolver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVolver.Click
        menuHistoriaMedica.Show()
        Me.Close()
    End Sub

    Private Sub txtCedula_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCedula.Leave
        If Me.txtCedula.Text <> "" Then
            dt = fh.consultarRegistro("CedulaPaciente", Me.txtCedula.Text, "HistoriaMedica", True)

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

                End If
                fh.desconectar()
            Else
                Me.txtCedula.Text = Me.cmbCedula.SelectedItem.ToString
            End If
        End If
    End Sub
End Class