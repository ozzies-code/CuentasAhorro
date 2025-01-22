Public Class Cliente

    'Atributos de la Clase Cliente

    Private nombre As String
    Private numIdentificacion As String
    Private direccion As String
    Private telefono As String

    'Constructor por defecto
    Public Sub New()

    End Sub

    Public Sub New(ByVal nom As String, ByVal numId As String, ByVal dire As String, ByVal tel As String)

        nombre = nom
        numIdentificacion = numId
        direccion = dire
        telefono = tel

    End Sub

    Public Property NombreCliente As String

        Get
            Return nombre
        End Get
        Set(ByVal value As String)
            nombre = value
        End Set
    End Property

    Public Property NumIdCliente As String

        Get
            Return numIdentificacion
        End Get
        Set(ByVal value As String)
            numIdentificacion = value
        End Set
    End Property

    Public Property DireccionCliente As String
        Get
            Return direccion
        End Get
        Set(ByVal value As String)
            direccion = value
        End Set
    End Property

    Public Property TelefonoCliente As String
        Get
            Return telefono
        End Get
        Set(ByVal value As String)
            telefono = value
        End Set
    End Property

End Class
