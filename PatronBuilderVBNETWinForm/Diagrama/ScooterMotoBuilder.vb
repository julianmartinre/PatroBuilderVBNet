Imports PatronBuilderVBNETWinForm

Public Class ScooterMotoBuilder
    Inherits MotoBuilder
    Private unaMoto As New Moto
    Public Overrides Sub ConstruirCarroceria()
        unaMoto.añadirParte("Carroceria Scooter.")
    End Sub

    Public Overrides Sub ConstruirMotor()
        unaMoto.añadirParte("Motor Scooter.")
    End Sub

    Public Overrides Sub ConstruirRuedas()
        unaMoto.añadirParte("Ruedas Scooter.")
    End Sub

    Public Overrides Function ObtenerMoto() As Moto
        Return unaMoto
    End Function
End Class
