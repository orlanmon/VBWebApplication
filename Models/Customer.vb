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

Partial Public Class Customer
    Public Property CustomerID As Integer
    Public Property NameStyle As Boolean
    Public Property Title As String
    Public Property FirstName As String
    Public Property MiddleName As String
    Public Property LastName As String
    Public Property Suffix As String
    Public Property CompanyName As String
    Public Property SalesPerson As String
    Public Property EmailAddress As String
    Public Property Phone As String
    Public Property PasswordHash As String
    Public Property PasswordSalt As String
    Public Property rowguid As System.Guid
    Public Property ModifiedDate As Date

    Public Overridable Property CustomerAddresses As ICollection(Of CustomerAddress) = New HashSet(Of CustomerAddress)
    Public Overridable Property SalesOrderHeaders As ICollection(Of SalesOrderHeader) = New HashSet(Of SalesOrderHeader)

End Class
