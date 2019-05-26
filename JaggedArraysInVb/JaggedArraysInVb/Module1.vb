Module Module1
    ' Program to demo jagged array. A Jagged array is an array of arrays.
    Sub Main()
        'a jagged array of 5 array of integers
        Dim a As Integer()() = New Integer(4)() {}
        a(0) = New Integer() {0, 0}
        a(1) = New Integer() {1, 2}
        a(2) = New Integer() {2, 4}
        a(3) = New Integer() {3, 6}
        a(4) = New Integer() {4, 8}

        Dim i, j As Integer

        'output each array element's value
        For i = 0 To 4
            For j = 0 To 1
                Console.WriteLine("a[{0},{1}] = {2}", i, j, a(i)(j))
            Next j
        Next i
        Console.ReadKey()
    End Sub

End Module
