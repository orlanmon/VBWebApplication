﻿'------------------------------------------------------------------------------
' <auto-generated>
'    This code was generated from a template.
'
'    Manual changes to this file may cause unexpected behavior in your application.
'    Manual changes to this file will be overwritten if the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Imports System
Imports System.Data.Entity
Imports System.Data.Entity.Infrastructure

Partial Public Class AdventureWorksLT2016
    Inherits DbContext

    Public Sub New()
        MyBase.New("name=AdventureWorksLT2016")
    End Sub

    Protected Overrides Sub OnModelCreating(modelBuilder As DbModelBuilder)
        Throw New UnintentionalCodeFirstException()
    End Sub

    Public Property Addresses() As DbSet(Of Address)
    Public Property Customers() As DbSet(Of Customer)
    Public Property CustomerAddresses() As DbSet(Of CustomerAddress)
    Public Property Products() As DbSet(Of Product)
    Public Property ProductCategories() As DbSet(Of ProductCategory)
    Public Property ProductDescriptions() As DbSet(Of ProductDescription)
    Public Property ProductModels() As DbSet(Of ProductModel)
    Public Property ProductModelProductDescriptions() As DbSet(Of ProductModelProductDescription)
    Public Property SalesOrderDetails() As DbSet(Of SalesOrderDetail)
    Public Property SalesOrderHeaders() As DbSet(Of SalesOrderHeader)
    Public Property Logins() As DbSet(Of Login)

End Class
