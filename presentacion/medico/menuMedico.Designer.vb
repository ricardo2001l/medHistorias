<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class menuMedico
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(menuMedico))
        Me.btnDelMedico = New System.Windows.Forms.Button()
        Me.btnVolver = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnConMedico = New System.Windows.Forms.Button()
        Me.btnModMedico = New System.Windows.Forms.Button()
        Me.btnAddMedico = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnInformes = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnDelMedico
        '
        Me.btnDelMedico.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnDelMedico.Location = New System.Drawing.Point(20, 251)
        Me.btnDelMedico.Margin = New System.Windows.Forms.Padding(2)
        Me.btnDelMedico.Name = "btnDelMedico"
        Me.btnDelMedico.Size = New System.Drawing.Size(395, 35)
        Me.btnDelMedico.TabIndex = 50
        Me.btnDelMedico.Text = "Eliminar Médicos"
        Me.btnDelMedico.UseVisualStyleBackColor = True
        '
        'btnVolver
        '
        Me.btnVolver.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnVolver.Location = New System.Drawing.Point(225, 395)
        Me.btnVolver.Margin = New System.Windows.Forms.Padding(2)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(190, 35)
        Me.btnVolver.TabIndex = 49
        Me.btnVolver.Text = "Volver"
        Me.btnVolver.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnSalir.Location = New System.Drawing.Point(20, 395)
        Me.btnSalir.Margin = New System.Windows.Forms.Padding(2)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(190, 35)
        Me.btnSalir.TabIndex = 48
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'btnConMedico
        '
        Me.btnConMedico.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnConMedico.Location = New System.Drawing.Point(20, 200)
        Me.btnConMedico.Margin = New System.Windows.Forms.Padding(2)
        Me.btnConMedico.Name = "btnConMedico"
        Me.btnConMedico.Size = New System.Drawing.Size(395, 35)
        Me.btnConMedico.TabIndex = 47
        Me.btnConMedico.Text = "Consultar Médicos"
        Me.btnConMedico.UseVisualStyleBackColor = True
        '
        'btnModMedico
        '
        Me.btnModMedico.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnModMedico.Location = New System.Drawing.Point(20, 148)
        Me.btnModMedico.Margin = New System.Windows.Forms.Padding(2)
        Me.btnModMedico.Name = "btnModMedico"
        Me.btnModMedico.Size = New System.Drawing.Size(395, 35)
        Me.btnModMedico.TabIndex = 46
        Me.btnModMedico.Text = "Modificar Médicos"
        Me.btnModMedico.UseVisualStyleBackColor = True
        '
        'btnAddMedico
        '
        Me.btnAddMedico.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnAddMedico.Location = New System.Drawing.Point(20, 98)
        Me.btnAddMedico.Margin = New System.Windows.Forms.Padding(2)
        Me.btnAddMedico.Name = "btnAddMedico"
        Me.btnAddMedico.Size = New System.Drawing.Size(395, 35)
        Me.btnAddMedico.TabIndex = 45
        Me.btnAddMedico.Text = "Añadir Médicos"
        Me.btnAddMedico.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Poor Richard", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(87, 17)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(265, 55)
        Me.Label3.TabIndex = 44
        Me.Label3.Text = "MedHistorias"
        '
        'Button1
        '
        Me.Button1.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Button1.Location = New System.Drawing.Point(20, 302)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(395, 35)
        Me.Button1.TabIndex = 51
        Me.Button1.Text = "Puestos de trabajo"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnInformes
        '
        Me.btnInformes.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnInformes.Location = New System.Drawing.Point(20, 349)
        Me.btnInformes.Margin = New System.Windows.Forms.Padding(2)
        Me.btnInformes.Name = "btnInformes"
        Me.btnInformes.Size = New System.Drawing.Size(395, 35)
        Me.btnInformes.TabIndex = 52
        Me.btnInformes.Text = "Reportes sobre Médicos"
        Me.btnInformes.UseVisualStyleBackColor = True
        '
        'menuMedico
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.GhostWhite
        Me.CancelButton = Me.btnVolver
        Me.ClientSize = New System.Drawing.Size(444, 441)
        Me.Controls.Add(Me.btnInformes)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnDelMedico)
        Me.Controls.Add(Me.btnVolver)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnConMedico)
        Me.Controls.Add(Me.btnModMedico)
        Me.Controls.Add(Me.btnAddMedico)
        Me.Controls.Add(Me.Label3)
        Me.Font = New System.Drawing.Font("UD Digi Kyokasho NP-R", 10.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(450, 470)
        Me.MinimumSize = New System.Drawing.Size(450, 470)
        Me.Name = "menuMedico"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Menú de Gestión de Médicos"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnDelMedico As System.Windows.Forms.Button
    Friend WithEvents btnVolver As System.Windows.Forms.Button
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents btnConMedico As System.Windows.Forms.Button
    Friend WithEvents btnModMedico As System.Windows.Forms.Button
    Friend WithEvents btnAddMedico As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents btnInformes As System.Windows.Forms.Button
End Class
