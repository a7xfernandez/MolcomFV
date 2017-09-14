Imports System.Web.Mvc

Namespace Controllers
    Public Class VehiculosController
        Inherits Controller

        ' GET: Vehiculos
        Function Index() As ActionResult
            Return View()
        End Function
    End Class
End Namespace