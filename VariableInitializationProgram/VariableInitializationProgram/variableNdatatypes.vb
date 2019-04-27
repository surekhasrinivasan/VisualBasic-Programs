Module variableNdatatypes

    Sub Main()
        Dim a As Short
        Dim b As Integer
        Dim c As Double
        Dim d As Double

        a = 10
        b = 20
        c = a + b
        d = a * b

        Console.WriteLine("a = {0}, b = {1}, c = {2}", a, b, c)
        Console.WriteLine("a = {0}, b = {1}, d = {2}", a, b, d)
        Console.ReadLine()
    End Sub

End Module
