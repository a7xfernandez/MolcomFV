Imports System.Security.Claims

Public Class AppUserPrincipal
    Inherits ClaimsPrincipal
    Public Sub New(principal As ClaimsPrincipal)
        MyBase.New(principal)
    End Sub

    Public ReadOnly Property NombreCompleto() As String
        Get
            Return Me.FindFirst("NombreCompleto")?.Value
        End Get
    End Property

    Public ReadOnly Property Nombre() As String
        Get
            Return Me.FindFirst("Nombre")?.Value
        End Get
    End Property

    Public ReadOnly Property Apellido() As String
        Get
            Return Me.FindFirst("Apellido")?.Value
        End Get
    End Property

End Class
