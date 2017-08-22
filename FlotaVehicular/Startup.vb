Imports Microsoft.AspNet.Identity
Imports Microsoft.AspNet.Identity.EntityFramework
Imports Microsoft.Owin
Imports Microsoft.Owin.Security.Cookies
Imports Owin

Public Class Startup
    Private Shared _userManagerFactory As Func(Of UserManager(Of AppUser))
    Public Shared Property UserManagerFactory() As Func(Of UserManager(Of AppUser))
        Get
            Return _userManagerFactory
        End Get
        Private Set
            _userManagerFactory = Value
        End Set
    End Property

    Private Shared _roleManagerFactory As Func(Of RoleManager(Of AppRole))
    Public Shared Property RoleManagerFactory() As Func(Of RoleManager(Of AppRole))
        Get
            Return _roleManagerFactory
        End Get
        Private Set
            _roleManagerFactory = Value
        End Set
    End Property

    Public Sub Configuration(app As IAppBuilder)
        ' this is the same as before
        app.UseCookieAuthentication(New CookieAuthenticationOptions() With {
            .AuthenticationType = DefaultAuthenticationTypes.ApplicationCookie,
            .LoginPath = New PathString("/auth/login")
        })
        Dim context = New AppDbContext()

        Dim roleManager = New RoleManager(Of AppRole)(New RoleStore(Of AppRole)(context))
        'RoleManagerFactory = Function()
        '                         Dim rolemanager = New RoleManager(Of AppRole)(New RoleStore(Of AppRole)(context))
        '                         ' allow alphanumeric characters in username
        '                         rolemanager.RoleValidator = New RoleValidator(Of AppRole)(RoleManager)
        '                         Return RoleManager

        '                     End Function
        Dim userManager = New UserManager(Of AppUser)(New UserStore(Of AppUser)(context))
        UserManagerFactory = Function()
                                 Dim _userManager = New UserManager(Of AppUser)(New UserStore(Of AppUser)(context))
                                 ' allow alphanumeric characters in username
                                 _userManager.UserValidator = New UserValidator(Of AppUser)(_userManager) With {
                                    .AllowOnlyAlphanumericUserNames = False
                                 }

                                 ' use out custom claims provider
                                 _userManager.ClaimsIdentityFactory = New AppUserClaimsIdentityFactory()

                                 Return _userManager

                             End Function

        'In Startup iam creating first Admin Role And creating a default Admin User    
        If (roleManager.RoleExists("Admin") = False) Then

            ' first we create Admin role  
            Dim role = New AppRole()
            role.Name = "Admin"
            roleManager.Create(role)

            'Here we create a Admin super user who will maintain the website                  

            Dim user = New AppUser()
            user.UserName = "admin@example.org"
            user.Nombre = "Administrador"
            user.Apellido = ""

            Dim userPWD = "admin1"

            Dim chkUser = userManager.Create(user, userPWD)

            'Add default User to Role Admin   
            If (chkUser.Succeeded) Then
                Dim result1 = userManager.AddToRole(user.Id, "Admin")

            End If
        End If


    End Sub
End Class

