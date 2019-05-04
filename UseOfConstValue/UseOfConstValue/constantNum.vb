Module constantNum

    Sub Main()
        Const PI = 3.14149
        Dim radius, area As Single
        radius = 7
        area = PI * radius * radius
        Console.WriteLine("Area = " & Str(area))
        Console.Read()
    End Sub

End Module
