Public Class Epuesto
    Private codPuesto, nombre, descripcion, sueldo As String

    Public Property _codPuesto As String
        Get
            Return codPuesto
        End Get
        Set(ByVal value As String)
            codPuesto = value
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
    Public Property _descripcion As String
        Get
            Return descripcion
        End Get
        Set(ByVal value As String)
            descripcion = value
        End Set
    End Property
    Public Property _sueldo As String
        Get
            Return sueldo
        End Get
        Set(ByVal value As String)
            sueldo = value
        End Set
    End Property

    Public Sub New()

    End Sub
End Class
