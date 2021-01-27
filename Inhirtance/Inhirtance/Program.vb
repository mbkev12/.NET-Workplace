Public Class User

    Public Name As String

    Private Location As String

    Public Sub New()

        Console.WriteLine("Student:Computing Science")

    End Sub

    Public Sub GetUserInfo(ByVal loc As String)

        Location = loc

        Console.WriteLine("Name: {0}", Name)

        Console.WriteLine("Location: {0}", Location)

    End Sub

End Class



Public Class Details

    Inherits User

    Public Age As Integer

    Public Sub New()

        Console.WriteLine("College: National College of Ireland")

    End Sub

    Public Sub GetAge()

        Console.WriteLine("Age: {0}", Age)

    End Sub

End Class



Class Program

    Public Shared Sub Main(ByVal args As String())

        Dim d As Details = New Details()

        d.Name = "Kevin Mbiyavanga"

        ' Compile Time Error

        ' d.Location = "Ireland";

        d.Age = 25

        d.GetUserInfo("Ireland")

        d.GetAge()

        Console.WriteLine(vbLf & "Press Any Key to Exit..")

        Console.ReadLine()

    End Sub

End Class