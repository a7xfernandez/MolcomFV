Imports System.Web.Mvc
Imports FlotaVehicular.Modelos
Imports FlotaVehicular.ModelosVistas

Namespace Controllers
    Public Class MarcasController
        Inherits Controller

        Dim db As AppDbContext

        Sub New()
            Me.db = New AppDbContext()
        End Sub

        ' GET: Marcas
        Function Index() As ActionResult
            Dim marcas = db.Marcas.
                ToList()

            Return View(marcas)
        End Function

        <HttpGet>
        Function Crear() As ActionResult
            Dim marca = New VehiculoMarca
            Return View(marca)
        End Function

        <HttpPost>
        Function Crear(Marca As VehiculoMarca) As ActionResult
            Dim _Marca = New VehiculoMarca

            If Marca.Id > 0 Then
                _Marca = db.Marcas.Find(Marca.Id)
            End If

            _Marca.Nombre = Marca.Nombre


            If Marca.Id = 0 Then
                db.Marcas.Add(_Marca)
            End If


            db.SaveChanges()

            Return RedirectToAction("Index")

        End Function

        <HttpGet>
        Function Editar(id As Int32) As ActionResult
            Dim marca = db.Marcas.Find(id)

            Return View("Crear", marca)
        End Function

    End Class
End Namespace