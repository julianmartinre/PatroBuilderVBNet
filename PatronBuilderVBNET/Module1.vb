Imports PatronBuilderVBNET.Builder

Module Module1

    Sub Main()

        Dim unaConcecionaria As New Concecionaria

        Dim ScooterMotoBuilder As New ScooterMotoBuilder
        Dim EnduroMotoBuilder As New EnduroMotoBuilder
        Dim PisteroMotoBuilder As New PisteroMotoBuilder

        Dim unaMoto As New Moto

        unaConcecionaria.CrearMoto(ScooterMotoBuilder)

        unaMoto = ScooterMotoBuilder.GetMoto()
        unaMoto.crearMoto()

        unaConcecionaria.CrearMoto(EnduroMotoBuilder)

        unaMoto = EnduroMotoBuilder.GetMoto()
        unaMoto.crearMoto()

        unaConcecionaria.CrearMoto(PisteroMotoBuilder)

        unaMoto = PisteroMotoBuilder.GetMoto()
        unaMoto.crearMoto()

        Console.Read()

    End Sub

End Module
