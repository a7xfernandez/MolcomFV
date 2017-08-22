<!doctype html>
<html lang="en">
<head>
    <meta charset="utf-8" />
    <link rel="icon" type="image/png" href="assets/img/favicon.ico">
    <meta http-equiv="X-UA-Compatible" content="IE=edge,chrome=1" />
    <title>@ViewBag.Title - FlotaVehicular</title>
    <meta content='width=device-width, initial-scale=1.0, maximum-scale=1.0, user-scalable=0' name='viewport' />
    <meta name="viewport" content="width=device-width" />


    <!-- Bootstrap core CSS     -->
    @Styles.Render("~/assets/css/bootstrap.min.css")
    <!-- Animation library for notifications   -->
    @Styles.Render("~/assets/css/animate.min.css")
    <!--  Light Bootstrap Table core CSS    -->
    @Styles.Render("~/assets/css/light-bootstrap-dashboard.css")

    <!--  CSS for Demo Purpose, don't include it in your project     -->
    @Styles.Render("~/assets/css/demo.css")

    <!--     Fonts and icons     -->
    <link href="http://maxcdn.bootstrapcdn.com/font-awesome/4.2.0/css/font-awesome.min.css" rel="stylesheet">
    <link href='http://fonts.googleapis.com/css?family=Roboto:400,700,300' rel='stylesheet' type='text/css'>
    @Styles.Render("~/assets/css/pe-icon-7-stroke.css")
</head>
<body>
    <div class="wrapper">

        @RenderBody()
    </div>

</body>
<!--   Core JS Files   -->
@Scripts.Render("~/assets/js/jquery-1.10.2.js")
@Scripts.Render("~/assets/js/bootstrap.min.js")
<!--  Checkbox, Radio & Switch Plugins -->
@Scripts.Render("~/assets/js/bootstrap-checkbox-radio-switch.js")
<!--  Charts Plugin -->
@Scripts.Render("~/assets/js/chartist.min.js")
<!--  Notifications Plugin    -->
@Scripts.Render("~/assets/js/bootstrap-notify.js")
<!--  Google Maps Plugin    -->
<script type="text/javascript" src="https://maps.googleapis.com/maps/api/js?sensor=false"></script>
<!-- Light Bootstrap Table Core javascript and methods for Demo purpose -->
@Scripts.Render("~/assets/js/light-bootstrap-dashboard.js")
<!-- Light Bootstrap Table DEMO methods, don't include it in your project! -->
@Scripts.Render("~/assets/js/demo.js")
<script type="text/javascript">
    $(document).ready(function () {

        demo.initChartist();


    });
</script>

@RenderSection("scripts", required:=False)
</html>
