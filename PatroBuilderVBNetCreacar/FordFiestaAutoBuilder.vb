Imports PatroBuilderVBNetCreacar

Public Class FordFiestaAutoBuilder
    Inherits AutoBuilder
    Dim unAuto As New Auto
    Public Overrides Sub ConstruirMotor()
        unAuto.motor = "1.6"
    End Sub

    Public Overrides Sub DefinirPuertas()
        unAuto.puertas = 3
    End Sub

    Public Overrides Sub ObtenerMarca()
        unAuto.marca = "FORD"
    End Sub

    Public Overrides Sub ObtenerModelo()
        unAuto.modelo = "FIESTA"
    End Sub

    Public Overrides Function ObtenerAuto() As Auto
        Return unAuto
    End Function
End Class
