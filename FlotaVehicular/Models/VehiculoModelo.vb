Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema

Namespace Modelos

    <Table("VehiculoModelos")>
    Public Class VehiculoModelo

        Public Property Id As Int32
        Public Property Marca As VehiculoMarca

        <MaxLength(50)>
        Public Property Nombre As String
    End Class
End Namespace
