<div class="navbar-collapse collapse">
    <ul class="nav nav-pills nav-stacked">
        <li>@Html.ActionLink("Home", "Index", "Home")</li>
        <li>@Html.ActionLink("About", "About", "Home")</li>
        <li>@Html.ActionLink("BootStrap", "Index", "BootStrap")</li>
        <li>@Html.ActionLink("Products", "Index", "Products")</li>
        <li>@Html.ActionLink("Sales Order Headers", "Index", "SalesOrderHeaders")</li>
        <li>@Html.ActionLink("Contact", "Contact", "Home")</li>
        <li class="dropdown">
            <a href="#" class="dropdown-toggle" data-toggle="dropdown" role="button" aria-expanded="false">Dropdown Menu<span class="caret"></span></a>
            <ul class="dropdown-menu" role="menu">
                <li><a href="#">Sub Menu One</a></li>
                <li><a href="#">Sub Menu Two</a></li>
            </ul>
        </li>
        <li class="dropdown">
            <a href="#" class="dropdown-toggle" data-toggle="dropdown" role="button" aria-expanded="false">Dropdown Menu 2<span class="caret"></span></a>
            <ul class="dropdown-menu" role="menu">
                <li><a href="#">Sub Menu 2 One</a></li>
                <li><a href="#">Sub Menu 2 Two</a></li>
            </ul>
        </li>
    </ul>
</div>
