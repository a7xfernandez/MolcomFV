Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema

Namespace Modelos

    <Table("VehiculoMarcas")>
    Public Class VehiculoMarca

        Public Property Id As Int32

        <MaxLength(50)>
        Public Property Nombre As String

    End Class
End Namespace
