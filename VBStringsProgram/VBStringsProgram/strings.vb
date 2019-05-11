Module strings
    ' Program to demo strings in VB'
    Sub Main()
        ' Creating string object by assigning a string literal to a String variable' 
        Dim fname, lname, fullname As String
        fname = "Rowan"
        lname = "Atkinson"
        fullname = fname + " " + lname
        Console.WriteLine("Fullname : {0}", fullname)
    End Sub

End Module
