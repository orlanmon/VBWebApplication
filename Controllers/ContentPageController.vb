Imports System.Web.Mvc
Imports System.Collections.Generic
Imports System.Data.SqlClient



Namespace Controllers

    Public Class SSN
        Implements IComparable

        Public SSNNumber As String
        Public FirstName As String
        Public LastName As String


        Public Sub New(ByVal SSNNumber, ByVal FirstName, ByVal LastName)

            Me.SSNNumber = SSNNumber
            Me.FirstName = FirstName
            Me.LastName = LastName


        End Sub

        Private Function IComparable_CompareTo(obj As Object) As Integer Implements IComparable.CompareTo
            Dim SSNToCompare As SSN
            SSNToCompare = CType(obj, SSN)

            Return Me.SSNNumber.CompareTo(SSNToCompare.SSNNumber)

        End Function
    End Class

    Public Class A

        ReadOnly NumToReturn As Integer

        Public Sub New(ByVal NumToReturn As Integer)

            Me.NumToReturn = NumToReturn

        End Sub

        Public Overridable Function AFunction() As Integer

            Return Me.NumToReturn

        End Function

    End Class

    Public Class B
        Inherits A

        Public Sub New(ByVal NumToReturn As Integer)
            MyBase.New(NumToReturn)
        End Sub
        Public Overrides Function AFunction() As Integer

            Return MyBase.AFunction() + 1

        End Function

    End Class




    Public Class ContentPageController
        Inherits Controller

        Private Function OperationFunc(ByRef p_one As Int16)

            p_one = p_one * 5

        End Function


        ' GET: Content
        Function Index() As ActionResult

            Dim myList As New List(Of Int32)
            Dim maxValue As Int32

            myList.Add(10)
            myList.Add(5)
            myList.Add(12)

            maxValue = myList.Max()

            myList = Nothing


            Dim mySSNList As New List(Of SSN)


            mySSNList.Add(New SSN("123456789", "Orlando", "Monaco"))
            mySSNList.Add(New SSN("123406789", "Gino", "Monaco"))
            mySSNList.Add(New SSN("123416789", "Dina", "Story"))

            mySSNList.Sort()

            For Each SSNO In mySSNList

                System.Diagnostics.Debug.WriteLine(SSNO.SSNNumber)

            Next


            Dim ssnresult = (From ssn In mySSNList Where ssn.SSNNumber.Equals("123456789") Select ssn.FirstName, ssn.LastName, ssn.SSNNumber).FirstOrDefault


            If Not IsNothing(ssnresult) Then

                System.Diagnostics.Debug.WriteLine(ssnresult.FirstName)
                System.Diagnostics.Debug.WriteLine(ssnresult.LastName)
                System.Diagnostics.Debug.WriteLine(ssnresult.SSNNumber)

            End If

            mySSNList.Clear()

            Dim myDictionary As New Dictionary(Of Integer, String)
            Dim myDicionaryValue As String

            myDictionary.Add(1, "Orlando")
            myDictionary.Add(2, "Monaco")

            myDicionaryValue = myDictionary.Item(1)

            myDicionaryValue = myDictionary.Item(2)

            Using objConnection As SqlClient.SqlConnection = New SqlConnection()



            End Using

            Dim parameter As Integer = 5

            Me.OperationFunc(parameter)

            System.Diagnostics.Debug.WriteLine(parameter)


            For Increment As Integer = 0 To 9 Step 1

                System.Diagnostics.Debug.WriteLine(Increment)

            Next

            'Comment!!!!

            Dim classB As B = New B(5)

            System.Diagnostics.Debug.WriteLine(classB.AFunction())

            Return View()
        End Function
    End Class
End Namespace