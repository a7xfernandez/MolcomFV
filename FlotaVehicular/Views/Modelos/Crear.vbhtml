@ModelType FlotaVehicular.ModelosVistas.CrearModelo
@Code
    ViewData("Title") = "Crear"
    Dim titulo = "Crear Modelo"
    Dim marcas = ViewData("Marcas")
    If (Model.id > 0) Then
        titulo = "Editar Modelo"
    End If
End Code

<h2>Crear</h2>

@Using (Html.BeginForm()) 
    @Html.AntiForgeryToken()

    @<div class="form-horizontal">
        <h4>@titulo</h4>
        <hr />
        @Html.ValidationSummary(True, "", New With { .class = "text-danger" })
         <div class="form-group">
             @Html.Label("Marca", htmlAttributes:=New With {.class = "control-label col-md-2"})
             <div class="col-md-8">
                 @Html.DropDownList("Marca_Id", New SelectList(marcas, "Id", "Nombre", ""), "--", New With {.class = "form-control"})
             </div>
         </div>

        <div class="form-group">
            @Html.LabelFor(Function(model) model.Nombre, htmlAttributes:=New With {.class = "control-label col-md-2"})
            <div class="col-md-10">
                @Html.EditorFor(Function(model) model.Nombre, New With { .htmlAttributes = New With { .class = "form-control" } })
                @Html.ValidationMessageFor(Function(model) model.Nombre, "", New With { .class = "text-danger" })
            </div>
        </div>

        <div class="form-group">
            <div class="col-md-offset-2 col-md-10">
                <input type="submit" value="Crear" class="btn btn-default" />
            </div>
        </div>
    </div>
End Using

<div>
    @Html.ActionLink("Back to List", "Index")
</div>

@Section Scripts 
    @Scripts.Render("~/bundles/jqueryval")
End Section
