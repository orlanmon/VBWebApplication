'------------------------------------------------------------------------------
' <auto-generated>
'    This code was generated from a template.
'
'    Manual changes to this file may cause unexpected behavior in your application.
'    Manual changes to this file will be overwritten if the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Imports System
Imports System.Collections.Generic

Partial Public Class SalesOrderHeader
    Public Property SalesOrderID As Integer
    Public Property RevisionNumber As Byte
    Public Property OrderDate As Date
    Public Property DueDate As Date
    Public Property ShipDate As Nullable(Of Date)
    Public Property Status As Byte
    Public Property OnlineOrderFlag As Boolean
    Public Property SalesOrderNumber As String
    Public Property PurchaseOrderNumber As String
    Public Property AccountNumber As String
    Public Property CustomerID As Integer
    Public Property ShipToAddressID As Nullable(Of Integer)
    Public Property BillToAddressID As Nullable(Of Integer)
    Public Property ShipMethod As String
    Public Property CreditCardApprovalCode As String
    Public Property SubTotal As Decimal
    Public Property TaxAmt As Decimal
    Public Property Freight As Decimal
    Public Property TotalDue As Decimal
    Public Property Comment As String
    Public Property rowguid As System.Guid
    Public Property ModifiedDate As Date

    Public Overridable Property Address As Address
    Public Overridable Property Address1 As Address
    Public Overridable Property Customer As Customer
    Public Overridable Property SalesOrderDetails As ICollection(Of SalesOrderDetail) = New HashSet(Of SalesOrderDetail)

End Class
