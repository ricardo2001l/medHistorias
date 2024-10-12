Imports entidad
Imports datos
Public Class conUsuario

    Dim fu As New Fusuario
    Dim eu As New Eusuario
    Public dt As New DataTable

    Private Sub btnVolver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVolver.Click
        menuUsuario.Show()
        Me.Close()
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub btnConsultar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConsultar.Click
        If Me.txtUsuario.Text <> "" Then



            eu._nombreUsuario = Me.txtUsuario.Text
            If eu._nombreUsuario = "Todos" Then
                dt = fu.consultar("Usuario")
                dgvUsuario.DataSource = dt
                dgvUsuario.Columns.Remove("Clave")
            Else
                dt = fu.consultarRegistro("NombreDeUsuario", Me.txtUsuario.Text, "Usuario", True)
                If dt.Rows.Count > 0 Then
                    dt = fu.consultarRegistro("NombreDeUsuario", eu._nombreUsuario, "Usuario", True)
                    dgvUsuario.DataSource = dt
                    dgvUsuario.Columns.Remove("Clave")
                Else
                    MsgBox("El nombre de usuario ingresado no existe (Cambie texto del campo)", MsgBoxStyle.Exclamation, "Ingrese otro usuario")
                End If
                fu.desconectar()
            End If


        End If
    End Sub

    Private Sub conUsuario_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.cmbNombreUsuario.Items.Add("Todos")
        llenarCmb(Me.cmbNombreUsuario, "NombreDeUsuario", "Usuario", False)
    End Sub

    Private Sub txtUsuario_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtUsuario.Leave
        If Me.txtUsuario.Text <> "" Then
            dt = fu.consultarRegistro("NombreDeUsuario", Me.txtUsuario.Text, "Usuario", True)

            If dt.Rows.Count > 0 Then
                Me.cmbNombreUsuario.SelectedItem = Me.txtUsuario.Text
            End If
            fu.desconectar()
        End If
    End Sub

    Private Sub cmbNombreUsuario_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbNombreUsuario.SelectedValueChanged
        If Me.cmbNombreUsuario.Text <> "" Then
            If Me.cmbNombreUsuario.Text <> "Todos" Then
                dt = fu.consultarRegistro("NombreDeUsuario", Me.cmbNombreUsuario.SelectedItem.ToString, "Usuario", True)

                If dt.Rows.Count > 0 Then
                    Me.txtUsuario.Text = Me.cmbNombreUsuario.SelectedItem.ToString
                Else
                    MsgBox("El nombre de usuario ingresado no existe", MsgBoxStyle.Exclamation, "Ingrese otro usuario")
                    Me.btnConsultar.Enabled = False
                End If
                fu.desconectar()
            Else
                Me.txtUsuario.Text = Me.cmbNombreUsuario.SelectedItem.ToString
            End If
        End If
    End Sub
End Class