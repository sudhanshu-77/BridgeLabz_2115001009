using System;

class Question16
{
    public void PrintOddEvenNumbers()
    {
        // Taking user input for a number
        Console.Write("Enter a positive integer: ");
        int number = int.Parse(Console.ReadLine());

        if (number >= 0)
        {
            // Printing odd and even numbers
            for (int i = 1; i <= number; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine($"{i} is an even number.");
                }
                else
                {
                    Console.WriteLine($"{i} is an odd number.");
                }
            }
        }
        else
        {
            Console.WriteLine("The number is not a positive integer.");
        }
    }
}

