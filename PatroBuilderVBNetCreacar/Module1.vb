Module Module1

    Sub Main()
        Dim unaConcecionaria As New Concecionaria
        Dim unAuto As New Auto
#Region "FiatPalio"
        Dim fiatPalioAutoBuilder As New FiatPalioAutoBuilder
        unaConcecionaria.CrearAuto(fiatPalioAutoBuilder)
        unAuto = fiatPalioAutoBuilder.ObtenerAuto()
        Console.Write(unAuto.marca & " " + unAuto.modelo & " " + unAuto.motor + " " & unAuto.puertas & vbCrLf)
#End Region
#Region "FiatSiena"
        Dim fiatSienaAutoBuilder As New FiatSienaAutoBuilder
        unaConcecionaria.CrearAuto(fiatSienaAutoBuilder)
        unAuto = fiatSienaAutoBuilder.ObtenerAuto()
        Console.Write(unAuto.marca & " " + unAuto.modelo & " " + unAuto.motor + " " & unAuto.puertas & vbCrLf)
#End Region
#Region "FordFiesta"
        Dim fordFiestaAutoBuilder As New FordFiestaAutoBuilder
        unaConcecionaria.CrearAuto(fordFiestaAutoBuilder)
        unAuto = fordFiestaAutoBuilder.ObtenerAuto()
        Console.Write(unAuto.marca & " " + unAuto.modelo & " " + unAuto.motor + " " & unAuto.puertas & vbCrLf)
#End Region
#Region "FordFocus"
        Dim fordFocusAutoBuilder As New FordFocusAutoBuilder
        unaConcecionaria.CrearAuto(fordFocusAutoBuilder)
        unAuto = fordFocusAutoBuilder.ObtenerAuto()
        Console.Write(unAuto.marca & " " + unAuto.modelo & " " + unAuto.motor + " " & unAuto.puertas & vbCrLf)
#End Region
        Console.ReadKey()
    End Sub

End Module
