Module myfunctions
    ' Program to find maximum number of two numbers using function
    Function FindMax(ByVal num1 As Integer, ByVal num2 As Integer) As Integer
        ' local variable declaration'
        Dim result As Integer

        If (num1 > num2) Then
            result = num1
        Else
            result = num2
        End If
    End Function

    Sub Main()

    End Sub

End Module
