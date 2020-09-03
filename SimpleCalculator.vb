Module SimpleCalculator

    Sub Main()
        Dim userMessage As String
        Dim firstNumber As Integer
        Dim secondNumber As Integer


        Console.WriteLine("Choose a number:")
        userMessage = Console.ReadLine()
        firstNumber = CInt(userMessage)


        Console.WriteLine("Choose a number:")
        userMessage = Console.ReadLine()
        secondNumber = CInt(userMessage)


        Console.WriteLine("Choose one of the following options:")
        Console.WriteLine("1. Sum")
        Console.WriteLine("2. Product")
        Console.WriteLine("3. Difference")
        Console.WriteLine("4. Quotient")


        Console.ReadLine()
    End Sub

End Module
