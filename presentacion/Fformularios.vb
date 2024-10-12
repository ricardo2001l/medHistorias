﻿Imports datos
Public Module Fformularios
    Public admin As String
    Public dt As New DataTable
    Public dt2 As New DataTable
    Dim fg As New Fgeneral

    ' ELIMINAR VACÍO DE UN CMB
    Public Sub eliminarVacioCmb(ByVal cmb As System.Windows.Forms.ComboBox)
        While cmb.Items.Contains("")
            cmb.Items.Remove("")
        End While
    End Sub

    ' FUNCIONES LIMITANTES DE LA ENTRADA DE TEXTO
    Public Sub soloNumerosPuntos(ByRef e As System.Windows.Forms.KeyPressEventArgs)

        If e.KeyChar.ToString = "." Or Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
    Public Sub soloNumeros(ByRef e As System.Windows.Forms.KeyPressEventArgs)

        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
    Public Sub soloNumerosYletras(ByRef e As System.Windows.Forms.KeyPressEventArgs)
        If Char.IsLetter(e.KeyChar) Or Char.IsNumber(e.KeyChar) Or Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
    Public Sub soloNumerosletrasYGuiones(ByRef e As System.Windows.Forms.KeyPressEventArgs)
        If Char.IsLetter(e.KeyChar) Or Char.IsNumber(e.KeyChar) Or Char.IsControl(e.KeyChar) Or e.KeyChar.ToString = "-" Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
    Public Sub soloLetras(ByRef e As System.Windows.Forms.KeyPressEventArgs)
        If Char.IsLetter(e.KeyChar) Or Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
    Public Sub soloLetrasYEspacios(ByRef e As System.Windows.Forms.KeyPressEventArgs)
        If Char.IsLetter(e.KeyChar) Or Char.IsControl(e.KeyChar) Or e.KeyChar.ToString = " " Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
    Public Sub soloNumerosLetrasYCaracteres(ByRef e As System.Windows.Forms.KeyPressEventArgs)
        If Char.IsLetter(e.KeyChar) Or Char.IsNumber(e.KeyChar) Or Char.IsControl(e.KeyChar) Or Char.IsPunctuation(e.KeyChar) Or Char.IsSymbol(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
    Public Sub soloNumerosLetrasComasYEspacios(ByRef e As System.Windows.Forms.KeyPressEventArgs)
        If Char.IsLetter(e.KeyChar) Or Char.IsNumber(e.KeyChar) Or Char.IsControl(e.KeyChar) Or e.KeyChar.ToString = "," Or e.KeyChar.ToString = " " Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub



    ' LLENA LOS COMBOBOXES
    Public Sub llenarCmb(ByVal cmb As System.Windows.Forms.ComboBox, ByVal campoId As String, ByVal tabla As String, Optional ByVal clear As Boolean = True)
        If clear Then
            cmb.Items.Clear()
        End If

        dt = CType(fg.consultarId(campoId, tabla, False), DataTable)

        If dt.Rows.Count > 0 Then
            Dim i As Integer
            For i = 0 To (dt.Rows.Count - 1)
                cmb.Items.Add(dt(i)(campoId))
            Next
        End If
        fg.desconectar()
    End Sub
End Module
