Module Module1
    ' A destructor is a special member Sub of a class that is executed whenever an object of its class goes out of scope.

    ' A destructor has the name Finalize and it can neither return a value nor can it take any parameters. 
    ' Destructor can be very useful For releasing resources before coming out Of the program Like 
    ' closing files, releasing memories, etc.
    Class Line
        Private length As Double    ' Length of a line
        Public Sub New()   ' constructor
            Console.WriteLine("Object is being created")
        End Sub
        Protected Overrides Sub Finalize()  ' destructor
            Console.WriteLine("Object is being deleted")
        End Sub
        Public Sub setLength(ByVal len As Double)
            length = len
        End Sub

        Public Function getLength() As Double
            Return length
        End Function

        Sub Main()

        End Sub
    End Class
End Module
