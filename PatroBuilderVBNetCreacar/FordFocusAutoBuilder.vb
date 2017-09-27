Imports PatroBuilderVBNetCreacar

Public Class FordFocusAutoBuilder
    Inherits AutoBuilder
    Dim unAuto As New Auto
    Public Overrides Sub ConstruirMotor()
        unAuto.motor = "2.0"
    End Sub

    Public Overrides Sub DefinirPuertas()
        unAuto.puertas = 3
    End Sub

    Public Overrides Sub ObtenerMarca()
        unAuto.marca = "FORD"
    End Sub

    Public Overrides Sub ObtenerModelo()
        unAuto.modelo = "FOCUS"
    End Sub

    Public Overrides Function ObtenerAuto() As Auto
        Return unAuto
    End Function
End Class
