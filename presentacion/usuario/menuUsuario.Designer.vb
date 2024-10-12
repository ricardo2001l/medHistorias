<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class menuUsuario
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(menuUsuario))
        Me.btnVolver = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnConUsuario = New System.Windows.Forms.Button()
        Me.btnModUsuario = New System.Windows.Forms.Button()
        Me.btnAddUsuario = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnDelUsuario = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnVolver
        '
        Me.btnVolver.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnVolver.Location = New System.Drawing.Point(225, 305)
        Me.btnVolver.Margin = New System.Windows.Forms.Padding(2)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(190, 35)
        Me.btnVolver.TabIndex = 42
        Me.btnVolver.Text = "Volver"
        Me.btnVolver.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnSalir.Location = New System.Drawing.Point(20, 305)
        Me.btnSalir.Margin = New System.Windows.Forms.Padding(2)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(190, 35)
        Me.btnSalir.TabIndex = 41
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'btnConUsuario
        '
        Me.btnConUsuario.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnConUsuario.Location = New System.Drawing.Point(20, 197)
        Me.btnConUsuario.Margin = New System.Windows.Forms.Padding(2)
        Me.btnConUsuario.Name = "btnConUsuario"
        Me.btnConUsuario.Size = New System.Drawing.Size(395, 35)
        Me.btnConUsuario.TabIndex = 40
        Me.btnConUsuario.Text = "Consultar Usuarios"
        Me.btnConUsuario.UseVisualStyleBackColor = True
        '
        'btnModUsuario
        '
        Me.btnModUsuario.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnModUsuario.Location = New System.Drawing.Point(20, 145)
        Me.btnModUsuario.Margin = New System.Windows.Forms.Padding(2)
        Me.btnModUsuario.Name = "btnModUsuario"
        Me.btnModUsuario.Size = New System.Drawing.Size(395, 35)
        Me.btnModUsuario.TabIndex = 39
        Me.btnModUsuario.Text = "Modificar Usuarios"
        Me.btnModUsuario.UseVisualStyleBackColor = True
        '
        'btnAddUsuario
        '
        Me.btnAddUsuario.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnAddUsuario.Location = New System.Drawing.Point(20, 95)
        Me.btnAddUsuario.Margin = New System.Windows.Forms.Padding(2)
        Me.btnAddUsuario.Name = "btnAddUsuario"
        Me.btnAddUsuario.Size = New System.Drawing.Size(395, 35)
        Me.btnAddUsuario.TabIndex = 34
        Me.btnAddUsuario.Text = "Añadir usuarios"
        Me.btnAddUsuario.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Poor Richard", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(87, 14)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(265, 55)
        Me.Label3.TabIndex = 33
        Me.Label3.Text = "MedHistorias"
        '
        'btnDelUsuario
        '
        Me.btnDelUsuario.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnDelUsuario.Location = New System.Drawing.Point(20, 248)
        Me.btnDelUsuario.Margin = New System.Windows.Forms.Padding(2)
        Me.btnDelUsuario.Name = "btnDelUsuario"
        Me.btnDelUsuario.Size = New System.Drawing.Size(395, 35)
        Me.btnDelUsuario.TabIndex = 43
        Me.btnDelUsuario.Text = "Eliminar Usuarios"
        Me.btnDelUsuario.UseVisualStyleBackColor = True
        '
        'menuUsuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.GhostWhite
        Me.ClientSize = New System.Drawing.Size(444, 371)
        Me.Controls.Add(Me.btnDelUsuario)
        Me.Controls.Add(Me.btnVolver)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnConUsuario)
        Me.Controls.Add(Me.btnModUsuario)
        Me.Controls.Add(Me.btnAddUsuario)
        Me.Controls.Add(Me.Label3)
        Me.Font = New System.Drawing.Font("UD Digi Kyokasho NP-R", 10.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(450, 400)
        Me.MinimumSize = New System.Drawing.Size(450, 400)
        Me.Name = "menuUsuario"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Menu de Gestión de Usuario"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnVolver As System.Windows.Forms.Button
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents btnConUsuario As System.Windows.Forms.Button
    Friend WithEvents btnModUsuario As System.Windows.Forms.Button
    Friend WithEvents btnAddUsuario As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnDelUsuario As System.Windows.Forms.Button
End Class
