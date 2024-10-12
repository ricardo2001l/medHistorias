<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class addConsultaMedica
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(addConsultaMedica))
        Me.txtPeso = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnVolver = New System.Windows.Forms.Button()
        Me.fecha = New System.Windows.Forms.DateTimePicker()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtAltura = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtSintomas = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnAnadir = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtMotivo = New System.Windows.Forms.TextBox()
        Me.txtDiagnostico = New System.Windows.Forms.TextBox()
        Me.cmbCedulaMedico = New System.Windows.Forms.ComboBox()
        Me.cmbCedulaPaciente = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'txtPeso
        '
        Me.txtPeso.Location = New System.Drawing.Point(40, 383)
        Me.txtPeso.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtPeso.Name = "txtPeso"
        Me.txtPeso.Size = New System.Drawing.Size(198, 23)
        Me.txtPeso.TabIndex = 121
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(40, 360)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(44, 16)
        Me.Label10.TabIndex = 120
        Me.Label10.Text = "Peso:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(327, 143)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 16)
        Me.Label2.TabIndex = 118
        Me.Label2.Text = "Sintomas:"
        '
        'btnVolver
        '
        Me.btnVolver.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnVolver.Location = New System.Drawing.Point(149, 427)
        Me.btnVolver.Margin = New System.Windows.Forms.Padding(2)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(89, 37)
        Me.btnVolver.TabIndex = 117
        Me.btnVolver.Text = "Volver"
        Me.btnVolver.UseVisualStyleBackColor = True
        '
        'fecha
        '
        Me.fecha.Location = New System.Drawing.Point(40, 242)
        Me.fecha.Name = "fecha"
        Me.fecha.Size = New System.Drawing.Size(198, 23)
        Me.fecha.TabIndex = 114
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(327, 250)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(94, 16)
        Me.Label7.TabIndex = 111
        Me.Label7.Text = "Diagnóstico:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(327, 82)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(55, 16)
        Me.Label8.TabIndex = 110
        Me.Label8.Text = "Altura:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(39, 284)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(58, 16)
        Me.Label9.TabIndex = 109
        Me.Label9.Text = "Motivo:"
        '
        'txtAltura
        '
        Me.txtAltura.Location = New System.Drawing.Point(329, 109)
        Me.txtAltura.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtAltura.Name = "txtAltura"
        Me.txtAltura.Size = New System.Drawing.Size(198, 23)
        Me.txtAltura.TabIndex = 108
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(39, 218)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(154, 16)
        Me.Label4.TabIndex = 107
        Me.Label4.Text = "Fecha de la consulta:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(39, 143)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(137, 16)
        Me.Label5.TabIndex = 106
        Me.Label5.Text = "Cédula del médico:"
        '
        'txtSintomas
        '
        Me.txtSintomas.Location = New System.Drawing.Point(329, 172)
        Me.txtSintomas.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtSintomas.Multiline = True
        Me.txtSintomas.Name = "txtSintomas"
        Me.txtSintomas.Size = New System.Drawing.Size(198, 62)
        Me.txtSintomas.TabIndex = 105
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Poor Richard", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(156, 16)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(265, 55)
        Me.Label3.TabIndex = 103
        Me.Label3.Text = "MedHistorias"
        '
        'btnSalir
        '
        Me.btnSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnSalir.Location = New System.Drawing.Point(40, 427)
        Me.btnSalir.Margin = New System.Windows.Forms.Padding(2)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(89, 37)
        Me.btnSalir.TabIndex = 102
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'btnAnadir
        '
        Me.btnAnadir.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnAnadir.Location = New System.Drawing.Point(420, 427)
        Me.btnAnadir.Margin = New System.Windows.Forms.Padding(2)
        Me.btnAnadir.Name = "btnAnadir"
        Me.btnAnadir.Size = New System.Drawing.Size(107, 37)
        Me.btnAnadir.TabIndex = 101
        Me.btnAnadir.Text = "Añadir"
        Me.btnAnadir.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(38, 80)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(149, 16)
        Me.Label1.TabIndex = 100
        Me.Label1.Text = "Cédula del paciente:"
        '
        'txtMotivo
        '
        Me.txtMotivo.Location = New System.Drawing.Point(40, 316)
        Me.txtMotivo.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtMotivo.Name = "txtMotivo"
        Me.txtMotivo.Size = New System.Drawing.Size(198, 23)
        Me.txtMotivo.TabIndex = 122
        '
        'txtDiagnostico
        '
        Me.txtDiagnostico.Location = New System.Drawing.Point(329, 284)
        Me.txtDiagnostico.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtDiagnostico.Multiline = True
        Me.txtDiagnostico.Name = "txtDiagnostico"
        Me.txtDiagnostico.Size = New System.Drawing.Size(198, 68)
        Me.txtDiagnostico.TabIndex = 123
        '
        'cmbCedulaMedico
        '
        Me.cmbCedulaMedico.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCedulaMedico.FormattingEnabled = True
        Me.cmbCedulaMedico.Location = New System.Drawing.Point(43, 179)
        Me.cmbCedulaMedico.Name = "cmbCedulaMedico"
        Me.cmbCedulaMedico.Size = New System.Drawing.Size(198, 23)
        Me.cmbCedulaMedico.TabIndex = 150
        '
        'cmbCedulaPaciente
        '
        Me.cmbCedulaPaciente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCedulaPaciente.FormattingEnabled = True
        Me.cmbCedulaPaciente.Location = New System.Drawing.Point(43, 109)
        Me.cmbCedulaPaciente.Name = "cmbCedulaPaciente"
        Me.cmbCedulaPaciente.Size = New System.Drawing.Size(198, 23)
        Me.cmbCedulaPaciente.TabIndex = 149
        '
        'addConsultaMedica
        '
        Me.AcceptButton = Me.btnAnadir
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.GhostWhite
        Me.CancelButton = Me.btnVolver
        Me.ClientSize = New System.Drawing.Size(574, 491)
        Me.Controls.Add(Me.cmbCedulaMedico)
        Me.Controls.Add(Me.cmbCedulaPaciente)
        Me.Controls.Add(Me.txtDiagnostico)
        Me.Controls.Add(Me.txtMotivo)
        Me.Controls.Add(Me.txtPeso)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnVolver)
        Me.Controls.Add(Me.fecha)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtAltura)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtSintomas)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnAnadir)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("UD Digi Kyokasho NP-R", 10.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(580, 520)
        Me.MinimumSize = New System.Drawing.Size(580, 520)
        Me.Name = "addConsultaMedica"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Añadir una Consulta Médica"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtPeso As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnVolver As System.Windows.Forms.Button
    Friend WithEvents fecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtAltura As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtSintomas As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents btnAnadir As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtMotivo As System.Windows.Forms.TextBox
    Friend WithEvents txtDiagnostico As System.Windows.Forms.TextBox
    Friend WithEvents cmbCedulaMedico As System.Windows.Forms.ComboBox
    Friend WithEvents cmbCedulaPaciente As System.Windows.Forms.ComboBox
End Class
