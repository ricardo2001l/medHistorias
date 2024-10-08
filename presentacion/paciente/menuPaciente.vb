Public Class menuPaciente

    Private Sub btnAddPaciente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddPaciente.Click
        addPaciente.Show()
        Me.Close()
    End Sub

    Private Sub btnModPaciente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModPaciente.Click
        modPaciente.Show()
        Me.Close()
    End Sub

    Private Sub btnConPaciente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConPaciente.Click
        conPaciente.Show()
        Me.Close()
    End Sub

    Private Sub btnVolver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVolver.Click
        mainMenu.Show()
        Me.Close()
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub btnDelPaciente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelPaciente.Click
        delPaciente.Show()
        Me.Close()
    End Sub

    Private Sub btnInformes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInformes.Click
        infPaciente.Show()
        Me.Close()
    End Sub
End Class