Module paramByval
    ' Program to demo Passing Parameters by Value
    ' When a method is called, a new storage location is created for each 
    ' value parameter. The values Of the actual parameters are copied into 
    ' them. So, the changes made To the parameter inside the method have 
    ' no effect On the argument.
    Sub swap(ByVal x As Integer, ByVal y As Integer)
        Dim temp As Integer
        temp = x ' save the value of x
        x = y ' put y into x 
        y = temp ' put temp into y
    End Sub
    Sub Main()

    End Sub

End Module
