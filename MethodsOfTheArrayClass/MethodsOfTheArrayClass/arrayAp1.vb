﻿Module arrayAp1
    ' Program demonstrates use of some of the methods of the Array class
    Sub Main()
        Dim list As Integer() = {34, 72, 13, 44, 25, 30, 10}
        Dim temp As Integer() = list
        Dim i As Integer
        Console.Write("Original Array: ")

        For Each i In list
            Console.Write("{0} ", i)
        Next i
        Console.WriteLine()
    End Sub

End Module