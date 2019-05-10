Module decisions
    'Program to demostrates a decision making statement
    Sub Main()
        'local variable definition'
        Dim a As Integer = 10

        'check the boolean condition using if statement'
        If (a < 20) Then
            'if condition is true then print the following'
            Console.WriteLine("a is less than 20")
        End If
        Console.WriteLine("value of a is : {0}", a)
        Console.ReadLine()
    End Sub

End Module
