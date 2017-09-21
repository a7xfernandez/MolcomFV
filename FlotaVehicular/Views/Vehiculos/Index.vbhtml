@Code
    ViewData("Title") = "Index"
    Layout = "~/Views/Shared/_Layout.vbhtml"
End Code

    <div class="row">
        <div class="col-md-8">
            <h2>
                Vehículos
                <a href="@Url.Action("Crear", "Vehiculos")"><i class="pe-7s-plus"></i></a>
            </h2>
        </div>
        <div class="col-md-4">
            <div>
            </div>
        </div>
    </div>

    <div Class="row">
        <div Class="col-md-12">

            <div class="card">

                <Table Class="table">
                    <tr>
                        <th>Placa</th>
                        <th>Modelo</th>
                        <th>Conductor</th>
                        <th>Número de Bastidor</th>
                        <th>Fecha de adquisicion</th>
                        <th>Acciones</th>

                    </tr>
                    @For Each item In Model
                        @<tr>
                            <td>
                                @item.Placa.ToString()
                            </td>
                            <td>
                                @item.Modelo.Marca.Nombre.ToString()/@item.Modelo.Nombre.ToString()
                            </td>
                            <td>
                            </td>
                            <td>
                                @item.NumeroDeBastidor.ToString()
                            </td>
                            <td>
                                @item.FechaDeAdquisicion.ToString()
                            </td>
                            <td>
                                <a href="@Url.Action("Editar", "Vehiculos", New With {.id = item.Id})" class="btn btn-primary">Editar</a>
                                <a href="@Url.Action("Eliminar", "Vehiculos", New With {.id = item.Id})" class="btn btn-danger">Eliminar</a>
                            </td>
                        </tr>
                    Next
                </Table>
            </div>
        </div>
    </div>
