﻿Module arrayAp1
    ' Program to demo dynamic array. Dynamic arrays are arrays that can be dimensioned 
    ' and re-dimensioned as par the need of the program. You can declare a dynamic 
    ' array using the ReDim statement.
    Sub Main()
        Dim marks() As Integer
        ReDim marks(2)
        marks(0) = 85
        marks(1) = 75
        marks(2) = 90

        ' Preserve keyword helps to preserve the data in an existing array, when you resize it 
        ReDim Preserve marks(10)
        marks(3) = 80
        marks(4) = 76
        marks(5) = 92
        marks(6) = 99
        marks(7) = 79
        marks(8) = 95
        For i = 0 To 10
            Console.WriteLine(i & vbTab & marks(i))
        Next i
        Console.ReadLine()
    End Sub

End Module
