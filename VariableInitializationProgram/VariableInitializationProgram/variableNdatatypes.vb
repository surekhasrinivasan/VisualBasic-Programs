Module variableNdatatypes

    Sub Main()
        Dim a As Short
        Dim b As Integer
        Dim c As Double
        Dim d As Double
        Dim e As Double
        Dim f As Double

        a = 10
        b = 20
        c = a + b
        d = a * b
        e = a - b
        f = a / b

        Console.WriteLine("a = {0}, b = {1}, c = {2}", a, b, c)
        Console.WriteLine("a = {0}, b = {1}, d = {2}", a, b, d)
        Console.WriteLine("a = {0}, b = {1}, c = {2}", a, b, e)
        Console.WriteLine("a = {0}, b = {1}, c = {2}", a, b, f)
        Console.ReadLine()
    End Sub

End Module
