// Question9.cs
using System;

class Question9
{
    public void CalculatePower()
    {
        // Taking user input for number and power
        Console.Write("Enter the base number: ");
        int number = int.Parse(Console.ReadLine());
        Console.Write("Enter the power: ");
        int power = int.Parse(Console.ReadLine());

        // Calculating power
        int result = 1;
        for (int i = 1; i <= power; i++)
        {
            result *= number;
        }

        // Displaying the result
        Console.WriteLine($"{number} raised to the power of {power} is {result}");
    }
}
