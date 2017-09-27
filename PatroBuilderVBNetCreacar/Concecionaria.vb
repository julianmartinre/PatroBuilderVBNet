Public Class Concecionaria
    Dim autoBuilder As AutoBuilder
    Public Sub CrearAuto(unBuilder As AutoBuilder)
        autoBuilder = unBuilder
        autoBuilder.ConstruirMotor()
        autoBuilder.ObtenerMarca()
        autoBuilder.ObtenerModelo()
        autoBuilder.DefinirPuertas()
    End Sub
End Class
