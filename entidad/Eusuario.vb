Public Class Eusuario
    Private nombreUsuario, cedula, contrasena, nombre, apellido, administrador, email, telefono, fechaDeNacimiento As String

    Public Property _nombreUsuario As String
        Get
            Return nombreUsuario
        End Get
        Set(ByVal value As String)
            nombreUsuario = value
        End Set
    End Property
    Public Property _contrasena As String
        Get
            Return contrasena
        End Get
        Set(ByVal value As String)
            contrasena = value
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
    Public Property _administrador As String
        Get
            Return administrador
        End Get
        Set(ByVal value As String)
            administrador = value
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

    Public Sub New()

    End Sub
End Class
