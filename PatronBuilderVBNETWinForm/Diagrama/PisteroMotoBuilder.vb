Imports PatronBuilderVBNETWinForm

Public Class PisteroMotoBuilder
    Inherits MotoBuilder
    Private unaMoto As New Moto
    Public Overrides Sub ConstruirCarroceria()
        unaMoto.añadirParte("Carroceria PISTERO.")
    End Sub

    Public Overrides Sub ConstruirMotor()
        unaMoto.añadirParte("Motor PISTERO.")
    End Sub

    Public Overrides Sub ConstruirRuedas()
        unaMoto.añadirParte("Ruedas PISTERO.")
    End Sub

    Public Overrides Function ObtenerMoto() As Moto
        Return unaMoto
    End Function
End Class
