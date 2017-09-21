@ModelType FlotaVehicular.ModelosVistas.CrearVehiculo
@Code
    ViewData("Title") = "Crear"
    Layout = "~/Views/Shared/_Layout.vbhtml"
    Dim marcas = ViewData("Marcas")
    Dim modelos = ViewData("Modelos")

    Dim titulo = "Crear Vehículo"
    If (Model.Id > 0) Then
        titulo = "Editar Vehículo"
    End If
End Code

@Using (Html.BeginForm("Crear", "Vehiculos"))
    @Html.AntiForgeryToken()
    @Html.HiddenFor(Function(model) model.Id)

@<div Class="row">
    <div Class="col-md-6">
        <h2>@titulo</h2>
    </div>
    <div Class="col-md-6 text-right" style="
    padding-top: 40px;
">
        <input type = "submit" value="Guardar" Class="btn btn-primary">

    </div>
</div>


    @<div class="form-horizontal">
    
        <div>
            @Html.ActionLink(HttpUtility.HtmlDecode("&laquo; Regresar a Vehículos"), "Index")
        </div>
        <hr />
        @Html.ValidationSummary(True, "", New With {.class = "text-danger"})
        <div class="row">
            <div class="col-md-6">
                <div class="form-group">
                    @Html.Label("Marca", htmlAttributes:=New With {.class = "control-label col-md-4"})
                    <div class="col-md-8">
                        @Html.DropDownList("Marca", New SelectList(marcas, "Id", "Nombre", ""), "--", New With {.class = "form-control"})
                    </div>
                </div>
            </div>
            <div class="col-md-6">
                <div class="form-group">
                    @Html.LabelFor(Function(model) model.Placa, htmlAttributes:=New With {.class = "control-label col-md-4"})
                    <div class="col-md-8">
                        @Html.EditorFor(Function(model) model.Placa, New With {.htmlAttributes = New With {.class = "form-control"}})
                        @Html.ValidationMessageFor(Function(model) model.Placa, "", New With {.class = "text-danger"})
                    </div>
                </div>
            </div>
        </div>
        <div class="row">
            <div class="col-md-6">
                <div class="form-group">
                    @Html.Label("Modelo", htmlAttributes:=New With {.class = "control-label col-md-4"})
                    <div class="col-md-8">
                        <select id="Modelo_Id" name="Modelo_Id" class="form-control">
                            <option value="" id="Modelo_Id_Empty">--</option>
                            @For Each m In modelos
                                @<option value="@m.Id" data-marca="@m.Marca.Id">@m.Nombre</option>
                            Next
                        </select>
                        @Html.ValidationMessageFor(Function(model) model.Modelo_Id, "", New With {.class = "text-danger"})
                    </div>
                </div>
            </div>
            <div class="col-md-6">
                <div class="form-group">
                    <div class="col-md-offset-4 col-md-8">
                    </div>
                </div>
            </div>
        </div>
        <hr />
        <div class="row">
            <div class="col-md-6">
                <div class="form-group">
                    @Html.LabelFor(Function(model) model.NumeroDeBastidor, htmlAttributes:=New With {.class = "control-label col-md-4"})
                    <div class="col-md-8">
                        @Html.EditorFor(Function(model) model.NumeroDeBastidor, New With {.htmlAttributes = New With {.class = "form-control"}})
                        @Html.ValidationMessageFor(Function(model) model.NumeroDeBastidor, "", New With {.class = "text-danger"})
                    </div>
                </div>

            </div>
            <div class="col-md-6">                
                <div class="form-group">
                    @Html.LabelFor(Function(model) model.FechaDeAdquisicion, htmlAttributes:=New With {.class = "control-label col-md-4"})
                    <div class="col-md-8">
                        @Html.EditorFor(Function(model) model.FechaDeAdquisicion, New With {.htmlAttributes = New With {.class = "form-control"}})
                        @Html.ValidationMessageFor(Function(model) model.FechaDeAdquisicion, "", New With {.class = "text-danger"})
                    </div>
                </div>

                <div class="form-group">
                    @Html.LabelFor(Function(model) model.Valor, htmlAttributes:=New With {.class = "control-label col-md-4"})
                    <div class="col-md-8">
                        @Html.EditorFor(Function(model) model.Valor, New With {.htmlAttributes = New With {.class = "form-control"}})
                        @Html.ValidationMessageFor(Function(model) model.Valor, "", New With {.class = "text-danger"})
                    </div>
                </div>
            </div>
        </div>
        <hr />
        <div class="row">
            <div class="col-md-6">
                
                <div class="form-group">
                    @Html.LabelFor(Function(model) model.NumeroDeAsientos, htmlAttributes:=New With {.class = "control-label col-md-4"})
                    <div class="col-md-8">
                        @Html.EditorFor(Function(model) model.NumeroDeAsientos, New With {.htmlAttributes = New With {.class = "form-control"}})
                        @Html.ValidationMessageFor(Function(model) model.NumeroDeAsientos, "", New With {.class = "text-danger"})
                    </div>
                </div>

                <div class="form-group">
                    @Html.LabelFor(Function(model) model.NumeroDePuertas, htmlAttributes:=New With {.class = "control-label col-md-4"})
                    <div class="col-md-8">
                        @Html.EditorFor(Function(model) model.NumeroDePuertas, New With {.htmlAttributes = New With {.class = "form-control"}})
                        @Html.ValidationMessageFor(Function(model) model.NumeroDePuertas, "", New With {.class = "text-danger"})
                    </div>
                </div>

                <div class="form-group">
                    @Html.LabelFor(Function(model) model.Color, htmlAttributes:=New With {.class = "control-label col-md-4"})
                    <div class="col-md-8">
                        @Html.EditorFor(Function(model) model.Color, New With {.htmlAttributes = New With {.class = "form-control"}})
                        @Html.ValidationMessageFor(Function(model) model.Color, "", New With {.class = "text-danger"})
                    </div>
                </div>
            </div>
            <div class="col-md-6">
                
                <div class="form-group">
                    @Html.LabelFor(Function(model) model.Transmision, htmlAttributes:=New With {.class = "control-label col-md-4"})
                    <div class="col-md-8">
                        @Html.EnumDropDownListFor(Function(model) model.Transmision, htmlAttributes:=New With {.class = "form-control"})
                        @Html.ValidationMessageFor(Function(model) model.Transmision, "", New With {.class = "text-danger"})
                    </div>
                </div>

                <div class="form-group">
                    @Html.LabelFor(Function(model) model.Combustble, htmlAttributes:=New With {.class = "control-label col-md-4"})
                    <div class="col-md-8">
                        @Html.EnumDropDownListFor(Function(model) model.Combustble, htmlAttributes:=New With {.class = "form-control"})
                        @Html.ValidationMessageFor(Function(model) model.Combustble, "", New With {.class = "text-danger"})
                    </div>
                </div>

                <div class="form-group">
                    @Html.LabelFor(Function(model) model.EmisionesCO2, htmlAttributes:=New With {.class = "control-label col-md-4"})
                    <div class="col-md-8">
                        @Html.EditorFor(Function(model) model.EmisionesCO2, New With {.htmlAttributes = New With {.class = "form-control"}})
                        @Html.ValidationMessageFor(Function(model) model.EmisionesCO2, "", New With {.class = "text-danger"})
                    </div>
                </div>

                <div class="form-group">
                    @Html.LabelFor(Function(model) model.CaballosDeFuerza, htmlAttributes:=New With {.class = "control-label col-md-4"})
                    <div class="col-md-8">
                        @Html.EditorFor(Function(model) model.CaballosDeFuerza, New With {.htmlAttributes = New With {.class = "form-control"}})
                        @Html.ValidationMessageFor(Function(model) model.CaballosDeFuerza, "", New With {.class = "text-danger"})
                    </div>
                </div>

                <div class="form-group">
                    @Html.LabelFor(Function(model) model.CaballosDeFuerzaFisicales, htmlAttributes:=New With {.class = "control-label col-md-4"})
                    <div class="col-md-8">
                        @Html.EditorFor(Function(model) model.CaballosDeFuerzaFisicales, New With {.htmlAttributes = New With {.class = "form-control"}})
                        @Html.ValidationMessageFor(Function(model) model.CaballosDeFuerzaFisicales, "", New With {.class = "text-danger"})
                    </div>
                </div>

                <div class="form-group">
                    @Html.LabelFor(Function(model) model.Potencia, htmlAttributes:=New With {.class = "control-label col-md-4"})
                    <div class="col-md-8">
                        @Html.EditorFor(Function(model) model.Potencia, New With {.htmlAttributes = New With {.class = "form-control"}})
                        @Html.ValidationMessageFor(Function(model) model.Potencia, "", New With {.class = "text-danger"})
                    </div>
                </div>
            </div>
        </div>
    
    </div>
End Using

@section scripts 
<script>
    $(document).ready(function () {
        $("#Marca").on('change', function (e) {
            var marca = $("#Marca option:selected").val();
            $("#Modelo_Id").val('');
            $("#Modelo_Id option").hide();
            $("#Modelo_Id_Empty").select();
            $("#Modelo_Id").find("[data-marca='" + marca + "']").show();
        })
        @If (Model.Id > 0) Then

            @:$("#Marca").val('@Model.Marca_Id').trigger('change')
            @:$("#Modelo_Id").val('@Model.Modelo_Id')

        End If
    })
</script>
End Section

