
Module Exercise
    Public Class Calculations
        Public Numbers As Double

        Function CalculateNumbers() As Double
            Return Numbers * 4
        End Function

        Function CalculateNumbers2() As Double
            Return Numbers * Numbers
        End Function
    End Class

    Public Function Main() As Integer
        Dim Num As Calculations = New Calculations

        Console.Write("Enter Numbers: ")
        Num.Numbers = Double.Parse(Console.ReadLine())

        Console.WriteLine()
        Console.WriteLine("Calculation Program")
        Console.WriteLine("Numbers:      {0:F}", Num.Numbers)
        Console.WriteLine("Numbers to Multiply: {0:F}", Num.CalculateNumbers())
        Console.WriteLine("Numbers to Multiply:      {0:F}", Num.CalculateNumbers2())

        Return 0
    End Function

End Module


