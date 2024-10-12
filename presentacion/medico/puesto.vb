Imports entidad
Imports datos

Public Class puesto

    Dim fp As New Fpuesto
    Dim ep As New Epuesto
    Public dt As New DataTable

    Private Sub btnVolver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVolver.Click
        menuMedico.Show()
        Me.Close()
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub puesto_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        llenarCmb(Me.cmbPuesto, "CodPuesto", "Puesto")
    End Sub

    Private Sub limpiarControles(Optional ByVal limpiarNombrUsuario As Boolean = True)
        ep._codPuesto = ""
        ep._nombre = ""
        ep._descripcion = ""
        ep._sueldo = ""

        Me.txtPuesto.Text = ep._codPuesto
        Me.txtDescripcion.Text = ep._descripcion
        Me.txtSueldo.Text = ep._sueldo
        Me.cmbPuesto.Items.Add("")
        Me.cmbPuesto.Text = ep._codPuesto
    End Sub

    Private Sub btnAnadir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAnadir.Click
        If Me.txtPuesto.Text <> "" And Me.txtDescripcion.Text <> "" And Me.txtSueldo.Text <> "" Then
            If (Me.txtDescripcion.TextLength <= 254) Then
                ep._codPuesto = Me.txtPuesto.Text
                ep._nombre = ep._codPuesto
                ep._descripcion = Me.txtDescripcion.Text
                ep._sueldo = Me.txtSueldo.Text

                fp.agregar(ep._codPuesto, ep._nombre, ep._descripcion, ep._sueldo)

                MsgBox("El puesto se ha agregado correctamente.", MsgBoxStyle.Information, "Ejecución correcta")
                limpiarControles(True)
                llenarCmb(Me.cmbPuesto, "CodPuesto", "Puesto")
            Else
                MsgBox("La descripción no puede ser mayor a 254 caracteres", MsgBoxStyle.Information, "Error")
            End If
        Else
            MsgBox("Tiene que llenar todos los campos para añadir un puesto", MsgBoxStyle.Critical, "Le falta un campo por llenar")
        End If
    End Sub

    Private Sub checkAnadir_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles checkAnadir.CheckedChanged
        If Me.checkAnadir.Checked Then
            Me.txtPuesto.Enabled = True
            Me.cmbPuesto.Enabled = False
            Me.txtDescripcion.Enabled = True
            Me.txtSueldo.Enabled = True

            Me.btnAnadir.Enabled = True
            Me.btnModificar.Enabled = False
            Me.btnConsultar.Enabled = True
            Me.btnEliminar.Enabled = False
        Else
            Me.cmbPuesto.Enabled = True
            Me.txtPuesto.Enabled = False
            Me.txtDescripcion.Enabled = True
            Me.txtSueldo.Enabled = True

            Me.btnAnadir.Enabled = False
            Me.btnModificar.Enabled = True
            Me.btnConsultar.Enabled = True
            Me.btnEliminar.Enabled = True
        End If
    End Sub

    Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click
        If Me.cmbPuesto.Text <> "" And Me.txtDescripcion.Text <> "" And Me.txtSueldo.Text <> "" Then
            ep._codPuesto = Me.cmbPuesto.Text
            ep._nombre = ep._codPuesto
            ep._descripcion = Me.txtDescripcion.Text
            ep._sueldo = Me.txtSueldo.Text

            fp.modificar(ep._codPuesto, ep._nombre, ep._descripcion, ep._sueldo)

            MsgBox("El puesto de trabajo se ha modificado correctamente.", MsgBoxStyle.Information, "Ejecución correcta")
            limpiarControles(True)
        Else
            MsgBox("Tiene que llenar todos los campos para modificar un puesto de trabajo", MsgBoxStyle.Critical, "Le falta un campo por llenar")
        End If
    End Sub

    Private Sub cmbPuesto_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbPuesto.SelectedValueChanged
        If Me.cmbPuesto.SelectedItem.ToString <> "" Then
            dt = fp.consultarRegistro("CodPuesto", Me.cmbPuesto.SelectedItem.ToString, "Puesto", True)

            If dt.Rows.Count > 0 Then

                ep._nombre = dt(0)("Nombre").ToString
                ep._descripcion = dt(0)("Descripcion").ToString
                ep._sueldo = dt(0)("Sueldo").ToString


                Me.txtDescripcion.Text = ep._descripcion
                Me.txtSueldo.Text = ep._sueldo
            Else
                MsgBox("No se encontró el registro en la base de datos", MsgBoxStyle.Exclamation, "Ingrese otro identificador")
            End If
            fp.desconectar()
        End If
    End Sub

    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
        Dim eliminar As Integer
        eliminar = MsgBox("¿Está seguro que desea eliminar este puesto?", MsgBoxStyle.OkCancel, "Eliminar puesto de trabajo")

        If eliminar = 1 Then
            If Me.cmbPuesto.Text.ToString <> "" Then
                ep._codPuesto = Me.cmbPuesto.Text

                Try
                    fp.eliminar(ep._codPuesto)
                    MsgBox("Se ha eliminado correctamente el puesto.", MsgBoxStyle.OkOnly, "Eliminación corecta")

                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try


                llenarCmb(Me.cmbPuesto, "CodPuesto", "Puesto")
                limpiarControles(True)
            Else
                MsgBox("Es necesario elegir el puesto para eliminar sus datos", MsgBoxStyle.Information, "No eligió el puesto de trabajo")
            End If
        End If
    End Sub

    Private Sub btnConsultar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConsultar.Click
        conPuesto.Show()
        Me.Close()
    End Sub


    Private Sub txtPuesto_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPuesto.KeyPress
        soloLetrasYEspacios(e)
    End Sub

    Private Sub txtSueldo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtSueldo.KeyPress
        soloNumerosPuntos(e)
    End Sub
End Class