Module Module1
    ' A default constructor does not have any parameter, but if you need, a constructor can have parameters. 
    ' Such constructors are called parameterized constructors. This technique helps you To assign initial 
    ' value To an Object at the time Of its creation As shown In the following example 
    Class Line
        Private length As Double ' Length of a line

        Public Sub New(ByVal len As Double) ' parameterized constructor
            Console.WriteLine("Object is being create, length ={0}", len)
        End Sub
    End Class
    Sub Main()

    End Sub

End Module
