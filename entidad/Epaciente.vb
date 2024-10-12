Public Class Epaciente
    Private cedulaPaciente, nombre, apellido, email, telefono, fechaDeNacimiento, sexo, residencia As String

    Public Property _cedulaPaciente As String
        Get
            Return cedulaPaciente
        End Get
        Set(ByVal value As String)
            cedulaPaciente = value
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
    Public Property _Sexo As String
        Get
            Return Sexo
        End Get
        Set(ByVal value As String)
            Sexo = value
        End Set
    End Property
    Public Property _residencia As String
        Get
            Return residencia
        End Get
        Set(ByVal value As String)
            residencia = value
        End Set
    End Property
    Public Sub New()

    End Sub
End Class
