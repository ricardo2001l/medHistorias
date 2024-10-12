Public Class EhistoriaMedica
    Private codHistoria, cedulaPaciente, antecedentes, antecedentesFamiliares, tratamientos As String


    Public Property _codHistoria As String
        Get
            Return codHistoria
        End Get
        Set(ByVal value As String)
            codHistoria = value
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
    Public Property _antecedentes As String
        Get
            Return antecedentes
        End Get
        Set(ByVal value As String)
            antecedentes = value
        End Set
    End Property
    Public Property _antecedentesFamiliares As String
        Get
            Return antecedentesFamiliares
        End Get
        Set(ByVal value As String)
            antecedentesFamiliares = value
        End Set
    End Property
    Public Property _tratamientos As String
        Get
            Return tratamientos
        End Get
        Set(ByVal value As String)
            tratamientos = value
        End Set
    End Property
    Public Sub New()

    End Sub
End Class
