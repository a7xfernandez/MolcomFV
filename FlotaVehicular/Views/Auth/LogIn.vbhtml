@Code
    ViewData("Title") = "Log In"
    Layout = "~/Views/Shared/_LayoutPublico.vbhtml"
End Code


<div class="row">
    <div class="col-md-4 col-md-offset-4">
        <div class="card">
            <div class="header">
                <h4 class="title">Iniciar Sesión</h4>
            </div>
            <div class="content">
                @Html.ValidationSummary(True)

                @Using Html.BeginForm()

                    @Html.EditorForModel()
                    @<p>
                        <button class="btn btn-primary" type="submit"> Iniciar Sesión</button>
                    </p>

                End Using
            </div>
        </div>
    </div>
</div>

