using System;

class Question13
{
    public void SumOfNaturalNumbersForLoop()
    {
        // Taking user input for a number
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        if (number >= 0)
        {
            // Calculating sum using formula
            int sumFormula = number * (number + 1) / 2;

            // Calculating sum using for loop
            int sumLoop = 0;
            for (int i = 1; i <= number; i++)
            {
                sumLoop += i;
            }

            // Displaying the results
            Console.WriteLine($"Sum using formula: {sumFormula}");
            Console.WriteLine($"Sum using for loop: {sumLoop}");
        }
        else
        {
            Console.WriteLine("The number is not a natural number.");
        }
    }
}

