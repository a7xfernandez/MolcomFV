Imports Microsoft.AspNet.Identity.EntityFramework

Public Class AppDbContext
    Inherits IdentityDbContext(Of AppUser)
    Public Sub New()
        MyBase.New("DefaultConnection")
    End Sub

    Public Shared Function Create() As AppDbContext
        Return New AppDbContext()
    End Function
End Class
