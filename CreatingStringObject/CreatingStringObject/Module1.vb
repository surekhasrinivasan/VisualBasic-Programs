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

        'by using string constructor
        Dim letters As Char() = {"H", "e", "l", "l", "o"}
        greetings = New String(letters)
        Console.WriteLine("Greetings: {0}", greetings)

        'methods return string 
        Dim sarray() As String = {"Hello", "From", "Happy", "Person"}
        Dim message As String = String.Join(" ", sarray)
        Console.WriteLine("Message: {0}", message)

        'formatting method to convert a value
        Dim waiting As DateTime = New DateTime(2012, 12, 12, 17, 58, 1)
        Dim chat As String = String.Format("Message sent at {0:t} on {0:D}", waiting)
        Console.WriteLine("Message: {0}", chat)
        Console.ReadLine()
    End Sub

End Module
