﻿Module Module1
    ' Program to demo Constructor

    ' A class constructor is a special member Sub of a class that is executed whenever we create new objects 
    ' of that class. A constructor has the name New and it does not have any return type.
    Class Line
        Private length As Double    ' length of a line
        Public Sub New() ' constructor
            Console.WriteLine("Object is being created.")
        End Sub

        Public Sub setLength(ByVal len As Double)
            length = len
        End Sub

        Public Function getLength() As Double
            Return length
        End Function
    End Class
    Sub Main()
        Dim line As Line = New Line()

        'set line length
        line.setLength(6.0)
        Console.WriteLine("Length of line : {0}", line.getLength())
        Console.ReadKey()
    End Sub
End Module
