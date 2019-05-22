Module dateNTime
    'Program to demonstrate how to get Current date
    Sub Main()
        Console.WriteLine("Current Date: ")
        Dim dt As Date = Today
        Console.WriteLine("Today's date showing time: {0}", dt)
        Console.WriteLine("Today'S date with day: {0}", dt.ToLongDateString)
        Console.WriteLine("Today's date without showing time: {0}", dt.ToShortDateString)
        Console.ReadLine()
    End Sub

    ''Program to demonstrate how to get Current time
    'Sub Main()
    '    Console.WriteLine("Current Time: ")
    '    Console.WriteLine(Now.ToLongTimeString)
    '    Console.ReadLine()
    'End Sub

    'Program to demonstrate some of the properties and methods of DataAndTime class
    'Sub Main()
    '    Dim birthday As Date
    '    Dim bday As Integer
    '    Dim month As Integer
    '    Dim monthname As String
    '    ' Assign a date using standard short format.
    '    birthday = #8/27/2009#
    '    bday = DateAndTime.Day(birthday)
    '    month = DateAndTime.Month(birthday)
    '    monthname = DateAndTime.MonthName(month)

    '    Console.WriteLine(birthday)
    '    Console.WriteLine(bday)
    '    Console.WriteLine(month)
    '    Console.WriteLine(monthname)
    '    Console.ReadLine()
    'End Sub
End Module
