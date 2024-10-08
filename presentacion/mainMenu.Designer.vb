<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class mainMenu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(mainMenu))
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnUsuario = New System.Windows.Forms.Button()
        Me.btnMedico = New System.Windows.Forms.Button()
        Me.btnHistoriaMedica = New System.Windows.Forms.Button()
        Me.btnPaciente = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnAyuda = New System.Windows.Forms.Button()
        Me.btnBaseDatos = New System.Windows.Forms.Button()
        Me.btnConsultaMedica = New System.Windows.Forms.Button()
        Me.btnCerrarSesion = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Poor Richard", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(86, 19)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(265, 55)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "MedHistorias"
        '
        'btnUsuario
        '
        Me.btnUsuario.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnUsuario.Location = New System.Drawing.Point(19, 100)
        Me.btnUsuario.Margin = New System.Windows.Forms.Padding(2)
        Me.btnUsuario.Name = "btnUsuario"
        Me.btnUsuario.Size = New System.Drawing.Size(395, 35)
        Me.btnUsuario.TabIndex = 24
        Me.btnUsuario.Text = "Usuarios"
        Me.btnUsuario.UseVisualStyleBackColor = True
        '
        'btnMedico
        '
        Me.btnMedico.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnMedico.Location = New System.Drawing.Point(19, 152)
        Me.btnMedico.Margin = New System.Windows.Forms.Padding(2)
        Me.btnMedico.Name = "btnMedico"
        Me.btnMedico.Size = New System.Drawing.Size(194, 35)
        Me.btnMedico.TabIndex = 25
        Me.btnMedico.Text = "Médicos"
        Me.btnMedico.UseVisualStyleBackColor = True
        '
        'btnHistoriaMedica
        '
        Me.btnHistoriaMedica.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnHistoriaMedica.Location = New System.Drawing.Point(19, 201)
        Me.btnHistoriaMedica.Margin = New System.Windows.Forms.Padding(2)
        Me.btnHistoriaMedica.Name = "btnHistoriaMedica"
        Me.btnHistoriaMedica.Size = New System.Drawing.Size(194, 35)
        Me.btnHistoriaMedica.TabIndex = 27
        Me.btnHistoriaMedica.Text = "Historias Médicas"
        Me.btnHistoriaMedica.UseVisualStyleBackColor = True
        '
        'btnPaciente
        '
        Me.btnPaciente.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnPaciente.Location = New System.Drawing.Point(224, 152)
        Me.btnPaciente.Margin = New System.Windows.Forms.Padding(2)
        Me.btnPaciente.Name = "btnPaciente"
        Me.btnPaciente.Size = New System.Drawing.Size(190, 35)
        Me.btnPaciente.TabIndex = 26
        Me.btnPaciente.Text = "Pacientes"
        Me.btnPaciente.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnSalir.Location = New System.Drawing.Point(224, 354)
        Me.btnSalir.Margin = New System.Windows.Forms.Padding(2)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(190, 35)
        Me.btnSalir.TabIndex = 31
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'btnAyuda
        '
        Me.btnAyuda.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnAyuda.Location = New System.Drawing.Point(19, 302)
        Me.btnAyuda.Margin = New System.Windows.Forms.Padding(2)
        Me.btnAyuda.Name = "btnAyuda"
        Me.btnAyuda.Size = New System.Drawing.Size(395, 35)
        Me.btnAyuda.TabIndex = 30
        Me.btnAyuda.Text = "Ayuda"
        Me.btnAyuda.UseVisualStyleBackColor = True
        '
        'btnBaseDatos
        '
        Me.btnBaseDatos.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnBaseDatos.Location = New System.Drawing.Point(19, 252)
        Me.btnBaseDatos.Margin = New System.Windows.Forms.Padding(2)
        Me.btnBaseDatos.Name = "btnBaseDatos"
        Me.btnBaseDatos.Size = New System.Drawing.Size(395, 35)
        Me.btnBaseDatos.TabIndex = 29
        Me.btnBaseDatos.Text = "Base de datos"
        Me.btnBaseDatos.UseVisualStyleBackColor = True
        '
        'btnConsultaMedica
        '
        Me.btnConsultaMedica.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnConsultaMedica.Location = New System.Drawing.Point(224, 201)
        Me.btnConsultaMedica.Margin = New System.Windows.Forms.Padding(2)
        Me.btnConsultaMedica.Name = "btnConsultaMedica"
        Me.btnConsultaMedica.Size = New System.Drawing.Size(190, 35)
        Me.btnConsultaMedica.TabIndex = 28
        Me.btnConsultaMedica.Text = "Consultas Médicas"
        Me.btnConsultaMedica.UseVisualStyleBackColor = True
        '
        'btnCerrarSesion
        '
        Me.btnCerrarSesion.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCerrarSesion.Location = New System.Drawing.Point(19, 354)
        Me.btnCerrarSesion.Margin = New System.Windows.Forms.Padding(2)
        Me.btnCerrarSesion.Name = "btnCerrarSesion"
        Me.btnCerrarSesion.Size = New System.Drawing.Size(190, 35)
        Me.btnCerrarSesion.TabIndex = 32
        Me.btnCerrarSesion.Text = "Cerrar sesion"
        Me.btnCerrarSesion.UseVisualStyleBackColor = True
        '
        'mainMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.GhostWhite
        Me.CancelButton = Me.btnSalir
        Me.ClientSize = New System.Drawing.Size(444, 421)
        Me.Controls.Add(Me.btnCerrarSesion)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnAyuda)
        Me.Controls.Add(Me.btnBaseDatos)
        Me.Controls.Add(Me.btnConsultaMedica)
        Me.Controls.Add(Me.btnHistoriaMedica)
        Me.Controls.Add(Me.btnPaciente)
        Me.Controls.Add(Me.btnMedico)
        Me.Controls.Add(Me.btnUsuario)
        Me.Controls.Add(Me.Label3)
        Me.Font = New System.Drawing.Font("UD Digi Kyokasho NP-R", 10.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(450, 450)
        Me.MinimumSize = New System.Drawing.Size(450, 450)
        Me.Name = "mainMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Menú Principal"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnUsuario As System.Windows.Forms.Button
    Friend WithEvents btnMedico As System.Windows.Forms.Button
    Friend WithEvents btnHistoriaMedica As System.Windows.Forms.Button
    Friend WithEvents btnPaciente As System.Windows.Forms.Button
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents btnAyuda As System.Windows.Forms.Button
    Friend WithEvents btnBaseDatos As System.Windows.Forms.Button
    Friend WithEvents btnConsultaMedica As System.Windows.Forms.Button
    Friend WithEvents btnCerrarSesion As System.Windows.Forms.Button
End Class
