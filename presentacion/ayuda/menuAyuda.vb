Public Class menuAyuda

    Private Sub btnAcercaDe_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAcercaDe.Click
        If Not (acercaDe.Created) Then
            acercaDe.Show()
        End If
    End Sub

    Private Sub btnVolver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVolver.Click
        mainMenu.Show()
        Me.Close()
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub btnManual_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnManual.Click
        Process.Start("manual.pdf")
    End Sub
End Class