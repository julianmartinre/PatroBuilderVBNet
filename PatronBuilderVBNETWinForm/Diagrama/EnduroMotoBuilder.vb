Imports PatronBuilderVBNETWinForm

Public Class EnduroMotoBuilder
    Inherits MotoBuilder
    Private unaMoto As New Moto
    Public Overrides Sub ConstruirCarroceria()
        unaMoto.añadirParte("Carroceria ENDURO.")
    End Sub

    Public Overrides Sub ConstruirMotor()
        unaMoto.añadirParte("Motor ENDURO.")
    End Sub

    Public Overrides Sub ConstruirRuedas()
        unaMoto.añadirParte("Ruedas ENDURO.")
    End Sub

    Public Overrides Function ObtenerMoto() As Moto
        Return unaMoto
    End Function
End Class
