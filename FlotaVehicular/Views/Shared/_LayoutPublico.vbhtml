@Code
    Layout = "~/Views/Shared/_LayoutMaster.vbhtml"
End Code

<div class="sidebar" data-color="gray">
    <!--

        Tip 1: you can change the color of the sidebar using: data-color="blue | azure | green | orange | red | purple"
        Tip 2: you can also add an image using data-image tag

    -->
    <div class="sidebar-wrapper">
        <div class="logo">
            <a href="@Url.Action("Index", "Home")" class="simple-text">
                FlotaVehicular
            </a>
        </div>
    </div>
</div>
<div class="main-panel">
    <nav class="navbar navbar-default navbar-fixed">
        <div class="container-fluid">
            <div class="collapse navbar-collapse">
                <ul class="nav navbar-nav navbar-right">
                    <li>
                        <a href="@Url.Action("login", "auth")">
                            Iniciar Sesión
                        </a>
                    </li>
                    <li>
                        <a href="@Url.Action("register", "auth")">
                            Registrarse
                        </a>
                    </li>
                </ul>
            </div>
        </div>
    </nav>

    <div class="content">
        <div class="container-fluid">
            @RenderBody()
        </div>
    </div>

</div>