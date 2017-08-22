Public Class HomeController
    Inherits AppController

    Function Index() As ActionResult

        Return View()
    End Function

    Function About() As ActionResult
        ViewData("Message") = "Your application description page."

        Return View()
    End Function

    <Authorize(Roles:="Admin")>
    Function Contact() As ActionResult
        ViewData("Message") = "Your contact page. Only Admin"

        Return View()
    End Function
End Class
