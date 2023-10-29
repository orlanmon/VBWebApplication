Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.Entity
Imports System.Linq
Imports System.Net
Imports System.Web
Imports System.Web.Mvc
Imports VBWebApplication

Namespace Controllers
    Public Class SalesOrderHeadersController
        Inherits System.Web.Mvc.Controller

        Private db As New AdventureWorksLT2016

        ' GET: SalesOrderHeaders
        Function Index() As ActionResult
            Dim salesOrderHeaders = db.SalesOrderHeaders.Include(Function(s) s.Address).Include(Function(s) s.Address1).Include(Function(s) s.Customer)
            Return View(salesOrderHeaders.ToList())
        End Function

        ' GET: SalesOrderHeaders/Details/5
        Function Details(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim salesOrderHeader As SalesOrderHeader = db.SalesOrderHeaders.Find(id)
            If IsNothing(salesOrderHeader) Then
                Return HttpNotFound()
            End If
            Return View(salesOrderHeader)
        End Function

        ' GET: SalesOrderHeaders/Create
        Function Create() As ActionResult
            ViewBag.BillToAddressID = New SelectList(db.Addresses, "AddressID", "AddressLine1")
            ViewBag.ShipToAddressID = New SelectList(db.Addresses, "AddressID", "AddressLine1")
            ViewBag.CustomerID = New SelectList(db.Customers, "CustomerID", "Title")
            Return View()
        End Function

        ' POST: SalesOrderHeaders/Create
        'To protect from overposting attacks, enable the specific properties you want to bind to, for 
        'more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Create(<Bind(Include:="SalesOrderID,RevisionNumber,OrderDate,DueDate,ShipDate,Status,OnlineOrderFlag,SalesOrderNumber,PurchaseOrderNumber,AccountNumber,CustomerID,ShipToAddressID,BillToAddressID,ShipMethod,CreditCardApprovalCode,SubTotal,TaxAmt,Freight,TotalDue,Comment,rowguid,ModifiedDate")> ByVal salesOrderHeader As SalesOrderHeader) As ActionResult
            If ModelState.IsValid Then
                db.SalesOrderHeaders.Add(salesOrderHeader)
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            ViewBag.BillToAddressID = New SelectList(db.Addresses, "AddressID", "AddressLine1", salesOrderHeader.BillToAddressID)
            ViewBag.ShipToAddressID = New SelectList(db.Addresses, "AddressID", "AddressLine1", salesOrderHeader.ShipToAddressID)
            ViewBag.CustomerID = New SelectList(db.Customers, "CustomerID", "Title", salesOrderHeader.CustomerID)
            Return View(salesOrderHeader)
        End Function

        ' GET: SalesOrderHeaders/Edit/5
        Function Edit(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim salesOrderHeader As SalesOrderHeader = db.SalesOrderHeaders.Find(id)
            If IsNothing(salesOrderHeader) Then
                Return HttpNotFound()
            End If
            ViewBag.BillToAddressID = New SelectList(db.Addresses, "AddressID", "AddressLine1", salesOrderHeader.BillToAddressID)
            ViewBag.ShipToAddressID = New SelectList(db.Addresses, "AddressID", "AddressLine1", salesOrderHeader.ShipToAddressID)
            ViewBag.CustomerID = New SelectList(db.Customers, "CustomerID", "Title", salesOrderHeader.CustomerID)
            Return View(salesOrderHeader)
        End Function

        ' POST: SalesOrderHeaders/Edit/5
        'To protect from overposting attacks, enable the specific properties you want to bind to, for 
        'more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Edit(<Bind(Include:="SalesOrderID,RevisionNumber,OrderDate,DueDate,ShipDate,Status,OnlineOrderFlag,SalesOrderNumber,PurchaseOrderNumber,AccountNumber,CustomerID,ShipToAddressID,BillToAddressID,ShipMethod,CreditCardApprovalCode,SubTotal,TaxAmt,Freight,TotalDue,Comment,rowguid,ModifiedDate")> ByVal salesOrderHeader As SalesOrderHeader) As ActionResult
            If ModelState.IsValid Then
                db.Entry(salesOrderHeader).State = EntityState.Modified
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            ViewBag.BillToAddressID = New SelectList(db.Addresses, "AddressID", "AddressLine1", salesOrderHeader.BillToAddressID)
            ViewBag.ShipToAddressID = New SelectList(db.Addresses, "AddressID", "AddressLine1", salesOrderHeader.ShipToAddressID)
            ViewBag.CustomerID = New SelectList(db.Customers, "CustomerID", "Title", salesOrderHeader.CustomerID)
            Return View(salesOrderHeader)
        End Function

        ' GET: SalesOrderHeaders/Delete/5
        Function Delete(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim salesOrderHeader As SalesOrderHeader = db.SalesOrderHeaders.Find(id)
            If IsNothing(salesOrderHeader) Then
                Return HttpNotFound()
            End If
            Return View(salesOrderHeader)
        End Function

        ' POST: SalesOrderHeaders/Delete/5
        <HttpPost()>
        <ActionName("Delete")>
        <ValidateAntiForgeryToken()>
        Function DeleteConfirmed(ByVal id As Integer) As ActionResult
            Dim salesOrderHeader As SalesOrderHeader = db.SalesOrderHeaders.Find(id)
            db.SalesOrderHeaders.Remove(salesOrderHeader)
            db.SaveChanges()
            Return RedirectToAction("Index")
        End Function

        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If (disposing) Then
                db.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub
    End Class
End Namespace
