@ModelType VBWebApplication.SalesOrderHeader
@Code
    ViewData("Title") = "Details"
End Code

<h2>Details</h2>

<div>
    <h4>SalesOrderHeader</h4>
    <hr />
    <dl class="dl-horizontal">
        <dt>
            @Html.DisplayNameFor(Function(model) model.RevisionNumber)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.RevisionNumber)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.OrderDate)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.OrderDate)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.DueDate)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.DueDate)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.ShipDate)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.ShipDate)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Status)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Status)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.OnlineOrderFlag)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.OnlineOrderFlag)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.SalesOrderNumber)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.SalesOrderNumber)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.PurchaseOrderNumber)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.PurchaseOrderNumber)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.AccountNumber)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.AccountNumber)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.ShipMethod)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.ShipMethod)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.CreditCardApprovalCode)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.CreditCardApprovalCode)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.SubTotal)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.SubTotal)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.TaxAmt)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.TaxAmt)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Freight)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Freight)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.TotalDue)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.TotalDue)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Comment)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Comment)
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
            @Html.DisplayNameFor(Function(model) model.Address.AddressLine1)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Address.AddressLine1)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Address1.AddressLine1)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Address1.AddressLine1)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Customer.Title)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Customer.Title)
        </dd>

    </dl>
</div>
<p>
    @Html.ActionLink("Edit", "Edit", New With { .id = Model.SalesOrderID }) |
    @Html.ActionLink("Back to List", "Index")
</p>
