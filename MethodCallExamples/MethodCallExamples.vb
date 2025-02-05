Option Explicit On
Option Strict On
Option Compare Text
Module MethodCallExamples

    Sub Main()
        Dim myLuckyNumber As Integer = 7
        'Console.WriteLine("Hello from Sub Main!!")
        'Console.WriteLine($"My lucky number is {myLuckyNumber}")
        'Console.WriteLine()

        ''MyOtherSub() 'calls upon my other sub, like making a very large variable
        ''Sandwich(myLuckyNumber)
        ''Marine(myLuckyNumber)
        'Console.WriteLine("Hello from Sub Main!!")
        'Console.WriteLine($"My lucky number is {myLuckyNumber}")
        'Console.WriteLine()


        'Console.WriteLine(MyActualLuckyNumber)
        'Console.WriteLine(SumOf(5, 7))

        For i = 1 To 10

            Console.WriteLine(RandomNumber())
        Next

    End Sub

    'sub examples *********************************************************

    Sub MyOtherSub()
        Dim myLuckyNumber As Integer = 5
        Console.WriteLine("Hello from MyOtherSub!!")
        Console.WriteLine($"My lucky number is {myLuckyNumber}")
        Console.WriteLine()
    End Sub

    Sub Sandwich(ByVal myLuckyNumber As Integer)
        myLuckyNumber += 5
        Console.WriteLine("Hello from Sandwich!!")
        Console.WriteLine($"My lucky number is {myLuckyNumber}")
        Console.WriteLine()
    End Sub

    Sub Marine(ByRef myLuckyNumber As Integer)
        myLuckyNumber += 7
        Console.WriteLine("Hello from Sub Marine!!")
        Console.WriteLine($"My lucky number is {myLuckyNumber}")
        Console.WriteLine()
    End Sub

    'function examples *******************************************************
    Function MyActualLuckyNumber() As Integer 'works like a sub AND a vairable. Every function has a return
        Return 77
    End Function

    Function SumOf(firstNumber As Integer, secondNumber As Integer) As Integer
        Dim result As Integer
        result = firstNumber + secondNumber
        Return result

    End Function

    Function RandomNumber() As Integer
        Dim myRandomNumber As Single
        Randomize()

        myRandomNumber = Rnd() * 10
        myRandomNumber = Int(myRandomNumber) + 1
        Return CInt(myRandomNumber)

    End Function

End Module
