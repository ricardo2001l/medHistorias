﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class addPaciente
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(addPaciente))
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnVolver = New System.Windows.Forms.Button()
        Me.radioFemenino = New System.Windows.Forms.RadioButton()
        Me.radioMasculino = New System.Windows.Forms.RadioButton()
        Me.fechaNacimiento = New System.Windows.Forms.DateTimePicker()
        Me.txtTelefono = New System.Windows.Forms.MaskedTextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtCorreo = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtApellido = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnAnadir = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtCedula = New System.Windows.Forms.TextBox()
        Me.txtResidencia = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(45, 365)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(149, 16)
        Me.Label10.TabIndex = 97
        Me.Label10.Text = "Lugar de residencia:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(332, 148)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(155, 16)
        Me.Label2.TabIndex = 95
        Me.Label2.Text = "Fecha de Nacimiento:"
        '
        'btnVolver
        '
        Me.btnVolver.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnVolver.Location = New System.Drawing.Point(154, 432)
        Me.btnVolver.Margin = New System.Windows.Forms.Padding(2)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(89, 37)
        Me.btnVolver.TabIndex = 94
        Me.btnVolver.Text = "Volver"
        Me.btnVolver.UseVisualStyleBackColor = True
        '
        'radioFemenino
        '
        Me.radioFemenino.AutoSize = True
        Me.radioFemenino.Location = New System.Drawing.Point(435, 253)
        Me.radioFemenino.Name = "radioFemenino"
        Me.radioFemenino.Size = New System.Drawing.Size(90, 20)
        Me.radioFemenino.TabIndex = 93
        Me.radioFemenino.TabStop = True
        Me.radioFemenino.Text = "Femenino"
        Me.radioFemenino.UseVisualStyleBackColor = True
        '
        'radioMasculino
        '
        Me.radioMasculino.AutoSize = True
        Me.radioMasculino.Location = New System.Drawing.Point(334, 253)
        Me.radioMasculino.Name = "radioMasculino"
        Me.radioMasculino.Size = New System.Drawing.Size(95, 20)
        Me.radioMasculino.TabIndex = 92
        Me.radioMasculino.TabStop = True
        Me.radioMasculino.Text = "Masculino"
        Me.radioMasculino.UseVisualStyleBackColor = True
        '
        'fechaNacimiento
        '
        Me.fechaNacimiento.Location = New System.Drawing.Point(334, 177)
        Me.fechaNacimiento.Name = "fechaNacimiento"
        Me.fechaNacimiento.Size = New System.Drawing.Size(198, 23)
        Me.fechaNacimiento.TabIndex = 91
        '
        'txtTelefono
        '
        Me.txtTelefono.Location = New System.Drawing.Point(47, 318)
        Me.txtTelefono.Mask = "0000-0000000"
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(197, 23)
        Me.txtTelefono.TabIndex = 90
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(331, 223)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(44, 16)
        Me.Label6.TabIndex = 89
        Me.Label6.Text = "Sexo:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(332, 87)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(138, 16)
        Me.Label8.TabIndex = 87
        Me.Label8.Text = "Correo electrónico:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(44, 289)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(72, 16)
        Me.Label9.TabIndex = 86
        Me.Label9.Text = "Telefono:"
        '
        'txtCorreo
        '
        Me.txtCorreo.Location = New System.Drawing.Point(334, 114)
        Me.txtCorreo.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtCorreo.Name = "txtCorreo"
        Me.txtCorreo.Size = New System.Drawing.Size(198, 23)
        Me.txtCorreo.TabIndex = 85
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(44, 223)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 16)
        Me.Label4.TabIndex = 84
        Me.Label4.Text = "Apellido:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(44, 148)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(64, 16)
        Me.Label5.TabIndex = 83
        Me.Label5.Text = "Nombre:"
        '
        'txtApellido
        '
        Me.txtApellido.Location = New System.Drawing.Point(46, 250)
        Me.txtApellido.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtApellido.Name = "txtApellido"
        Me.txtApellido.Size = New System.Drawing.Size(198, 23)
        Me.txtApellido.TabIndex = 82
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(45, 177)
        Me.txtNombre.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(198, 23)
        Me.txtNombre.TabIndex = 81
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Poor Richard", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(161, 21)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(265, 55)
        Me.Label3.TabIndex = 80
        Me.Label3.Text = "MedHistorias"
        '
        'btnSalir
        '
        Me.btnSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnSalir.Location = New System.Drawing.Point(45, 432)
        Me.btnSalir.Margin = New System.Windows.Forms.Padding(2)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(89, 37)
        Me.btnSalir.TabIndex = 79
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'btnAnadir
        '
        Me.btnAnadir.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnAnadir.Location = New System.Drawing.Point(425, 432)
        Me.btnAnadir.Margin = New System.Windows.Forms.Padding(2)
        Me.btnAnadir.Name = "btnAnadir"
        Me.btnAnadir.Size = New System.Drawing.Size(107, 37)
        Me.btnAnadir.TabIndex = 78
        Me.btnAnadir.Text = "Añadir"
        Me.btnAnadir.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(43, 85)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(149, 16)
        Me.Label1.TabIndex = 77
        Me.Label1.Text = "Cédula del paciente:"
        '
        'txtCedula
        '
        Me.txtCedula.Location = New System.Drawing.Point(45, 114)
        Me.txtCedula.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtCedula.Name = "txtCedula"
        Me.txtCedula.Size = New System.Drawing.Size(198, 23)
        Me.txtCedula.TabIndex = 76
        '
        'txtResidencia
        '
        Me.txtResidencia.Location = New System.Drawing.Point(45, 388)
        Me.txtResidencia.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtResidencia.Name = "txtResidencia"
        Me.txtResidencia.Size = New System.Drawing.Size(198, 23)
        Me.txtResidencia.TabIndex = 98
        '
        'addPaciente
        '
        Me.AcceptButton = Me.btnAnadir
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.GhostWhite
        Me.CancelButton = Me.btnVolver
        Me.ClientSize = New System.Drawing.Size(574, 491)
        Me.Controls.Add(Me.txtResidencia)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnVolver)
        Me.Controls.Add(Me.radioFemenino)
        Me.Controls.Add(Me.radioMasculino)
        Me.Controls.Add(Me.fechaNacimiento)
        Me.Controls.Add(Me.txtTelefono)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtCorreo)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtApellido)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnAnadir)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtCedula)
        Me.Font = New System.Drawing.Font("UD Digi Kyokasho NP-R", 10.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(580, 520)
        Me.MinimumSize = New System.Drawing.Size(580, 520)
        Me.Name = "addPaciente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Añadir un Paciente"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnVolver As System.Windows.Forms.Button
    Friend WithEvents radioFemenino As System.Windows.Forms.RadioButton
    Friend WithEvents radioMasculino As System.Windows.Forms.RadioButton
    Friend WithEvents fechaNacimiento As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtTelefono As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtCorreo As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtApellido As System.Windows.Forms.TextBox
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents btnAnadir As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtCedula As System.Windows.Forms.TextBox
    Friend WithEvents txtResidencia As System.Windows.Forms.TextBox
End Class
