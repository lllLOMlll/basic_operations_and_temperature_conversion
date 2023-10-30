Module Module1

    Sub Main()
        ' Declare variables
        Dim num1 As Double
        Dim num2 As Double

        ' Get input from user
        Console.WriteLine("Please enter the first number (num1):")
        num1 = Convert.ToDouble(Console.ReadLine())

        Console.WriteLine("Please enter the second number (num2):")
        num2 = Convert.ToDouble(Console.ReadLine())
        Console.WriteLine()


        ' ADDITION
        Console.WriteLine("ADDITION")
        Console.WriteLine("==========================================================================================================")
        Console.WriteLine(String.Format("The sum of num1 {0} and num2 {1} is equal to {2}.", num1, num2, num1 + num2))
        Console.WriteLine(String.Format("The sum of num2 {0} and num1 {1} is equal to {2}.", num2, num1, num2 + num1))
        Console.WriteLine("==========================================================================================================")
        Console.WriteLine()


        ' SUBSTRACTION
        Console.WriteLine("SUBTRACTION")
        Console.WriteLine("==========================================================================================================")
        Console.WriteLine(String.Format("The difference of num1 {0} and num2 {1} is equal to {2}.", num1, num2, num1 - num2))
        Console.WriteLine(String.Format("The difference of num2 {1} and num1 {0} is equal to {2}.", num1, num2, num2 - num1))
        Console.WriteLine("==========================================================================================================")
        Console.WriteLine()

        ' PRODUCT
        Console.WriteLine("PRODUCT")
        Console.WriteLine("==========================================================================================================")
        Console.WriteLine(String.Format("The product of num1 {0} and num2 {1} is equal to {2}.", num1, num2, num1 * num2))
        Console.WriteLine(String.Format("The product of num2 {1} and num1 {0} is equal to {2}.", num1, num2, num2 * num1))
        Console.WriteLine("==========================================================================================================")
        Console.WriteLine()

        ' DIVISION
        Console.WriteLine("DIVISION")
        Console.WriteLine("==========================================================================================================")
        If num2 <> 0 Then
            Console.WriteLine(String.Format("The quotient of num1 {0} divided by num2 {1} is equal to {2}.", num1, num2, num1 / num2))
            Console.WriteLine("==========================================================================================================")
        Else
            Console.WriteLine("Division by zero is not allowed for num1 / num2.")
            Console.WriteLine("==========================================================================================================")
        End If

        If num1 <> 0 Then
            Console.WriteLine(String.Format("The quotient of num2 {0} divided by num1 {1} is equal to {2}.", num2, num1, num2 / num1))
            Console.WriteLine("==========================================================================================================")
        Else
            Console.WriteLine("Division by zero is not allowed for num2 / num1.")
            Console.WriteLine("==========================================================================================================")
        End If

        Console.Read()
    End Sub

End Module
