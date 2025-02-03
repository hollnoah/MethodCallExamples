Option Explicit On
Option Strict On
Option Compare Text
Module MethodCallExamples

    Sub Main()
        Dim myLuckyNumber As Integer = 7
        Console.WriteLine("Hello from Sub Main")
        Console.WriteLine($"My lucky number is {myLuckyNumber}")
        MyOtherSub() 'calls upon my other sub, like making a very large variable
        Console.WriteLine($"My lucky number is {myLuckyNumber}")

    End Sub

    Sub MyOtherSub()
        Dim myLuckyNumber As Integer = 5
        Console.WriteLine("Hello from MyOtherSub!!")
        Console.WriteLine($"My lucky number is {myLuckyNumber}")

    End Sub
End Module
