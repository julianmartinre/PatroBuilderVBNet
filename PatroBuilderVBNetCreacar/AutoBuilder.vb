Public MustInherit Class AutoBuilder
    Public MustOverride Sub ConstruirMotor()
    Public MustOverride Sub ObtenerMarca()
    Public MustOverride Sub ObtenerModelo()
    Public MustOverride Sub DefinirPuertas()
    Public MustOverride Function ObtenerAuto() As Auto

End Class
