Public Class Concecionaria

    Dim motoBuilder As MotoBuilder

    Public Sub CrearMoto(unBuilder As MotoBuilder)

        motoBuilder = unBuilder
        motoBuilder.ConstruirCarroceria()
        motoBuilder.ConstruirMotor()
        motoBuilder.ConstruirRuedas()

    End Sub

End Class
