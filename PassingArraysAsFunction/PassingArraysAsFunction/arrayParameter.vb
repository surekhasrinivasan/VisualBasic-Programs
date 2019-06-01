Module arrayParameter
    ' Program to demo passing array as function 
    Function getAverage(ByVal arr As Integer(), ByVal size As Integer) As Double
        ' local variables 
        Dim i As Integer
        Dim avg As Double
        Dim sum As Integer = 0
        For i = 0 To size - 1
            sum += arr(i)
        Next i
        avg = sum / size
        Return avg
    End Function

    Sub Main()
        ' an int array of 5 elements 
        Dim balance As Integer() = {1000, 2, 3, 17, 50}
        Dim avg As Double

        'pass pointer to the array as argument
        avg = getAverage(balance, 5)

        Console.WriteLine("The average value is: {0}", avg)
        Console.ReadLine()
    End Sub

End Module
