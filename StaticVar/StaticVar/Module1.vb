Module Module1
    ' Program to demo the use of Shared members
    Class StaticVar
        Public Shared num As Integer
    End Class
    Public Sub count()
        num = num + 1
    End Sub
    Public Shared Function getNum() As Integer
        Return num
    End Function
End Module


