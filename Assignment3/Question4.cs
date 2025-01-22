// 4. Write a TemperatureConversion program, given the temperature in Celsius as input that outputs the temperature in Fahrenheit
// Hint:
// Create a celsius variable and take the temperature as user input.
// Use the formula: Celsius to Fahrenheit: (°C × 9/5) + 32 = °F
// Assign the result to fahrenheitResult and print the result.
// I/P => celsius
// O/P => The _12 __ Celsius is _53.6__ Fahrenheit

using System;

class Question4
{
    public void ConvertCelsiusToFahrenheit()
    {
        // Taking temperature in Celsius
        Console.Write("Enter temperature in Celsius: ");
        double celsius = double.Parse(Console.ReadLine());

        // Converting Celsius to Fahrenheit
        double fahrenheit = (celsius * 9 / 5) + 32;

        // Displaying the result
        Console.WriteLine($"The {celsius} Celsius is {fahrenheit} Fahrenheit");
    }
}
