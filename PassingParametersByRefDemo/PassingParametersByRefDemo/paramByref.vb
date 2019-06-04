Module paramByref
    ' Program to demo Passing Parameters by Ref

    ' A reference parameter is a reference to a memory location of a variable. 
    ' When you pass parameters by reference, unlike value parameters, a new storage location is 
    ' Not created for these parameters. The reference parameters represent the same memory location 
    ' as the actual parameters that are supplied to the method.
    Sub swap(ByRef x As Integer, ByRef y As Integer)
        Dim temp As Integer
        temp = x ' save the value of x
        x = y ' put y into x 
        y = temp ' put temp into y
    End Sub
    Sub Main()
        ' local variable definition 
        Dim a As Integer = 100
        Dim b As Integer = 200
        Console.WriteLine("Before swap, value of a : {0}", a)
        Console.WriteLine("Before swap, value of b : {0}", b)
        ' calling a function to swap the values '
        swap(a, b)
        Console.WriteLine("After swap, value of a : {0}", a)
        Console.WriteLine("After swap, value of b : {0}", b)
        Console.ReadLine()
    End Sub

End Module
