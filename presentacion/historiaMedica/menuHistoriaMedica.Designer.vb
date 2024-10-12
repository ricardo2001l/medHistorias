<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class menuHistoriaMedica
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(menuHistoriaMedica))
        Me.btnVolver = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnConHistoriaMedica = New System.Windows.Forms.Button()
        Me.btnModHistoriaMedica = New System.Windows.Forms.Button()
        Me.btnAddHistoriaMedica = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnInfHistoriaMedica = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnVolver
        '
        Me.btnVolver.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnVolver.Location = New System.Drawing.Point(230, 300)
        Me.btnVolver.Margin = New System.Windows.Forms.Padding(2)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(190, 35)
        Me.btnVolver.TabIndex = 64
        Me.btnVolver.Text = "Volver"
        Me.btnVolver.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnSalir.Location = New System.Drawing.Point(25, 300)
        Me.btnSalir.Margin = New System.Windows.Forms.Padding(2)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(190, 35)
        Me.btnSalir.TabIndex = 63
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'btnConHistoriaMedica
        '
        Me.btnConHistoriaMedica.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnConHistoriaMedica.Location = New System.Drawing.Point(25, 203)
        Me.btnConHistoriaMedica.Margin = New System.Windows.Forms.Padding(2)
        Me.btnConHistoriaMedica.Name = "btnConHistoriaMedica"
        Me.btnConHistoriaMedica.Size = New System.Drawing.Size(395, 35)
        Me.btnConHistoriaMedica.TabIndex = 62
        Me.btnConHistoriaMedica.Text = "Consultar Historias Médicas"
        Me.btnConHistoriaMedica.UseVisualStyleBackColor = True
        '
        'btnModHistoriaMedica
        '
        Me.btnModHistoriaMedica.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnModHistoriaMedica.Location = New System.Drawing.Point(25, 151)
        Me.btnModHistoriaMedica.Margin = New System.Windows.Forms.Padding(2)
        Me.btnModHistoriaMedica.Name = "btnModHistoriaMedica"
        Me.btnModHistoriaMedica.Size = New System.Drawing.Size(395, 35)
        Me.btnModHistoriaMedica.TabIndex = 61
        Me.btnModHistoriaMedica.Text = "Modificar Historias Médicas"
        Me.btnModHistoriaMedica.UseVisualStyleBackColor = True
        '
        'btnAddHistoriaMedica
        '
        Me.btnAddHistoriaMedica.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnAddHistoriaMedica.Location = New System.Drawing.Point(25, 101)
        Me.btnAddHistoriaMedica.Margin = New System.Windows.Forms.Padding(2)
        Me.btnAddHistoriaMedica.Name = "btnAddHistoriaMedica"
        Me.btnAddHistoriaMedica.Size = New System.Drawing.Size(395, 35)
        Me.btnAddHistoriaMedica.TabIndex = 60
        Me.btnAddHistoriaMedica.Text = "Añadir Historias Médicas"
        Me.btnAddHistoriaMedica.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Poor Richard", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(92, 20)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(265, 55)
        Me.Label3.TabIndex = 59
        Me.Label3.Text = "MedHistorias"
        '
        'btnInfHistoriaMedica
        '
        Me.btnInfHistoriaMedica.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnInfHistoriaMedica.Location = New System.Drawing.Point(25, 254)
        Me.btnInfHistoriaMedica.Margin = New System.Windows.Forms.Padding(2)
        Me.btnInfHistoriaMedica.Name = "btnInfHistoriaMedica"
        Me.btnInfHistoriaMedica.Size = New System.Drawing.Size(395, 35)
        Me.btnInfHistoriaMedica.TabIndex = 66
        Me.btnInfHistoriaMedica.Text = "Reportes de Historias Médicas"
        Me.btnInfHistoriaMedica.UseVisualStyleBackColor = True
        '
        'menuHistoriaMedica
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.GhostWhite
        Me.CancelButton = Me.btnVolver
        Me.ClientSize = New System.Drawing.Size(444, 351)
        Me.Controls.Add(Me.btnInfHistoriaMedica)
        Me.Controls.Add(Me.btnVolver)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnConHistoriaMedica)
        Me.Controls.Add(Me.btnModHistoriaMedica)
        Me.Controls.Add(Me.btnAddHistoriaMedica)
        Me.Controls.Add(Me.Label3)
        Me.Font = New System.Drawing.Font("UD Digi Kyokasho NP-R", 10.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(450, 380)
        Me.MinimumSize = New System.Drawing.Size(450, 380)
        Me.Name = "menuHistoriaMedica"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Menú de Gestión de Historias Médicas"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnVolver As System.Windows.Forms.Button
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents btnConHistoriaMedica As System.Windows.Forms.Button
    Friend WithEvents btnModHistoriaMedica As System.Windows.Forms.Button
    Friend WithEvents btnAddHistoriaMedica As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnInfHistoriaMedica As System.Windows.Forms.Button
End Class
