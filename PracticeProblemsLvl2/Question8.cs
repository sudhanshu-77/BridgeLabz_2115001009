
// 8. Temperature Converter:
// Write a program that converts temperatures between Fahrenheit and Celsius.
// ● The program should have separate functions for converting from Fahrenheit to
// Celsius and from Celsius to Fahrenheit.

using System;

class Question8
{
    public void TemperatureConverter()
    {
        Console.WriteLine("Choose conversion: 1. Fahrenheit to Celsius 2. Celsius to Fahrenheit");
        int choice = int.Parse(Console.ReadLine());

        if (choice == 1)
        {
            double fahrenheit = GetInput("Enter temperature in Fahrenheit: ");
            double celsius = ConvertFahrenheitToCelsius(fahrenheit);
            Console.WriteLine($"{fahrenheit} Fahrenheit is {celsius} Celsius");
        }
        else if (choice == 2)
        {
            double celsius = GetInput("Enter temperature in Celsius: ");
            double fahrenheit = ConvertCelsiusToFahrenheit(celsius);
            Console.WriteLine($"{celsius} Celsius is {fahrenheit} Fahrenheit");
        }
        else
        {
            Console.WriteLine("Invalid choice.");
        }
    }

    private double GetInput(string prompt)
    {
        Console.Write(prompt);
        return double.Parse(Console.ReadLine());
    }

    private double ConvertFahrenheitToCelsius(double fahrenheit)
    {
        return (fahrenheit - 32) * 5 / 9;
    }

    private double ConvertCelsiusToFahrenheit(double celsius)
    {
        return (celsius * 9 / 5) + 32;
    }
}

