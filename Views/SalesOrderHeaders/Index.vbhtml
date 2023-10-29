@ModelType IEnumerable(Of VBWebApplication.SalesOrderHeader)
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
            @Html.DisplayNameFor(Function(model) model.RevisionNumber)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.OrderDate)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.DueDate)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.ShipDate)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Status)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.OnlineOrderFlag)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.SalesOrderNumber)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.PurchaseOrderNumber)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.AccountNumber)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.ShipMethod)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.CreditCardApprovalCode)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.SubTotal)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.TaxAmt)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Freight)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.TotalDue)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Comment)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.rowguid)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.ModifiedDate)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Address.AddressLine1)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Address1.AddressLine1)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Customer.Title)
        </th>
        <th></th>
    </tr>

@For Each item In Model
    @<tr>
        <td>
            @Html.DisplayFor(Function(modelItem) item.RevisionNumber)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.OrderDate)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.DueDate)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.ShipDate)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.Status)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.OnlineOrderFlag)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.SalesOrderNumber)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.PurchaseOrderNumber)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.AccountNumber)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.ShipMethod)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.CreditCardApprovalCode)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.SubTotal)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.TaxAmt)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.Freight)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.TotalDue)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.Comment)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.rowguid)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.ModifiedDate)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.Address.AddressLine1)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.Address1.AddressLine1)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.Customer.Title)
        </td>
        <td>
            @Html.ActionLink("Edit", "Edit", New With {.id = item.SalesOrderID }) |
            @Html.ActionLink("Details", "Details", New With {.id = item.SalesOrderID }) |
            @Html.ActionLink("Delete", "Delete", New With {.id = item.SalesOrderID })
        </td>
    </tr>
Next

</table>
