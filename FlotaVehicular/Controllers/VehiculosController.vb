Imports System.Web.Mvc
Imports FlotaVehicular.Modelos
Imports FlotaVehicular.ModelosVistas

Namespace Controllers
    Public Class VehiculosController
        Inherits Controller

        Dim db As AppDbContext

        Sub New()
            Me.db = New AppDbContext()
        End Sub

        ' GET: Vehiculos
        <HttpGet>
        Function Index() As ActionResult
            Dim vehiculos = db.Vehiculos.
                Include("Modelo.Marca").
                ToList()

            Return View(vehiculos)
        End Function

        ' GET: Vehiculos
        <HttpGet>
        Function Crear() As ActionResult

            'Dim model = New CrearVehiculoModelo()
            ViewBag.Marcas = db.Marcas.ToList()
            ViewBag.Modelos = db.Modelos.Include("Marca").ToList()

            'ViewBag.marcas = model.Marcas
            Return View()
        End Function

        ' GET: Vehiculos
        <HttpGet>
        Function Editar(id As Int32) As ActionResult
            ViewBag.Marcas = db.Marcas.ToList()
            ViewBag.Modelos = db.Modelos.Include("Marca").ToList()

            Dim vehiculo = db.Vehiculos.Find(id)
            Dim data = New CrearVehiculo()

            data.Id = vehiculo.Id
            data.Modelo_Id = vehiculo.Modelo.Id
            data.Marca_Id = vehiculo.Modelo.Marca.Id
            data.Placa = vehiculo.Placa
            data.NumeroDeBastidor = vehiculo.NumeroDeBastidor
            data.FechaDeAdquisicion = vehiculo.FechaDeAdquisicion
            data.Valor = vehiculo.Valor

            data.NumeroDeAsientos = vehiculo.NumeroDeAsientos
            data.NumeroDePuertas = vehiculo.NumeroDePuertas
            data.Color = vehiculo.Color

            data.Transmision = vehiculo.Transmision
            data.Combustble = vehiculo.Combustble
            data.EmisionesCO2 = vehiculo.EmisionesCO2
            data.CaballosDeFuerza = vehiculo.CaballosDeFuerza
            data.CaballosDeFuerzaFisicales = vehiculo.CaballosDeFuerzaFisicales
            data.Potencia = vehiculo.Potencia

            Return View("Crear", data)
        End Function

        ' POST: Vehiculos
        <HttpPost>
        Function Crear(data As CrearVehiculo) As ActionResult
            Dim vehiculo = New Vehiculo()
            If (data.Id > 0) Then
                vehiculo = db.Vehiculos.Find(data.Id)
            End If

            Dim modelo = db.Modelos.Find(data.Modelo_Id)

            vehiculo.Modelo = modelo
            vehiculo.Placa = data.Placa
            vehiculo.NumeroDeBastidor = data.NumeroDeBastidor
            vehiculo.FechaDeAdquisicion = data.FechaDeAdquisicion
            vehiculo.Valor = data.Valor

            vehiculo.NumeroDeAsientos = data.NumeroDeAsientos
            vehiculo.NumeroDePuertas = data.NumeroDePuertas
            vehiculo.Color = data.Color

            vehiculo.Transmision = data.Transmision
            vehiculo.Combustble = data.Combustble
            vehiculo.EmisionesCO2 = data.EmisionesCO2
            vehiculo.CaballosDeFuerza = data.CaballosDeFuerza
            vehiculo.CaballosDeFuerzaFisicales = data.CaballosDeFuerzaFisicales
            vehiculo.Potencia = data.Potencia

            If (data.Id.Equals(0)) Then
                db.Vehiculos.Add(vehiculo)
            End If
            db.SaveChanges()
            Return RedirectToAction("Index")
        End Function

        ' GET: Vehiculos
        <HttpGet>
        Function Eliminar(id As Int32) As ActionResult

            Dim vehiculo = db.Vehiculos.Find(id)

            db.Vehiculos.Remove(vehiculo)
            db.SaveChanges()

            Return RedirectToAction("Index")
        End Function
    End Class
End Namespace