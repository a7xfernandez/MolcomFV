Imports System.Security.Claims

Public MustInherit Class AppController
    Inherits Controller
    Public ReadOnly Property CurrentUser() As AppUser
        Get
            Return New AppUser() ' TryCast(Me.User, ClaimsPrincipal))
        End Get
    End Property
End Class