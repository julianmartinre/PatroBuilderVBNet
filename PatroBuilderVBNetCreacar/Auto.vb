Public Class Auto

    Private _motor As String
    Public Property motor() As String
        Get
            Return _motor
        End Get
        Set(ByVal value As String)
            _motor = value
        End Set
    End Property

    Private _marca As String
    Public Property marca() As String
        Get
            Return _marca
        End Get
        Set(ByVal value As String)
            _marca = value
        End Set
    End Property

    Private _modelo As String
    Public Property modelo() As String
        Get
            Return _modelo
        End Get
        Set(ByVal value As String)
            _modelo = value
        End Set
    End Property

    Private _puertas As Integer
    Public Property puertas() As Integer
        Get
            Return _puertas
        End Get
        Set(ByVal value As Integer)
            _puertas = value
        End Set
    End Property
End Class
