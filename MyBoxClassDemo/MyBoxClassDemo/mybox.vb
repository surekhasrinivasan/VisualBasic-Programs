﻿Module mybox

    ' Program that demonstrates the use of member functions. 

    ' Member variables are attributes Of an Object And they are kept Private To implement encapsulation. These 
    ' variables can only be accessed Using the Public member functions.
    Class Box
        Public length As Double ' Length of a box
        Public breadth As Double 'Breadth of a box
        Public height As Double ' Height of a box 

        Public Sub setLength(ByVal len As Double)
            length = len
        End Sub

        Public Sub setBreadth(ByVal bre As Double)
            breadth = bre
        End Sub

        Public Sub setHeight(ByVal hei As Double)
            height = hei
        End Sub

        Public Function getVolume() As Double
            Return length * breadth * height
        End Function

    End Class
    Sub Main()

    End Sub

End Module


'Module mybox

'    ' Program that demonstrates a example for class like Box class, with three data members, length, breadth and height
'    Class Box
'        Public length As Double ' Length of a box
'        Public breadth As Double 'Breadth of a box
'        Public height As Double ' Height of a box 
'    End Class
'    Sub Main()
'        Dim Box1 As Box = New Box() ' Declare Box1 of type Box
'        Dim Box2 As Box = New Box() ' Declare Box2 of type Box
'        Dim volume As Double = 0.0  ' Store the volume of a box here

'        'box1 specification
'        Box1.height = 5.0
'        Box1.length = 6.0
'        Box1.breadth = 7.0

'        'box2 specification
'        Box2.height = 10.0
'        Box2.length = 12.0
'        Box2.breadth = 13.0

'        'volume of box1
'        volume = Box1.height * Box1.length * Box1.breadth
'        Console.WriteLine("Volume of Box1: {0}", volume)

'        'volume of box2
'        volume = Box2.height * Box2.length * Box2.breadth
'        Console.WriteLine("Volume of Box2: {0}", volume)

'        Console.ReadKey()
'    End Sub

'End Module
