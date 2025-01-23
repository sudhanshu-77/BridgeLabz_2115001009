// Question5.cs
using System;

class Question5
{
    public void FizzBuzzWhileLoop()
    {
        // Taking user input for a number
        Console.Write("Enter a positive integer: ");
        int number = int.Parse(Console.ReadLine());

        // FizzBuzz using while loop
        if (number > 0)
        {
            int i = 1;
            while (i <= number)
            {
                if (i % 3 == 0 && i % 5 == 0)
                    Console.WriteLine("FizzBuzz");
                else if (i % 3 == 0)
                    Console.WriteLine("Fizz");
                else if (i % 5 == 0)
                    Console.WriteLine("Buzz");
                else
                    Console.WriteLine(i);
                i++;
            }
        }
        else
        {
            Console.WriteLine("Please enter a positive integer.");
        }
    }
}
