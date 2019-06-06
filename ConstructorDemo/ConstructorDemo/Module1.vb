Module Module1
    ' Program to demo Constructor

    ' A class constructor is a special member Sub of a class that is executed whenever we create new objects 
    ' of that class. A constructor has the name New and it does not have any return type.
    Class Line
        Private length As Double    ' length of a line
        Public Sub New() ' constructor
            Console.WriteLine("Object is being created.")
        End Sub
    End Class
    Sub Main()

    End Sub

End Module
