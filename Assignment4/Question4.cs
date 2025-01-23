using System;

class Question4
{
    public void SumOfNaturalNumbers()
    {
        // Taking user input for a number
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        // Checking if the number is a natural number
        if (number >= 0)
        {
            // Calculating the sum of natural numbers
            int sum = number * (number + 1) / 2;
            Console.WriteLine($"The sum of {number} natural numbers is {sum}");
        }
        else
        {
            Console.WriteLine($"The number {number} is not a natural number");
        }
    }
}

