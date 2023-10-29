@ModelType VBWebApplication.Login

@Code
    ViewData("Title") = "Login"
End Code

<!DOCTYPE html>

<html>
<head>
    <meta name="viewport" content="width=device-width" />
    <title>Login</title>
</head>
<body>

    <h2>Login</h2>

    @Using (Html.BeginForm("PerformLogin", "Login"))
        @Html.AntiForgeryToken()

        @<div class="form-horizontal">
    <h4>Please Login</h4>
    <hr />
    @Html.ValidationSummary(True, "", New With {.class = "text-danger"})
    <div class="form-group">
        @Html.LabelFor(Function(model) model.UserName, htmlAttributes:=New With {.class = "control-label col-md-2"})
        <div class="col-md-10">
            @Html.EditorFor(Function(model) model.UserName, New With {.htmlAttributes = New With {.class = "form-control"}})
            @Html.ValidationMessageFor(Function(model) model.UserName, "", New With {.class = "text-danger"})
        </div>
    </div>

    <div class="form-group">
        @Html.LabelFor(Function(model) model.Password, htmlAttributes:=New With {.class = "control-label col-md-2"})
        <div class="col-md-10">
            @Html.EditorFor(Function(model) model.Password, New With {.htmlAttributes = New With {.class = "form-control"}})
            @Html.ValidationMessageFor(Function(model) model.Password, "", New With {.class = "text-danger"})
        </div>
    </div>

    <div>
        <p>@ViewData("LoginMessage")</p>
    </div>

    <div class="form-group">
        <div class="col-md-offset-2 col-md-10">
            <input type="submit" value="Login" class="btn btn-default" />
        </div>
    </div>

</div>
    End Using
</body>
</html>
