Module myfunctions
    ' Program to demo recursive function. 
    ' A function can call itself. This is known as recursion. 
    ' Following Is an example that calculates factorial for a given number using a recursive function

    Function factorial(ByVal num As Integer) As Integer
        ' local variable declaration 
        Dim result As Integer

        If (num = 1) Then
            Return 1
        Else
            result = factorial(num - 1) * num
            Return result
        End If
    End Function
    Sub Main()
        ' calling the factorial method
        Console.WriteLine("Factorial of 6 is : {0}", factorial(5))
        Console.WriteLine("Factorial of 6 is : {0}", factorial(6))
        Console.WriteLine("Factorial of 6 is : {0}", factorial(7))
        Console.WriteLine("Factorial of 6 is : {0}", factorial(8))
        Console.ReadLine()
    End Sub
End Module
