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

    End Sub

End Module
