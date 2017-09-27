Imports PatroBuilderVBNetCreacar

Public Class FiatSienaAutoBuilder
    Inherits AutoBuilder
    Dim unAuto As New Auto
    Public Overrides Sub ConstruirMotor()
        unAuto.motor = "1.6"
    End Sub

    Public Overrides Sub DefinirPuertas()
        unAuto.puertas = 3
    End Sub

    Public Overrides Sub ObtenerMarca()
        unAuto.marca = "FIAT"
    End Sub

    Public Overrides Sub ObtenerModelo()
        unAuto.modelo = "SIENA"
    End Sub

    Public Overrides Function ObtenerAuto() As Auto
        Return unAuto
    End Function
End Class
