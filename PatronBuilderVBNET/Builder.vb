Imports PatronBuilderVBNET

Public Class Builder

    Class Concecionaria

        Dim motoBuilder As MotoBuilder

        Public Sub CrearMoto(unBuilder As MotoBuilder)

            motoBuilder = unBuilder
            unBuilder.ConstruirMotor()
            unBuilder.ConstruirRuedas()

        End Sub

    End Class

    MustInherit Class MotoBuilder
        Public MustOverride Sub ConstruirMotor()
        Public MustOverride Sub ConstruirRuedas()
        Public MustOverride Function GetMoto() As Moto

    End Class

    Class ScooterMotoBuilder
        Inherits MotoBuilder

        Private unaMoto As New Moto

        Public Overrides Sub ConstruirMotor()
            unaMoto.add("MotorScooter")
        End Sub

        Public Overrides Sub ConstruirRuedas()
            unaMoto.add("RuedasScooter")
        End Sub

        Public Overrides Function GetMoto() As Moto
            Return unaMoto
        End Function
    End Class

    Class EnduroMotoBuilder
        Inherits MotoBuilder

        Private unaMoto As New Moto

        Public Overrides Sub ConstruirMotor()
            unaMoto.add("EnduroMotor")
        End Sub

        Public Overrides Sub ConstruirRuedas()
            unaMoto.add("EnduroRuedas")
        End Sub

        Public Overrides Function GetMoto() As Moto
            Return unaMoto
        End Function
    End Class

    Class PisteroMotoBuilder
        Inherits MotoBuilder

        Private unaMoto As New Moto

        Public Overrides Sub ConstruirMotor()
            unaMoto.add("PisteroMotor")
        End Sub

        Public Overrides Sub ConstruirRuedas()
            unaMoto.add("PisteroRuedas")
        End Sub

        Public Overrides Function GetMoto() As Moto
            Return unaMoto
        End Function
    End Class

    Class Moto

        Dim partes As New ArrayList

        Public Sub add(parte As String)
            partes.Add(parte)
        End Sub

        Public Sub crearMoto()

            Console.WriteLine("\Moto")

            For Each item In partes
                Console.WriteLine("" + item)
                Console.WriteLine("")
            Next

        End Sub

    End Class

End Class
