Module strings
    ' Program to demo Getting a substring
    Sub Main()
        Dim str As String
        str = "Last night I had dream of Mother Teresa"
        Console.WriteLine(str)

        Dim substr As String = str.Substring(26)
        Console.WriteLine(substr)
        Console.ReadLine()
    End Sub

End Module
