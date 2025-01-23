using System;

class Question15
{
    public void FactorialForLoop()
    {
        // Taking user input for a number
        Console.Write("Enter a positive integer: ");
        int number = int.Parse(Console.ReadLine());

        if (number >= 0)
        {
            // Calculating factorial using for loop
            int factorial = 1;
            for (int i = 1; i <= number; i++)
            {
                factorial *= i;
            }

            // Displaying the result
            Console.WriteLine($"The factorial of {number} is {factorial}");
        }
        else
        {
            Console.WriteLine("The number is not a positive integer.");
        }
    }
}

