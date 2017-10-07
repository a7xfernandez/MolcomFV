@ModelType IEnumerable(Of FlotaVehicular.Modelos.VehiculoModelo)
@Code
ViewData("Title") = "Index"
End Code

<h2>MODELOS</h2>

<p>
    @Html.ActionLink("Crear modelo", "Crear")
</p>
<table class="table">
    <tr>
        <th>
            @Html.DisplayNameFor(Function(model) model.Nombre)
        </th>
        <th></th>
    </tr>

@For Each item In Model
    @<tr>
        <td>
            @Html.DisplayFor(Function(modelItem) item.Nombre)
        </td>
         <td>
             @item.Marca.Nombre.ToString()
         </td>
        <td>
            @Html.ActionLink("Editar", "Editar", New With {.id = item.Id}) |
            @Html.ActionLink("Details", "Details", New With {.id = item.Id }) |
            @Html.ActionLink("Eliminar", "Eliminar", New With {.id = item.Id})
        </td>
    </tr>
Next

</table>
