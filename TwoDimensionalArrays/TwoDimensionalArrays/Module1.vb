Module Module1
    ' Program to demo Two dimensional arrays 
    Sub Main()
        ' An array with 5 rows and 2 columns'
        Dim a(,) As Integer = {{0, 0}, {1, 2}, {2, 4}, {3, 6}, {4, 8}}
        Dim i, j As Integer

        'Output each array element's values
        For i = 0 To 4
            For j = 0 To 1
                Console.WriteLine("a[{0},{1}] = {2}", i, j, a(i, j))
            Next j
        Next i
        Console.ReadLine()
    End Sub

End Module
