Public Class menuHistoriaMedica

    Private Sub btnAddHistoriaMedica_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddHistoriaMedica.Click
        addHistoriaMedica.Show()
        Me.Close()
    End Sub

    Private Sub btnModHistoriaMedica_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModHistoriaMedica.Click
        modHistoriaMedica.Show()
        Me.Close()
    End Sub

    Private Sub btnConHistoriaMedica_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConHistoriaMedica.Click
        conHistoriaMedica.Show()
        Me.Close()
    End Sub

    Private Sub btnDelHistoriaMedica_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        delHistoriaMedica.Show()
        Me.Close()
    End Sub

    Private Sub btnVolver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVolver.Click
        mainMenu.Show()
        Me.Close()
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub btnInfHistoriaMedica_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInfHistoriaMedica.Click
        infHistoriaMedica.Show()
        Me.Close()
    End Sub
End Class