// Question4.cs
using System;

class Question4
{
    public void FizzBuzzForLoop()
    {
        // Taking user input for a number
        Console.Write("Enter a positive integer: ");
        int number = int.Parse(Console.ReadLine());

        // FizzBuzz using for loop
        if (number > 0)
        {
            for (int i = 1; i <= number; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                    Console.WriteLine("FizzBuzz");
                else if (i % 3 == 0)
                    Console.WriteLine("Fizz");
                else if (i % 5 == 0)
                    Console.WriteLine("Buzz");
                else
                    Console.WriteLine(i);
            }
        }
        else
        {
            Console.WriteLine("Please enter a positive integer.");
        }
    }
}
