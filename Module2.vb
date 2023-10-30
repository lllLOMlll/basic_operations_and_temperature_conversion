Module Module2
    Sub Main()
        ' Declaration of variables
        Dim tempInFahrenheit As Double
        Dim tempInCelsius As Double

        ' Get input from user
        Console.WriteLine("Please enter a temperature in Fahrenheit: ")
        tempInFahrenheit = Convert.ToDouble(Console.ReadLine())

        Console.WriteLine("Please enter a temperature in Celsius: ")
        tempInCelsius = Convert.ToDouble(Console.ReadLine())
        Console.WriteLine()

        ' Converting Fahrenheit to Celsius
        Console.WriteLine("Converting Fahrenheit to Celsius")
        Console.WriteLine(tempInFahrenheit & "°F is " & Math.Round((tempInFahrenheit - 32) * 5 / 9, 2) & "°C")
        Console.WriteLine()

        ' Converting Celsius to Fahrenheit
        Console.WriteLine("Converting Celsius to Fahrenheit")
        Console.WriteLine(tempInCelsius & "°C is " & Math.Round((tempInCelsius * 9 / 5) + 32, 2) & "°F")

        Console.Read()

    End Sub
End Module
