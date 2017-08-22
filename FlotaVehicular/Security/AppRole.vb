Imports Microsoft.AspNet.Identity.EntityFramework

Public Class AppRole
    Inherits IdentityRole

    Public Sub New()
        MyBase.New()
    End Sub

    Public Sub New(Name As String)
        MyBase.New(Name)
    End Sub

End Class
