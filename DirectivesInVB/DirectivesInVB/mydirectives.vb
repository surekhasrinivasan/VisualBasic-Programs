Module mydirectives
    '    'Example for the usage of #const directive'
    '#Const age = True
    '    Sub Main()
    '#If age Then
    '        Console.WriteLine("Hello World! Welcome")
    '#End If
    '        Console.ReadKey()
    '    End Sub

    'Example for #ExternalSource directive'


    'Example for #If...Then....#Else Directives
#Const classCode = 8
    Sub Main()
#If classCode = 7 Then
              Console.WriteLine("Exam Questions for Class VII")
#ElseIf classCode = 8 Then
        Console.WriteLine("Exam Questions for Class VIII")
#Else
              Console.WriteLine("Exam Questions for Higher Classes")
#End If
        Console.ReadKey()
    End Sub
End Module
