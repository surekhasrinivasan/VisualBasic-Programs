Module Module1
    ' Comparing Strings program
    Sub Main()
        Dim str1, str2 As String
        str1 = "This is Test"
        str2 = "This is Text"

        If (String.Compare(str1, str2) = 0) Then
            Console.WriteLine(str1 + " and " + str2 + "are equal")
        Else
            Console.WriteLine(str1 + "and " + "are not equal")
        End If
        Console.ReadLine()
    End Sub

End Module
