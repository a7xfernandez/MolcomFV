Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema

Namespace Modelos

    <Table("Vehiculos")>
    Public Class Vehiculo

        Public Property Id As Int32
        Public Property Modelo As VehiculoModelo

        <MaxLength(10)>
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

    Public Enum Transmisiones
        Manual
        Automatico
    End Enum

    Public Enum Combustibles
        Gasolina
        Diesel
        Electrico
        Hibrido
    End Enum

End Namespace
