Public Class EconsultaMedica
    Private codConsulta, cedulaMedico, cedulaPaciente, fecha, motivo, peso, altura, sintomas, diagnostico As String


    Public Property _codConsulta As String
        Get
            Return codConsulta
        End Get
        Set(ByVal value As String)
            codConsulta = value
        End Set
    End Property
    Public Property _cedulaMedico As String
        Get
            Return cedulaMedico
        End Get
        Set(ByVal value As String)
            cedulaMedico = value
        End Set
    End Property
    Public Property _cedulaPaciente As String
        Get
            Return cedulaPaciente
        End Get
        Set(ByVal value As String)
            cedulaPaciente = value
        End Set
    End Property
    Public Property _fecha As String
        Get
            Return fecha
        End Get
        Set(ByVal value As String)
            fecha = value
        End Set
    End Property
    Public Property _motivo As String
        Get
            Return motivo
        End Get
        Set(ByVal value As String)
            motivo = value
        End Set
    End Property
    Public Property _peso As String
        Get
            Return peso
        End Get
        Set(ByVal value As String)
            peso = value
        End Set
    End Property
    Public Property _altura As String
        Get
            Return altura
        End Get
        Set(ByVal value As String)
            altura = value
        End Set
    End Property
    Public Property _sintomas As String
        Get
            Return sintomas
        End Get
        Set(ByVal value As String)
            sintomas = value
        End Set
    End Property
    Public Property _diagnostico As String
        Get
            Return diagnostico
        End Get
        Set(ByVal value As String)
            diagnostico = value
        End Set
    End Property

    Public Sub New()

    End Sub
End Class
