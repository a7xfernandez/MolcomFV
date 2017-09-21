Imports FlotaVehicular.Modelos

Namespace ModelosVistas

    Public Class CrearVehiculo

        Public Property Id As Int32 = 0
        Public Property Marcas As List(Of VehiculoMarca)
        Public Property Modelos As List(Of VehiculoModelo)

        Public Property Modelo_Id As Int16
        Public Property Marca_Id As Int16
        Public Property Placa As String
        Public Property NumeroDeBastidor As String
        Public Property FechaDeAdquisicion As DateTime
        Public Property Valor As Decimal

        Public Property NumeroDeAsientos As Int16
        Public Property NumeroDePuertas As Int16
        Public Property Color As String

        ''Motor
        Public Property Transmision As Transmisiones
        Public Property Combustble As Combustibles
        Public Property EmisionesCO2 As Decimal
        Public Property CaballosDeFuerza As Int16
        Public Property CaballosDeFuerzaFisicales As Decimal
        Public Property Potencia As Int16

    End Class
End Namespace
