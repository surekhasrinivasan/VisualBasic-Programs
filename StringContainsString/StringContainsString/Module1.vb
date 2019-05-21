Module Module1
    'Program to demo string contains string'
    Sub Main()
        Dim str1 As String
        str1 = "This is test"

        If (str1.Contains("test")) Then
            Console.WriteLine("The string 'test' was found in the string.")
        End If
        Console.ReadLine()
    End Sub

End Module
