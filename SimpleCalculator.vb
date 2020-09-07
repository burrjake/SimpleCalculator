Module SimpleCalculator

    Sub Main()
        Dim userMessage As String
        Dim firstNumber As Integer
        Dim secondNumber As Integer
        Dim quitProgram As Boolean

        quitProgram = False

        Console.WriteLine("Welcome to the simple calculator.")
        Console.WriteLine("Press enter when you are ready to start.")
        Console.ReadLine()

        Do While quitProgram = False

            'ask user to enter number
            Console.WriteLine("Choose a number:")
            userMessage = Console.ReadLine()
            firstNumber = CInt(userMessage)

            'ask user to enter another number
            Console.WriteLine("Choose a number:")
            userMessage = Console.ReadLine()
            secondNumber = CInt(userMessage)

            'present options
            Console.WriteLine("Choose one of the following options:")
            Console.WriteLine("1. Sum")
            Console.WriteLine("2. Product")
            Console.WriteLine("3. Difference")
            Console.WriteLine("4. Quotient")
            userMessage = Console.ReadLine()

            'add first and second numbers if user entered option 1
            If userMessage = "1" Or userMessage = "Sum" Or userMessage = "1. Sum" Or userMessage = "1.Sum" Then
                Console.WriteLine(firstNumber & "+" & secondNumber & "=" & firstNumber + secondNumber)

                ' multiply first and second numbers if user entered option 2
            ElseIf userMessage = "2" Or userMessage = "Product" Or userMessage = "2. Product" Or userMessage = "2.Product" Then
                Console.WriteLine(firstNumber & "*" & secondNumber & "=" & firstNumber * secondNumber)

                'subtract second number from first number if user entered option 3
            ElseIf userMessage = "3" Or userMessage = "Difference" Or userMessage = "3. Difference" Or userMessage = "3.Difference" Then
                Console.WriteLine(firstNumber & "-" & secondNumber & "=" & firstNumber - secondNumber)

                'divide first number by second number if user entered option 4
            ElseIf userMessage = "4" Or userMessage = "Quotient" Or userMessage = "4. Quotient" Or userMessage = "4.Quotient" Then
                Console.WriteLine(firstNumber & "/" & secondNumber & "=" & firstNumber / secondNumber)

                'if user entered an invalid option display message
            Else
                Console.WriteLine("Sorry, that is not a valid option")
            End If

            'prompt user either or not they want to quit
            Console.WriteLine("Press Enter to run, again. Enter Q to quit")
            'if q is entered stop loop and close program
            If Console.ReadLine() = "q" Then
                quitProgram = True
                'if q is not entered clear text and continue program loop
            Else
                quitProgram = False
            End If
            Console.Clear()
        Loop
    End Sub

End Module
