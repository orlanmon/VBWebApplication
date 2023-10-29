@ModelType VBWebApplication.Product
@Code
    ViewData("Title") = "Details"
End Code

<h2>Details</h2>

<div>
    <h4>Product</h4>
    <hr />
    <dl class="dl-horizontal">
        <dt>
            @Html.DisplayNameFor(Function(model) model.Name)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Name)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.ProductNumber)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.ProductNumber)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Color)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Color)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.StandardCost)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.StandardCost)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.ListPrice)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.ListPrice)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Size)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Size)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Weight)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Weight)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.SellStartDate)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.SellStartDate)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.SellEndDate)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.SellEndDate)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.DiscontinuedDate)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.DiscontinuedDate)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.ThumbNailPhoto)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.ThumbNailPhoto)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.ThumbnailPhotoFileName)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.ThumbnailPhotoFileName)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.rowguid)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.rowguid)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.ModifiedDate)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.ModifiedDate)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.ProductCategory.Name)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.ProductCategory.Name)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.ProductModel.Name)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.ProductModel.Name)
        </dd>

    </dl>
</div>
<p>
    @Html.ActionLink("Edit", "Edit", New With { .id = Model.ProductID }) |
    @Html.ActionLink("Back to List", "Index")
</p>
