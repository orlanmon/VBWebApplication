<!DOCTYPE html>
<html>
<head>
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>@ViewBag.Title - My ASP.NET Application</title>
    @Styles.Render("~/Content/css")
    @Scripts.Render("~/bundles/modernizr")
</head>
<body>

    <div Class="navbar  navbar-fixed-top">
        <div Class="container">
            
            @Code If HttpContext.Current.Session("MenuVisible") = "Visible" Then End Code

            <div Class="navbar-header">
                <Button type="button" Class="navbar-toggle" data-toggle="collapse" data-target=".navbar-collapse">
                    <span Class="icon-bar"></span>
                    <span Class="icon-bar"></span>
                    <span Class="icon-bar"></span>
                </Button>
                @Html.ActionLink("Application name", "Index", "Home", New With {.area = ""}, New With {.class = "navbar-brand"})
            </div>
            <div class="navbar-collapse collapse">
                <ul class="nav navbar-nav">
                    <li>@Html.ActionLink("Home", "Index", "Home")</li>
                    <li>@Html.ActionLink("About", "About", "Home")</li>
                    <li>@Html.ActionLink("BootStrap", "Index", "BootStrap")</li>
                    <li>@Html.ActionLink("Products", "Index", "Products")</li>
                    <li>@Html.ActionLink("Content Page", "Index", "ContentPage")</li>
                    <li>@Html.ActionLink("Sales Order Headers", "Index", "SalesOrderHeaders")</li>
                    <li>@Html.ActionLink("Contact", "Contact", "Home")</li>
                    <li>@Html.ActionLink("Logout", "Index", "Logout")</li>
                    <li class="dropdown">
                        <a href="#" class="dropdown-toggle" data-toggle="dropdown" role="button" aria-expanded="false">Dropdown Menu<span class="caret"></span></a>
                        <ul class="dropdown-menu" role="menu">
                            <li><a href="#">Sub Menu One</a></li>
                            <li><a href="#">Sub Menu Two</a></li>
                        </ul>
                    </li>
                </ul>
            </div>
        </div>
        @Code Else End Code

        @Code End If End Code

        </div>
    <div class="container body-content">
        @RenderBody()
        <hr />
        <footer>
            <p>&copy; @DateTime.Now.Year - My ASP.NET Application</p>
        </footer>
    </div>

    @Scripts.Render("~/bundles/jquery")
    @Scripts.Render("~/bundles/bootstrap")
    @RenderSection("scripts", required:=False)
</body>
</html>
