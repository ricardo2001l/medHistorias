Public Class mainMenu
    Private Sub btnUsuario_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUsuario.Click
        menuUsuario.Show()
        Me.Close()
    End Sub

    Private Sub btnMedico_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMedico.Click
        menuMedico.Show()
        Me.Close()
    End Sub

    Private Sub btnBaseDatos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBaseDatos.Click
        baseDatos.Show()
        Me.Close()
    End Sub

    Private Sub btnPaciente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPaciente.Click
        menuPaciente.Show()
        Me.Close()
    End Sub

    Private Sub btnHistoriaMedica_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHistoriaMedica.Click
        menuHistoriaMedica.Show()
        Me.Close()
    End Sub

    Private Sub btnConsultaMedica_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConsultaMedica.Click
        menuConsultaMedica.Show()
        Me.Close()
    End Sub

    Private Sub btnAyuda_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAyuda.Click
        menuAyuda.Show()
        Me.Close()
    End Sub

    Private Sub btnCerrarSesion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrarSesion.Click
        iniciarSesion.Show()
        Me.Close()
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub mainMenu_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        If admin = "True" Then
            Me.btnBaseDatos.Enabled = True
            Me.btnMedico.Enabled = True
            Me.btnUsuario.Enabled = True
        ElseIf admin = "False" Then
            Me.btnBaseDatos.Enabled = False
            Me.btnMedico.Enabled = False
            Me.btnUsuario.Enabled = False
        End If


    End Sub
End Class