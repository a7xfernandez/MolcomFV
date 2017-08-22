Imports System.Security.Claims
Imports Microsoft.AspNet.Identity.EntityFramework

Public Class AppUser
    Inherits IdentityUser

    Private _nombre As String
    Public Property Nombre() As String
        Get
            Return _nombre
        End Get
        Set(ByVal value As String)
            _nombre = value
        End Set
    End Property

    Private _apellido As String
    Public Property Apellido() As String
        Get
            Return _apellido
        End Get
        Set(ByVal value As String)
            _apellido = value
        End Set
    End Property

    Public ReadOnly Property NombreCompleto() As String
        Get
            Return _nombre + " " + _apellido
        End Get
    End Property

End Class
