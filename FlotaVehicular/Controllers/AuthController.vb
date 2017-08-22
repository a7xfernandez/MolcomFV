Imports System.Web.Mvc
Imports System.Security.Claims
Imports Microsoft.AspNet.Identity
Imports Microsoft.Owin.Security
Imports System.Threading.Tasks

Namespace Controllers
    <AllowAnonymous>
    Public Class AuthController
        Inherits Controller

        Private ReadOnly userManager As UserManager(Of AppUser)

        Public Sub New()
            Me.New(Startup.UserManagerFactory.Invoke())
        End Sub

        Public Sub New(userManager As UserManager(Of AppUser))
            Me.userManager = userManager
        End Sub


        ' GET: auth/login
        <HttpGet>
        Function LogIn(returnUrl As String) As ActionResult
            Dim model = New LogInModel() With {
                .ReturnUrl = returnUrl
            }

            Return View(model)
        End Function

        ' POST: auth/login
        <HttpPost>
        Public Async Function LogIn(model As LogInModel) As Threading.Tasks.Task(Of ActionResult)
            If Not ModelState.IsValid Then
                Return View()
            End If

            Dim user = Await userManager.FindAsync(model.Email, model.Password)

            If user IsNot Nothing Then
                Await SignIn(user)

                Return Redirect(GetRedirectUrl(model.ReturnUrl))
            End If

            ' user authN failed
            ModelState.AddModelError("", "Invalid email or password")
            Return View()
        End Function

        ' GET: auth/logout
        <HttpGet>
        Public Function LogOut() As ActionResult
            Dim ctx = Request.GetOwinContext()
            Dim authManager = ctx.Authentication

            authManager.SignOut("ApplicationCookie")
            Return RedirectToAction("index", "home")
        End Function

        <HttpGet>
        Public Function Register() As ActionResult
            Dim model = New RegisterModel()

            Return View(model)
        End Function

        <HttpPost>
        Public Async Function Register(model As RegisterModel) As Task(Of ActionResult)
            If Not ModelState.IsValid Then
                Return View()
            End If

            Dim user = New AppUser() With {
                .UserName = model.Email,
                .Nombre = model.Nombre,
                .Apellido = model.Apellido
            }

            Dim result = Await userManager.CreateAsync(user, model.Password)

            If result.Succeeded Then
                Await SignIn(user)
                Return RedirectToAction("index", "home")
            End If

            For Each [error] In result.Errors
                ModelState.AddModelError("", [error])
            Next

            Return View()
        End Function

        Private Function GetRedirectUrl(returnUrl As String) As String
            If String.IsNullOrEmpty(returnUrl) OrElse Not Url.IsLocalUrl(returnUrl) Then
                Return Url.Action("index", "home")
            End If

            Return returnUrl
        End Function

        Private Function GetAuthenticationManager() As IAuthenticationManager
            Dim ctx = Request.GetOwinContext()
            Return ctx.Authentication
        End Function

        Private Async Function SignIn(user As AppUser) As Task
            Dim identity = Await userManager.CreateIdentityAsync(
                user, DefaultAuthenticationTypes.ApplicationCookie)

            identity.AddClaim(New Claim("NombreCompleto", user.NombreCompleto))
            identity.AddClaim(New Claim("Nombre", user.Nombre))
            identity.AddClaim(New Claim("Apellido", user.Apellido))

            GetAuthenticationManager().SignIn(identity)
        End Function


        Protected Overrides Sub Dispose(disposing As Boolean)
            If disposing AndAlso userManager IsNot Nothing Then
                userManager.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

    End Class
End Namespace