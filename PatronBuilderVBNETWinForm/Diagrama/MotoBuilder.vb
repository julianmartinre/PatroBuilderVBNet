Public MustInherit Class MotoBuilder

    Public MustOverride Sub ConstruirMotor()
    Public MustOverride Sub ConstruirRuedas()
    Public MustOverride Sub ConstruirCarroceria()
    Public MustOverride Function ObtenerMoto() As Moto

End Class
