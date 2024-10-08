<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class menuPaciente
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(menuPaciente))
        Me.btnDelPaciente = New System.Windows.Forms.Button()
        Me.btnVolver = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnConPaciente = New System.Windows.Forms.Button()
        Me.btnModPaciente = New System.Windows.Forms.Button()
        Me.btnAddPaciente = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnInformes = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnDelPaciente
        '
        Me.btnDelPaciente.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnDelPaciente.Location = New System.Drawing.Point(23, 254)
        Me.btnDelPaciente.Margin = New System.Windows.Forms.Padding(2)
        Me.btnDelPaciente.Name = "btnDelPaciente"
        Me.btnDelPaciente.Size = New System.Drawing.Size(395, 35)
        Me.btnDelPaciente.TabIndex = 58
        Me.btnDelPaciente.Text = "Eliminar Pacientes"
        Me.btnDelPaciente.UseVisualStyleBackColor = True
        '
        'btnVolver
        '
        Me.btnVolver.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnVolver.Location = New System.Drawing.Point(228, 360)
        Me.btnVolver.Margin = New System.Windows.Forms.Padding(2)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(190, 35)
        Me.btnVolver.TabIndex = 57
        Me.btnVolver.Text = "Volver"
        Me.btnVolver.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnSalir.Location = New System.Drawing.Point(23, 360)
        Me.btnSalir.Margin = New System.Windows.Forms.Padding(2)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(190, 35)
        Me.btnSalir.TabIndex = 56
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'btnConPaciente
        '
        Me.btnConPaciente.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnConPaciente.Location = New System.Drawing.Point(23, 203)
        Me.btnConPaciente.Margin = New System.Windows.Forms.Padding(2)
        Me.btnConPaciente.Name = "btnConPaciente"
        Me.btnConPaciente.Size = New System.Drawing.Size(395, 35)
        Me.btnConPaciente.TabIndex = 55
        Me.btnConPaciente.Text = "Consultar Pacientes"
        Me.btnConPaciente.UseVisualStyleBackColor = True
        '
        'btnModPaciente
        '
        Me.btnModPaciente.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnModPaciente.Location = New System.Drawing.Point(23, 151)
        Me.btnModPaciente.Margin = New System.Windows.Forms.Padding(2)
        Me.btnModPaciente.Name = "btnModPaciente"
        Me.btnModPaciente.Size = New System.Drawing.Size(395, 35)
        Me.btnModPaciente.TabIndex = 54
        Me.btnModPaciente.Text = "Modificar Pacientes"
        Me.btnModPaciente.UseVisualStyleBackColor = True
        '
        'btnAddPaciente
        '
        Me.btnAddPaciente.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnAddPaciente.Location = New System.Drawing.Point(23, 101)
        Me.btnAddPaciente.Margin = New System.Windows.Forms.Padding(2)
        Me.btnAddPaciente.Name = "btnAddPaciente"
        Me.btnAddPaciente.Size = New System.Drawing.Size(395, 35)
        Me.btnAddPaciente.TabIndex = 53
        Me.btnAddPaciente.Text = "Añadir Pacientes"
        Me.btnAddPaciente.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Poor Richard", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(90, 20)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(265, 55)
        Me.Label3.TabIndex = 52
        Me.Label3.Text = "MedHistorias"
        '
        'btnInformes
        '
        Me.btnInformes.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnInformes.Location = New System.Drawing.Point(23, 304)
        Me.btnInformes.Margin = New System.Windows.Forms.Padding(2)
        Me.btnInformes.Name = "btnInformes"
        Me.btnInformes.Size = New System.Drawing.Size(395, 35)
        Me.btnInformes.TabIndex = 59
        Me.btnInformes.Text = "Reportes sobre Pacientes"
        Me.btnInformes.UseVisualStyleBackColor = True
        '
        'menuPaciente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.GhostWhite
        Me.CancelButton = Me.btnVolver
        Me.ClientSize = New System.Drawing.Size(444, 421)
        Me.Controls.Add(Me.btnInformes)
        Me.Controls.Add(Me.btnDelPaciente)
        Me.Controls.Add(Me.btnVolver)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnConPaciente)
        Me.Controls.Add(Me.btnModPaciente)
        Me.Controls.Add(Me.btnAddPaciente)
        Me.Controls.Add(Me.Label3)
        Me.Font = New System.Drawing.Font("UD Digi Kyokasho NP-R", 10.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(450, 450)
        Me.MinimumSize = New System.Drawing.Size(450, 450)
        Me.Name = "menuPaciente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Menú de Gestión de Pacientes"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnDelPaciente As System.Windows.Forms.Button
    Friend WithEvents btnVolver As System.Windows.Forms.Button
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents btnConPaciente As System.Windows.Forms.Button
    Friend WithEvents btnModPaciente As System.Windows.Forms.Button
    Friend WithEvents btnAddPaciente As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnInformes As System.Windows.Forms.Button
End Class
