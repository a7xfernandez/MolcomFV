@ModelType FlotaVehicular.Modelos.VehiculoMarca
@Code
    ViewData("Title") = "Crear"

    Dim titulo = "Crear Marcas"
    If (Model.Id > 0) Then
        titulo = "Editar Marcas"
    End If
End Code

<h2>@titulo</h2>

@Using (Html.BeginForm("Crear", "Marcas"))
    @Html.AntiForgeryToken()
    @Html.HiddenFor(Function(model) model.Id)

    @<div class="form-horizontal">
        <h4>VehiculoMarca</h4>
        <hr />
        @Html.ValidationSummary(True, "", New With {.class = "text-danger"})
        <div class="form-group">
            @Html.LabelFor(Function(model) model.Nombre, htmlAttributes:=New With {.class = "control-label col-md-2"})
            <div class="col-md-10">
                @Html.EditorFor(Function(model) model.Nombre, New With {.htmlAttributes = New With {.class = "form-control"}})
                @Html.ValidationMessageFor(Function(model) model.Nombre, "", New With {.class = "text-danger"})
            </div>
        </div>

        <div class="form-group">
            <div class="col-md-offset-2 col-md-10">
                <input type="submit" value="Create" class="btn btn-default" />
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
