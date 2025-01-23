using System;

class Question14
{
    public void FactorialWhileLoop()
    {
        // Taking user input for a number
        Console.Write("Enter a positive integer: ");
        int number = int.Parse(Console.ReadLine());

        if (number >= 0)
        {
            // Calculating factorial using while loop
            int factorial = 1;
            int i = 1;
            while (i <= number)
            {
                factorial *= i;
                i++;
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

