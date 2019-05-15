Module mydirectives
    'Example for the usage of #const directive'
#Const age = True
    Sub Main()
#If age Then
        Console.WriteLine("Hello World! Welcome")
#End If
        Console.ReadKey()
    End Sub

End Module
