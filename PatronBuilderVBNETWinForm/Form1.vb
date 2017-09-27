Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim unaConcecionaria As New Concecionaria
        Dim scooterMotoBuilder As New ScooterMotoBuilder
        unaConcecionaria.CrearMoto(scooterMotoBuilder)
    End Sub
End Class
