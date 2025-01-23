using System;

class Question12
{
    public void SumOfNaturalNumbersWhileLoop()
    {
        // Taking user input for a number
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        if (number >= 0)
        {
            // Calculating sum using formula
            int sumFormula = number * (number + 1) / 2;

            // Calculating sum using while loop
            int sumLoop = 0;
            int i = 1;
            while (i <= number)
            {
                sumLoop += i;
                i++;
            }

            // Displaying the results
            Console.WriteLine($"Sum using formula: {sumFormula}");
            Console.WriteLine($"Sum using while loop: {sumLoop}");
        }
        else
        {
            Console.WriteLine("The number is not a natural number.");
        }
    }
}

