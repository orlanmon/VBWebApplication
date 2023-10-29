Imports System.Web.Mvc

Namespace Controllers
    Public Class LoginController
        Inherits Controller

        Private db As New AdventureWorksLT2016

        ' GET: Login
        Function Index() As ActionResult

            ViewData("MenuVisible") = "Not_Visible"

            Return View()
        End Function

        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function PerformLogin(<Bind(Include:="UserName,Password")> ByVal login As Login) As ActionResult
            If ModelState.IsValid Then

                Dim loginresult = (From l In db.Logins Where l.UserName.Equals(login.UserName) And l.Password.Equals(login.Password) Select l).FirstOrDefault()

                If IsNothing(loginresult) Then

                    ViewData("LoginMessage") = "Password Incorrect"



                    Return View("index")

                Else

                    ControllerContext.HttpContext.Session("MenuVisible") = "Visible"

                    Return RedirectToAction("Index", "Home")
                End If

            Else
                Return View()
            End If

        End Function




    End Class
End Namespace