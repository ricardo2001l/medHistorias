Public Class Emedico
    Private cedulaMedico, nombre, apellido, email, telefono, fechaDeNacimiento, fechaDeIngreso, Sexo, CodPuesto As String

    Public Property _cedulaMedico As String
        Get
            Return cedulaMedico
        End Get
        Set(ByVal value As String)
            cedulaMedico = value
        End Set
    End Property
    Public Property _nombre As String
        Get
            Return nombre
        End Get
        Set(ByVal value As String)
            nombre = value
        End Set
    End Property
    Public Property _apellido As String
        Get
            Return apellido
        End Get
        Set(ByVal value As String)
            apellido = value
        End Set
    End Property
    Public Property _email As String
        Get
            Return email
        End Get
        Set(ByVal value As String)
            email = value
        End Set
    End Property
    Public Property _telefono As String
        Get
            Return telefono
        End Get
        Set(ByVal value As String)
            telefono = value
        End Set
    End Property
    Public Property _fechaDeNacimiento As String
        Get
            Return fechaDeNacimiento
        End Get
        Set(ByVal value As String)
            fechaDeNacimiento = value
        End Set
    End Property
    Public Property _fechaDeIngreso As String
        Get
            Return fechaDeIngreso
        End Get
        Set(ByVal value As String)
            fechaDeIngreso = value
        End Set
    End Property
    Public Property _Sexo As String
        Get
            Return Sexo
        End Get
        Set(ByVal value As String)
            Sexo = value
        End Set
    End Property
    Public Property _CodPuesto As String
        Get
            Return CodPuesto
        End Get
        Set(ByVal value As String)
            CodPuesto = value
        End Set
    End Property
    Public Sub New()

    End Sub
End Class
