Public Class menuMedico

    Private Sub btnAddMedico_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddMedico.Click
        addMedico.Show()
        Me.Close()
    End Sub

    Private Sub btnModMedico_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModMedico.Click
        modMedico.Show()
        Me.Close()
    End Sub

    Private Sub btnDelMedico_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelMedico.Click
        delMedico.Show()
        Me.Close()
    End Sub

    Private Sub btnVolver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVolver.Click
        mainMenu.Show()
        Me.Close()
    End Sub

    Private Sub btnConMedico_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConMedico.Click
        conMedico.Show()
        Me.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        puesto.Show()
        Me.Close()
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInformes.Click
        infMedico.Show()
        Me.Close()
    End Sub
End Class