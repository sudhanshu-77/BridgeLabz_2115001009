// Question3.cs
using System;

class Question3
{
    public void CheckPrimeNumber()
    {
        // Taking user input for a number
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        // Checking if the number is a prime number
        bool isPrime = number > 1;
        for (int i = 2; i <= Math.Sqrt(number); i++)
        {
            if (number % i == 0)
            {
                isPrime = false;
                break;
            }
        }

        // Displaying the result
        Console.WriteLine($"Is the number {number} a prime number? {isPrime}");
    }
}
