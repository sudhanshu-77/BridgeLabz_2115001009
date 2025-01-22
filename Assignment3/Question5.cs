// 5. Write a TemperatureConversion program, given the temperature in Fahrenheit as input that outputs the temperature in Celsius
// Hint:
// Create a fahrenheit variable and take the user's input.
// Use the formula: Fahrenheit to Celsius: (°F − 32) x 5/9 = °C
// Assign the result to celsiusResult and print the result.
// I/P => fahrenheit
// O/P => The _18__ Fahrenheit is _-7.777777777777778__ Celsius


using System;

class Question5
{
    public void ConvertFahrenheitToCelsius()
    {
        // Taking temperature in Fahrenheit
        Console.Write("Enter temperature in Fahrenheit: ");
        double fahrenheit = double.Parse(Console.ReadLine());

        // Converting Fahrenheit to Celsius
        double celsius = (fahrenheit - 32) * 5 / 9;

        // Displaying the result
        Console.WriteLine($"The {fahrenheit} Fahrenheit is {celsius} Celsius");
    }
}
