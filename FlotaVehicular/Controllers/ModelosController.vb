Imports System.Web.Mvc
Imports FlotaVehicular.Modelos
Imports FlotaVehicular.ModelosVistas


Namespace Controllers
    Public Class ModelosController
        Inherits Controller

        Dim db As AppDbContext

        Sub New()
            Me.db = New AppDbContext()
        End Sub


        ' GET: Modelos
        Function Index() As ActionResult
            Dim modelos = db.Modelos.
                Include("Marca").
                ToList()
            Return View(modelos)
        End Function
        'GET: Modelos
        <HttpGet>
        Function Crear() As ActionResult
            ViewBag.Marcas = db.Marcas.ToList()

            Dim modelo = New CrearModelo
            Return View(modelo)
        End Function

        <HttpPost>
        Function Crear(Modelo As CrearModelo) As ActionResult
            Dim _Modelo = New VehiculoModelo

            If Modelo.id > 0 Then
                _Modelo = db.Modelos.Find(Modelo.id)
            End If

            Dim marca = db.Marcas.Find(Modelo.Marca_Id)

            _Modelo.Nombre = Modelo.Nombre
            _Modelo.Marca = marca

            If Modelo.id = 0 Then
                db.Modelos.Add(_Modelo)
            End If

            db.SaveChanges()

            Return RedirectToAction("Index")

        End Function

        <HttpGet>
        Function editar(id As Int32) As ActionResult

            ViewBag.Marcas = db.Marcas.ToList()

            Dim modelo = db.Modelos.Find(id)

            Dim _modelo = New CrearModelo()

            _modelo.id = modelo.Id
            _modelo.Marca_Id = modelo.Marca.Id
            _modelo.Nombre = modelo.Nombre

            Return View("Crear", _modelo)
        End Function
        ' GET: Vehiculos
        <HttpGet>
        Function Eliminar(id As Int32) As ActionResult

            Dim modelo = db.Modelos.Find(id)

            db.Modelos.Remove(modelo)
            db.SaveChanges()

            Return RedirectToAction("Index")
        End Function

    End Class
End Namespace