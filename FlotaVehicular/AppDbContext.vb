Imports Microsoft.AspNet.Identity.EntityFramework
Imports FlotaVehicular.Modelos
Imports System.Data.Entity

Public Class AppDbContext
    Inherits IdentityDbContext(Of AppUser)
    Public Sub New()
        MyBase.New("DefaultConnection")
    End Sub

    Public Shared Function Create() As AppDbContext
        Return New AppDbContext()
    End Function

    Public Property Vehiculos() As DbSet(Of Vehiculo)
    Public Property Marcas() As DbSet(Of VehiculoMarca)
    Public Property Modelos() As DbSet(Of VehiculoModelo)
    ''agregar modelos
End Class
