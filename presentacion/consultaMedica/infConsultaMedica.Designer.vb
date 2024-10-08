<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class infConsultaMedica
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(infConsultaMedica))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbCodConsulta = New System.Windows.Forms.ComboBox()
        Me.btnVolver = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnInforme = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.radioConsulta = New System.Windows.Forms.RadioButton()
        Me.radioFecha = New System.Windows.Forms.RadioButton()
        Me.radioMedico = New System.Windows.Forms.RadioButton()
        Me.radioPaciente = New System.Windows.Forms.RadioButton()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.fechaInicial = New System.Windows.Forms.DateTimePicker()
        Me.fechaFinal = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmbCedulaMedico = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cmbCedulaPaciente = New System.Windows.Forms.ComboBox()
        Me.radioConConsultaMedica = New System.Windows.Forms.RadioButton()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(40, 146)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(189, 32)
        Me.Label1.TabIndex = 109
        Me.Label1.Text = "Código de la Consulta" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(Médico-Paciente-fecha):"
        '
        'cmbCodConsulta
        '
        Me.cmbCodConsulta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCodConsulta.FormattingEnabled = True
        Me.cmbCodConsulta.Location = New System.Drawing.Point(43, 181)
        Me.cmbCodConsulta.Name = "cmbCodConsulta"
        Me.cmbCodConsulta.Size = New System.Drawing.Size(198, 23)
        Me.cmbCodConsulta.TabIndex = 108
        '
        'btnVolver
        '
        Me.btnVolver.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnVolver.Location = New System.Drawing.Point(154, 359)
        Me.btnVolver.Margin = New System.Windows.Forms.Padding(2)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(89, 37)
        Me.btnVolver.TabIndex = 107
        Me.btnVolver.Text = "Volver"
        Me.btnVolver.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Poor Richard", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(161, 24)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(265, 55)
        Me.Label3.TabIndex = 106
        Me.Label3.Text = "MedHistorias"
        '
        'btnSalir
        '
        Me.btnSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnSalir.Location = New System.Drawing.Point(45, 359)
        Me.btnSalir.Margin = New System.Windows.Forms.Padding(2)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(89, 37)
        Me.btnSalir.TabIndex = 105
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'btnInforme
        '
        Me.btnInforme.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnInforme.Location = New System.Drawing.Point(379, 359)
        Me.btnInforme.Margin = New System.Windows.Forms.Padding(2)
        Me.btnInforme.Name = "btnInforme"
        Me.btnInforme.Size = New System.Drawing.Size(153, 37)
        Me.btnInforme.TabIndex = 104
        Me.btnInforme.Text = "Realizar Reporte"
        Me.btnInforme.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(42, 218)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(97, 16)
        Me.Label2.TabIndex = 110
        Me.Label2.Text = "Fecha Inicial"
        '
        'radioConsulta
        '
        Me.radioConsulta.AutoSize = True
        Me.radioConsulta.Checked = True
        Me.radioConsulta.Location = New System.Drawing.Point(45, 112)
        Me.radioConsulta.Name = "radioConsulta"
        Me.radioConsulta.Size = New System.Drawing.Size(101, 20)
        Me.radioConsulta.TabIndex = 111
        Me.radioConsulta.TabStop = True
        Me.radioConsulta.Text = "Por Código"
        Me.radioConsulta.UseVisualStyleBackColor = True
        '
        'radioFecha
        '
        Me.radioFecha.AutoSize = True
        Me.radioFecha.Location = New System.Drawing.Point(171, 112)
        Me.radioFecha.Name = "radioFecha"
        Me.radioFecha.Size = New System.Drawing.Size(102, 20)
        Me.radioFecha.TabIndex = 112
        Me.radioFecha.Text = "Por Fechas"
        Me.radioFecha.UseVisualStyleBackColor = True
        '
        'radioMedico
        '
        Me.radioMedico.AutoSize = True
        Me.radioMedico.Location = New System.Drawing.Point(292, 112)
        Me.radioMedico.Name = "radioMedico"
        Me.radioMedico.Size = New System.Drawing.Size(103, 20)
        Me.radioMedico.TabIndex = 113
        Me.radioMedico.Text = "Por Médico"
        Me.radioMedico.UseVisualStyleBackColor = True
        '
        'radioPaciente
        '
        Me.radioPaciente.AutoSize = True
        Me.radioPaciente.Location = New System.Drawing.Point(419, 112)
        Me.radioPaciente.Name = "radioPaciente"
        Me.radioPaciente.Size = New System.Drawing.Size(113, 20)
        Me.radioPaciente.TabIndex = 114
        Me.radioPaciente.Text = "Por Paciente"
        Me.radioPaciente.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(42, 284)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(88, 16)
        Me.Label4.TabIndex = 115
        Me.Label4.Text = "Fecha Final"
        '
        'fechaInicial
        '
        Me.fechaInicial.Enabled = False
        Me.fechaInicial.Location = New System.Drawing.Point(43, 242)
        Me.fechaInicial.Name = "fechaInicial"
        Me.fechaInicial.Size = New System.Drawing.Size(200, 23)
        Me.fechaInicial.TabIndex = 116
        '
        'fechaFinal
        '
        Me.fechaFinal.Enabled = False
        Me.fechaFinal.Location = New System.Drawing.Point(45, 307)
        Me.fechaFinal.Name = "fechaFinal"
        Me.fechaFinal.Size = New System.Drawing.Size(200, 23)
        Me.fechaFinal.TabIndex = 117
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(321, 146)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(201, 16)
        Me.Label5.TabIndex = 119
        Me.Label5.Text = "Nombre del médico (Cédula)"
        '
        'cmbCedulaMedico
        '
        Me.cmbCedulaMedico.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCedulaMedico.Enabled = False
        Me.cmbCedulaMedico.FormattingEnabled = True
        Me.cmbCedulaMedico.Location = New System.Drawing.Point(324, 181)
        Me.cmbCedulaMedico.Name = "cmbCedulaMedico"
        Me.cmbCedulaMedico.Size = New System.Drawing.Size(198, 23)
        Me.cmbCedulaMedico.TabIndex = 118
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(42, 85)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(152, 16)
        Me.Label6.TabIndex = 120
        Me.Label6.Text = "Método de selección:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(321, 242)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(213, 16)
        Me.Label7.TabIndex = 121
        Me.Label7.Text = "Nombre del paciente (Cédula)"
        '
        'cmbCedulaPaciente
        '
        Me.cmbCedulaPaciente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCedulaPaciente.Enabled = False
        Me.cmbCedulaPaciente.FormattingEnabled = True
        Me.cmbCedulaPaciente.Location = New System.Drawing.Point(324, 277)
        Me.cmbCedulaPaciente.Name = "cmbCedulaPaciente"
        Me.cmbCedulaPaciente.Size = New System.Drawing.Size(198, 23)
        Me.cmbCedulaPaciente.TabIndex = 122
        '
        'radioConConsultaMedica
        '
        Me.radioConConsultaMedica.AutoSize = True
        Me.radioConConsultaMedica.Checked = True
        Me.radioConConsultaMedica.Location = New System.Drawing.Point(45, 112)
        Me.radioConConsultaMedica.Name = "radioConConsultaMedica"
        Me.radioConConsultaMedica.Size = New System.Drawing.Size(101, 20)
        Me.radioConConsultaMedica.TabIndex = 111
        Me.radioConConsultaMedica.TabStop = True
        Me.radioConConsultaMedica.Text = "Por Código"
        Me.radioConConsultaMedica.UseVisualStyleBackColor = True
        '
        'infConsultaMedica
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.GhostWhite
        Me.ClientSize = New System.Drawing.Size(574, 421)
        Me.Controls.Add(Me.cmbCedulaPaciente)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cmbCedulaMedico)
        Me.Controls.Add(Me.fechaFinal)
        Me.Controls.Add(Me.fechaInicial)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.radioPaciente)
        Me.Controls.Add(Me.radioMedico)
        Me.Controls.Add(Me.radioFecha)
        Me.Controls.Add(Me.radioConsulta)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmbCodConsulta)
        Me.Controls.Add(Me.btnVolver)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnInforme)
        Me.Font = New System.Drawing.Font("UD Digi Kyokasho NP-R", 10.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(580, 450)
        Me.MinimumSize = New System.Drawing.Size(580, 450)
        Me.Name = "infConsultaMedica"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reportes de Consultas Médicas"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmbCodConsulta As System.Windows.Forms.ComboBox
    Friend WithEvents btnVolver As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents btnInforme As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents radioConsulta As System.Windows.Forms.RadioButton
    Friend WithEvents radioFecha As System.Windows.Forms.RadioButton
    Friend WithEvents radioMedico As System.Windows.Forms.RadioButton
    Friend WithEvents radioPaciente As System.Windows.Forms.RadioButton
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents fechaInicial As System.Windows.Forms.DateTimePicker
    Friend WithEvents fechaFinal As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cmbCedulaMedico As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cmbCedulaPaciente As System.Windows.Forms.ComboBox
    Friend WithEvents radioConConsultaMedica As System.Windows.Forms.RadioButton
End Class
