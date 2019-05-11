Module strings
    ' Program to demo strings in VB'
    Sub Main()
        ' Creating string object by assigning a string literal to a String variable' 
        Dim fname, lname, fullname, greetings As String
        fname = "Rowan"
        lname = "Atkinson"
        fullname = fname + " " + lname
        Console.WriteLine("Fullname : {0}", fullname)

        'by using string constructor'
        Dim letters As Char() = {"H", "e", "l", "l", "o"}
        greetings = New String(letters)
        Console.WriteLine("Greetings: {0}", greetings)

        ' Method returning String'
        Dim sarray() As String = {"Hello", "from", "Csharp", "Team"}
        Dim message As String = String.Join(" ", sarray)
        Console.WriteLine("Message {0}", message)

    End Sub

End Module
