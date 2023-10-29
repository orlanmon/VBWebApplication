@ModelType IEnumerable(Of VBWebApplication.Product)
@Code
ViewData("Title") = "Index"
End Code

<h2>Index</h2>

<p>
    @Html.ActionLink("Create New", "Create")
</p>
<table class="table">
    <tr>
        <th>
            @Html.DisplayNameFor(Function(model) model.Name)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.ProductNumber)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Color)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.StandardCost)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.ListPrice)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Size)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Weight)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.SellStartDate)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.SellEndDate)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.DiscontinuedDate)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.ThumbNailPhoto)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.ThumbnailPhotoFileName)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.rowguid)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.ModifiedDate)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.ProductCategory.Name)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.ProductModel.Name)
        </th>
        <th></th>
    </tr>

@For Each item In Model
    @<tr>
        <td>
            @Html.DisplayFor(Function(modelItem) item.Name)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.ProductNumber)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.Color)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.StandardCost)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.ListPrice)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.Size)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.Weight)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.SellStartDate)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.SellEndDate)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.DiscontinuedDate)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.ThumbNailPhoto)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.ThumbnailPhotoFileName)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.rowguid)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.ModifiedDate)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.ProductCategory.Name)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.ProductModel.Name)
        </td>
        <td>
            @Html.ActionLink("Edit", "Edit", New With {.id = item.ProductID }) |
            @Html.ActionLink("Details", "Details", New With {.id = item.ProductID }) |
            @Html.ActionLink("Delete", "Delete", New With {.id = item.ProductID })
        </td>
    </tr>
Next

</table>
