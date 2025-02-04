﻿Option Explicit On
Option Strict On
Option Compare Text
Module MethodCallExamples

    Sub Main()
        Dim myLuckyNumber As Integer = 7
        Console.WriteLine("Hello from Sub Main")
        Console.WriteLine($"My lucky number is {myLuckyNumber}")
        Console.WriteLine()
        ' MyOtherSub() 'calls upon my other sub, like making a very large variable
        Sandwich(myLuckyNumber)
        Console.WriteLine("Hello from Sub Main")
        Console.WriteLine($"My lucky number is {myLuckyNumber}")
        Console.WriteLine()
    End Sub

    Sub MyOtherSub()
        Dim myLuckyNumber As Integer = 5
        Console.WriteLine("Hello from MyOtherSub!!")
        Console.WriteLine($"My lucky number is {myLuckyNumber}")
    End Sub

    Sub Sandwich(ByVal myLuckyNumber As Integer)
        Console.WriteLine("Hello from Sandwich!!")
        Console.WriteLine($"My lucky number is {myLuckyNumber}")
        Console.WriteLine()
    End Sub
End Module
