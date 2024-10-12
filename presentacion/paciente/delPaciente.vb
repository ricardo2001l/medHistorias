Imports entidad
Imports datos

Public Class delPaciente
    Dim fp As New Fpaciente
    Dim ep As New Epaciente
    Dim EXEerror As Boolean
    Public dt As New DataTable



    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub btnVolver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVolver.Click
        menuPaciente.Show()
        Me.Close()
    End Sub

    Private Sub limpiarControles(Optional ByVal limpiarNombrUsuario As Boolean = True)
        ep._cedulaPaciente = ""
        ep._nombre = ""
        ep._apellido = ""
        ep._telefono = ""
        ep._email = ""
        ep._fechaDeNacimiento = Date.Today.ToString
        ep._Sexo = ""
        ep._residencia = ""

        Me.cmbCedula.Text = ep._cedulaPaciente
        Me.txtNombre.Text = ep._nombre
        Me.txtApellido.Text = ep._apellido
        Me.txtTelefono.Text = ep._telefono
        Me.txtCorreo.Text = ep._email
        Me.radioMasculino.Checked = False
        Me.radioFemenino.Checked = False
        Me.fechaNacimiento.Value = CDate(ep._fechaDeNacimiento)
        Me.txtResidencia.Text = ep._residencia
    End Sub

    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
        Dim eliminar As Integer
        eliminar = MsgBox("¿Está seguro que desea eliminar este paciente?", MsgBoxStyle.OkCancel, "Eliminar paciente")

        If eliminar = 1 Then
            If Me.cmbCedula.Text.ToString <> "" Then
                ep._cedulaPaciente = Me.cmbCedula.Text

                Try
                    EXEerror = fp.eliminar(ep._cedulaPaciente)
                    If Not EXEerror Then

                        MsgBox("Se ha eliminado correctamente el paciente.", MsgBoxStyle.OkOnly, "Eliminación corecta")

                    End If
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try

                If Not EXEerror Then
                    llenarCmb(Me.cmbCedula, "CedulaPaciente", "Paciente")
                    limpiarControles(True)
                End If

            Else
                MsgBox("Es necesario elegir la cédula para eliminar sus datos", MsgBoxStyle.Information, "No eligió la cédula del paciente")
            End If
        End If
    End Sub

    Private Sub cmbCedula_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbCedula.SelectedValueChanged
        If Me.cmbCedula.SelectedItem.ToString <> "" Then
            dt = fp.consultarRegistro("CedulaPaciente", Me.cmbCedula.SelectedItem.ToString, "Paciente", True)

            If dt.Rows.Count > 0 Then
                Me.txtCedula.Text = Me.cmbCedula.SelectedItem.ToString

                ep._nombre = dt(0)("Nombre").ToString
                ep._apellido = dt(0)("Apellido").ToString
                ep._telefono = dt(0)("Telefono").ToString
                ep._email = dt(0)("Email").ToString
                ep._fechaDeNacimiento = dt(0)("FechaDeNacimiento").ToString
                ep._Sexo = dt(0)("Sexo").ToString
                ep._residencia = dt(0)("Residencia").ToString


                Me.txtNombre.Text = ep._nombre
                Me.txtApellido.Text = ep._apellido
                Me.txtTelefono.Text = ep._telefono
                Me.txtCorreo.Text = ep._email
                Me.fechaNacimiento.Text = ep._fechaDeNacimiento
                Me.txtResidencia.Text = ep._residencia
                If ep._Sexo = "Masculino" Then
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
            fp.desconectar()
        End If
    End Sub

    Private Sub delPaciente_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        llenarCmb(Me.cmbCedula, "CedulaPaciente", "Paciente")
    End Sub

    Private Sub txtCedula_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCedula.Leave
        If Me.txtCedula.Text <> "" Then
            dt = fp.consultarRegistro("CedulaPaciente", Me.txtCedula.Text, "Paciente", True)

            If dt.Rows.Count > 0 Then

                Me.cmbCedula.SelectedItem = Me.txtCedula.Text
                ep._nombre = dt(0)("Nombre").ToString
                ep._apellido = dt(0)("Apellido").ToString
                ep._telefono = dt(0)("Telefono").ToString
                ep._email = dt(0)("Email").ToString
                ep._fechaDeNacimiento = dt(0)("FechaDeNacimiento").ToString
                ep._Sexo = dt(0)("Sexo").ToString
                ep._residencia = dt(0)("Residencia").ToString


                Me.txtNombre.Text = ep._nombre
                Me.txtApellido.Text = ep._apellido
                Me.txtTelefono.Text = ep._telefono
                Me.txtCorreo.Text = ep._email
                Me.fechaNacimiento.Text = ep._fechaDeNacimiento
                Me.txtResidencia.Text = ep._residencia
                If ep._Sexo = "Masculino" Then
                    Me.radioMasculino.Checked = True
                    Me.radioFemenino.Checked = False
                Else
                    Me.radioMasculino.Checked = False
                    Me.radioFemenino.Checked = True
                End If
            Else
                MsgBox("No se encontró el registro en la base de datos", MsgBoxStyle.Exclamation, "Ingrese otro identificador")
                limpiarControles()
            End If
            fp.desconectar()
        End If
    End Sub
End Class