Module myparamfunc
    ' Program to demo ParamArray. ParamArray allows you to pass an arbitrary number of arguments 
    ' to the procedure. A ParamArray parameter is always declared using ByVal. 
    ' You can supply one Or more arguments To a ParamArray parameter by passing an array Of the 
    ' appropriate data type, a comma-separated list Of values, Or Nothing at all.

    ' Function to add elements of an array
    Function AddElements(ParamArray arr As Integer()) As Integer
        Dim sum As Integer = 0
        Dim i As Integer = 0

        For Each i In arr
            sum += i
        Next i
        Return sum
    End Function
    Sub Main()
        Dim sum, sum2 As Integer
        sum = AddElements(100, 200, 300, 400, 500)
        sum2 = AddElements(11, 22, 33, 44, 55, 66, 77, 88, 99)
        Console.WriteLine("The sum of all the elements in the array is:{0}", sum)
        Console.WriteLine("The sum of all the elements in the array is:{0}", sum2)
        Console.ReadLine()
    End Sub

End Module
