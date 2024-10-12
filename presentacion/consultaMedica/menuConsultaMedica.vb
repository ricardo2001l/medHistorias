Public Class menuConsultaMedica

    Private Sub btnAddConsultaMedica_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddConsultaMedica.Click
        addConsultaMedica.Show()
        Me.Close()
    End Sub

    Private Sub btnModConsultaMedica_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModConsultaMedica.Click
        modConsultaMedica.Show()
        Me.Close()
    End Sub

    Private Sub btnConConsultaMedica_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConConsultaMedica.Click
        conConsultaMedica.Show()
        Me.Close()
    End Sub

    Private Sub btnDelConsultaMedica_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelConsultaMedica.Click
        delConsultaMedica.Show()
        Me.Close()
    End Sub

    Private Sub btnVolver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVolver.Click
        mainMenu.Show()
        Me.Close()
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub btnInfConsultaMedica_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInfConsultaMedica.Click
        infConsultaMedica.Show()
        Me.Close()
    End Sub
End Class