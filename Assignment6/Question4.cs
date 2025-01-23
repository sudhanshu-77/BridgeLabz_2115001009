// Question4.cs
using System;

class Question4
{
    public void CheckAbundantNumber()
    {
        // Taking user input for a number
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());
        int sum = 0;

        // Calculating the sum of divisors
        for (int i = 1; i < number; i++)
        {
            if (number % i == 0)
            {
                sum += i;
            }
        }

        // Checking if the number is an Abundant number
        bool isAbundant = sum > number;

        // Displaying the result
        Console.WriteLine($"Is the number {number} an Abundant number? {isAbundant}");
    }
}
