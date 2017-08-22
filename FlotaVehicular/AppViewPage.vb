Imports System.Security.Claims

Public MustInherit Class AppViewPage(Of TModel)
    Inherits WebViewPage(Of TModel)
    Protected ReadOnly Property CurrentUser() As AppUserPrincipal
        Get
            Return New AppUserPrincipal(TryCast(Me.User, ClaimsPrincipal))
        End Get
    End Property
End Class

Public MustInherit Class AppViewPage
    Inherits AppViewPage(Of Object)
End Class