Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema
Namespace Modelos
    <Table("Conductores")>
    Public Class Conductor

        Public Property Id As Int32
        <MaxLength(50)>
        Public Property Nombre As String
        <MaxLength(50)>
        Public Property Apellido As String
        <MaxLength(50)>
        Public Property Identidad As String
    End Class
End Namespace

