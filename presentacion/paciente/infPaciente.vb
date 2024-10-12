Imports entidad
Imports datos

Public Class infPaciente
    Dim fpdf As New Fpdf
    Dim fp As New Fpaciente
    Private Sub infPaciente_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.cmbCedula.Items.Add("Todos")
        llenarCmb(Me.cmbCedula, "CedulaPaciente", "Paciente", False)
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub btnVolver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVolver.Click
        menuPaciente.Show()
        Me.Close()
    End Sub

    Private Sub btnInforme_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInforme.Click

        If Me.cmbCedula.Text = "Todos" Then
            fpdf.iniciarPdf("Paciente", "Todos")
        Else
            fpdf.iniciarPdf("Paciente", "Una", cedulaPaciente:=Me.cmbCedula.Text)
        End If

        MsgBox("El archivo se encuentra en 'Documentos\Informe.pdf'. Cuidado, si desea realizar otro informe, mueva el archivo 'informe.pdf' o cámbiele el nombre.", MsgBoxStyle.Information, "Creación exitosa")
    End Sub

    Private Sub txtCedula_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCedula.Leave
        If Me.txtCedula.Text <> "" Then
            dt = fp.consultarRegistro("CedulaPaciente", Me.txtCedula.Text, "Paciente", True)

            If dt.Rows.Count > 0 Then
                Me.cmbCedula.SelectedItem = Me.txtCedula.Text
            End If
            fp.desconectar()
        End If
    End Sub

    Private Sub cmbCedula_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbCedula.SelectedValueChanged
        If Me.cmbCedula.Text <> "" Then
            If Me.cmbCedula.Text <> "Todos" Then
                dt = fp.consultarRegistro("CedulaPaciente", Me.cmbCedula.SelectedItem.ToString, "Paciente", True)

                If dt.Rows.Count > 0 Then
                    Me.txtCedula.Text = Me.cmbCedula.SelectedItem.ToString
                Else
                    MsgBox("La cédula del paciente ingresado no existe", MsgBoxStyle.Exclamation, "Ingrese otra cédula")
                End If
                fp.desconectar()
            Else
                Me.txtCedula.Text = Me.cmbCedula.SelectedItem.ToString
            End If
        End If
    End Sub
End Class