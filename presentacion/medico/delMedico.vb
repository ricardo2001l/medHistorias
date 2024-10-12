Imports entidad
Imports datos

Public Class delMedico
    Dim fm As New Fmedico
    Dim em As New Emedico
    Dim EXEerror As Boolean
    Public dt As New DataTable
    Private Sub btnVolver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVolver.Click
        menuMedico.Show()
        Me.Close()
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub limpiarControles(Optional ByVal limpiarNombrUsuario As Boolean = True)
        em._cedulaMedico = ""
        em._nombre = ""
        em._apellido = ""
        em._telefono = ""
        em._email = ""
        em._fechaDeNacimiento = Date.Today.ToString
        em._fechaDeIngreso = Date.Today.ToString
        em._Sexo = ""
        em._CodPuesto = ""

        Me.cmbCedula.Text = em._cedulaMedico
        Me.txtNombre.Text = em._nombre
        Me.txtApellido.Text = em._apellido
        Me.txtTelefono.Text = em._telefono
        Me.txtCorreo.Text = em._email
        Me.radioMasculino.Checked = False
        Me.radioFemenino.Checked = False
        Me.fechaNacimiento.Value = CDate(em._fechaDeNacimiento)
        Me.fechaIngreso.Value = CDate(em._fechaDeIngreso)
        Me.cmbPuesto.Items.Add("")
        Me.cmbPuesto.Text = em._CodPuesto
    End Sub

    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
        Dim eliminar As Integer
        eliminar = MsgBox("¿Está seguro que desea eliminar este médico?", MsgBoxStyle.OkCancel, "Eliminar médico")

        If eliminar = 1 Then
            If Me.cmbCedula.Text.ToString <> "" Then
                em._cedulaMedico = Me.cmbCedula.Text

                Try
                    EXEerror = fm.eliminar(em._cedulaMedico)
                    If Not EXEerror Then
                        MsgBox("Se ha eliminado correctamente el médico.", MsgBoxStyle.OkOnly, "Eliminación correcta")
                    End If

                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try

                If Not EXEerror Then
                    llenarCmb(Me.cmbCedula, "CedulaMedico", "Medico")
                    limpiarControles(True)
                End If
            Else
                MsgBox("Es necesario elegir la cédula para eliminar sus datos", MsgBoxStyle.Information, "No eligió la cédula del médico")
            End If
        End If
    End Sub

    Private Sub delMedico_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        llenarCmb(Me.cmbPuesto, "CodPuesto", "Puesto")
        llenarCmb(Me.cmbCedula, "CedulaMedico", "Medico")
    End Sub

    Private Sub cmbCedula_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbCedula.SelectedValueChanged
        If Me.cmbCedula.SelectedItem.ToString <> "" Then
            dt = fm.consultarRegistro("CedulaMedico", Me.cmbCedula.SelectedItem.ToString, "Medico", True)

            If dt.Rows.Count > 0 Then
                Me.txtCedula.Text = Me.cmbCedula.SelectedItem.ToString

                em._nombre = dt(0)("Nombre").ToString
                em._apellido = dt(0)("Apellido").ToString
                em._telefono = dt(0)("Telefono").ToString
                em._email = dt(0)("Email").ToString
                em._fechaDeNacimiento = dt(0)("FechaDeNacimiento").ToString
                em._fechaDeIngreso = dt(0)("FechaDeIngreso").ToString
                em._Sexo = dt(0)("Sexo").ToString
                em._CodPuesto = dt(0)("CodPuesto").ToString


                Me.txtNombre.Text = em._nombre
                Me.txtApellido.Text = em._apellido
                Me.txtTelefono.Text = em._telefono
                Me.txtCorreo.Text = em._email
                Me.fechaNacimiento.Text = em._fechaDeNacimiento
                Me.fechaIngreso.Text = em._fechaDeIngreso
                Me.cmbPuesto.Text = em._CodPuesto
                If em._Sexo = "Masculino" Then
                    Me.radioMasculino.Checked = True
                    Me.radioFemenino.Checked = False
                Else
                    Me.radioMasculino.Checked = False
                    Me.radioFemenino.Checked = True
                End If
                Me.btnEliminar.Enabled = True
            Else
                Me.btnEliminar.Enabled = False
                MsgBox("No se encontró el registro en la base de datos", MsgBoxStyle.Exclamation, "Ingrese otro identificador")
            End If
            fm.desconectar()
        End If
    End Sub

    Private Sub txtCedula_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCedula.Leave
        If Me.txtCedula.Text <> "" Then
            dt = fm.consultarRegistro("CedulaMedico", Me.txtCedula.Text, "Medico", True)

            If dt.Rows.Count > 0 Then
                Me.cmbCedula.SelectedItem = Me.txtCedula.Text

                em._nombre = dt(0)("Nombre").ToString
                em._apellido = dt(0)("Apellido").ToString
                em._telefono = dt(0)("Telefono").ToString
                em._email = dt(0)("Email").ToString
                em._fechaDeNacimiento = dt(0)("FechaDeNacimiento").ToString
                em._fechaDeIngreso = dt(0)("FechaDeIngreso").ToString
                em._Sexo = dt(0)("Sexo").ToString
                em._CodPuesto = dt(0)("CodPuesto").ToString


                Me.txtNombre.Text = em._nombre
                Me.txtApellido.Text = em._apellido
                Me.txtTelefono.Text = em._telefono
                Me.txtCorreo.Text = em._email
                Me.fechaNacimiento.Text = em._fechaDeNacimiento
                Me.fechaIngreso.Text = em._fechaDeIngreso
                Me.cmbPuesto.Text = em._CodPuesto
                If em._Sexo = "Masculino" Then
                    Me.radioMasculino.Checked = True
                    Me.radioFemenino.Checked = False
                Else
                    Me.radioMasculino.Checked = False
                    Me.radioFemenino.Checked = True
                End If
                Me.btnEliminar.Enabled = True
            Else
                Me.btnEliminar.Enabled = False
                MsgBox("No se encontró el registro en la base de datos", MsgBoxStyle.Exclamation, "Ingrese otro identificador")
                limpiarControles()
            End If
            fm.desconectar()
        End If
    End Sub
End Class