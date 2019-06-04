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

    End Sub

End Module
