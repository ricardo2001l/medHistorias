﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class delHistoriaMedica
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(delHistoriaMedica))
        Me.btnVolver = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.txtTratamientos = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtAntecedentesFamiliares = New System.Windows.Forms.TextBox()
        Me.txtAntecedentes = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbCedula = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'btnVolver
        '
        Me.btnVolver.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnVolver.Location = New System.Drawing.Point(150, 432)
        Me.btnVolver.Margin = New System.Windows.Forms.Padding(2)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(89, 37)
        Me.btnVolver.TabIndex = 127
        Me.btnVolver.Text = "Volver"
        Me.btnVolver.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnSalir.Location = New System.Drawing.Point(41, 432)
        Me.btnSalir.Margin = New System.Windows.Forms.Padding(2)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(89, 37)
        Me.btnSalir.TabIndex = 126
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'btnEliminar
        '
        Me.btnEliminar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnEliminar.Enabled = False
        Me.btnEliminar.Location = New System.Drawing.Point(421, 432)
        Me.btnEliminar.Margin = New System.Windows.Forms.Padding(2)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(107, 37)
        Me.btnEliminar.TabIndex = 125
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'txtTratamientos
        '
        Me.txtTratamientos.Enabled = False
        Me.txtTratamientos.Location = New System.Drawing.Point(38, 362)
        Me.txtTratamientos.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtTratamientos.Multiline = True
        Me.txtTratamientos.Name = "txtTratamientos"
        Me.txtTratamientos.Size = New System.Drawing.Size(490, 57)
        Me.txtTratamientos.TabIndex = 124
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Poor Richard", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(140, 11)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(265, 55)
        Me.Label3.TabIndex = 123
        Me.Label3.Text = "MedHistorias"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(38, 333)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(104, 16)
        Me.Label9.TabIndex = 122
        Me.Label9.Text = "Tratamientos:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(37, 235)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(178, 16)
        Me.Label4.TabIndex = 121
        Me.Label4.Text = "Antecedentes familiares:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(38, 139)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(165, 16)
        Me.Label5.TabIndex = 120
        Me.Label5.Text = "Antecedentes médicos:"
        '
        'txtAntecedentesFamiliares
        '
        Me.txtAntecedentesFamiliares.Enabled = False
        Me.txtAntecedentesFamiliares.Location = New System.Drawing.Point(39, 262)
        Me.txtAntecedentesFamiliares.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtAntecedentesFamiliares.Multiline = True
        Me.txtAntecedentesFamiliares.Name = "txtAntecedentesFamiliares"
        Me.txtAntecedentesFamiliares.Size = New System.Drawing.Size(489, 56)
        Me.txtAntecedentesFamiliares.TabIndex = 119
        '
        'txtAntecedentes
        '
        Me.txtAntecedentes.Enabled = False
        Me.txtAntecedentes.Location = New System.Drawing.Point(39, 168)
        Me.txtAntecedentes.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtAntecedentes.Multiline = True
        Me.txtAntecedentes.Name = "txtAntecedentes"
        Me.txtAntecedentes.Size = New System.Drawing.Size(490, 55)
        Me.txtAntecedentes.TabIndex = 118
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(36, 78)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(149, 16)
        Me.Label1.TabIndex = 117
        Me.Label1.Text = "Cédula del paciente:"
        '
        'cmbCedula
        '
        Me.cmbCedula.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCedula.FormattingEnabled = True
        Me.cmbCedula.Location = New System.Drawing.Point(38, 102)
        Me.cmbCedula.Name = "cmbCedula"
        Me.cmbCedula.Size = New System.Drawing.Size(197, 23)
        Me.cmbCedula.TabIndex = 128
        '
        'delHistoriaMedica
        '
        Me.AcceptButton = Me.btnEliminar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.GhostWhite
        Me.CancelButton = Me.btnVolver
        Me.ClientSize = New System.Drawing.Size(574, 491)
        Me.Controls.Add(Me.cmbCedula)
        Me.Controls.Add(Me.btnVolver)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.txtTratamientos)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtAntecedentesFamiliares)
        Me.Controls.Add(Me.txtAntecedentes)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("UD Digi Kyokasho NP-R", 10.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(580, 520)
        Me.MinimumSize = New System.Drawing.Size(580, 520)
        Me.Name = "delHistoriaMedica"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Eliminar una Historia Médica"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnVolver As System.Windows.Forms.Button
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents btnEliminar As System.Windows.Forms.Button
    Friend WithEvents txtTratamientos As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtAntecedentesFamiliares As System.Windows.Forms.TextBox
    Friend WithEvents txtAntecedentes As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmbCedula As System.Windows.Forms.ComboBox
End Class
