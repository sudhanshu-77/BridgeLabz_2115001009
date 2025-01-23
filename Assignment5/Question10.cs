// Question10.cs
using System;

class Question10
{
    public void FindFactors()
    {
        // Taking user input for a number
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        // Finding factors
        Console.WriteLine($"Factors of {number} are:");
        for (int i = 1; i <= number; i++)
        {
            if (number % i == 0)
            {
                Console.WriteLine(i);
            }
        }
    }
}
