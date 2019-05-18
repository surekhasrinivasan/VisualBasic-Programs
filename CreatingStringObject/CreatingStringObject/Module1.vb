Module Module1
    ' We can create String Object Using one Of the following methods −
    ' By assigning a String literal To a String variable
    ' By using a String class constructor
    ' By using the string concatenation operator (+)
    ' By retrieving a Property Or calling a method that returns a String
    ' By calling a formatting method To convert a value Or Object To its String representation
    Sub Main()
        Dim fname, lname, fullname, greetings As String
        fname = "John"
        lname = "Smith"
        fullname = fname + " " + lname
        Console.WriteLine("Full Name: {0}", fullname)
    End Sub

End Module
