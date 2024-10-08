Public Class menuUsuario

    Private Sub btnAddUsuario_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddUsuario.Click
        addUsuario.Show()
        Me.Close()
    End Sub

    Private Sub btnModUsuario_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModUsuario.Click
        modUsuario.Show()
        Me.Close()
    End Sub

    Private Sub btnConUsuario_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConUsuario.Click
        conUsuario.Show()
        Me.Close()
    End Sub

    Private Sub btnDelUsuario_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelUsuario.Click
        delUsuario.Show()
        Me.Close()
    End Sub

    Private Sub btnVolver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVolver.Click
        mainMenu.Show()
        Me.Close()
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub
End Class