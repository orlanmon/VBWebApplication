Imports System.Web.Mvc

Namespace Controllers
    Public Class LogoutController
        Inherits Controller

        ' GET: Logout
        Function Index() As ActionResult
            ControllerContext.HttpContext.Session.Add("MenuVisible", "NotVisible")

            Return RedirectToAction("Index", "Login")
            Return View()
        End Function


    End Class
End Namespace