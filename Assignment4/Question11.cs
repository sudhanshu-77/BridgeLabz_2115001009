using System;

class Question11
{
    public void SumUntilZeroOrNegative()
    {
        double total = 0.0;

        // Sum numbers until user enters 0 or a negative number
        while (true)
        {
            Console.Write("Enter a number (0 or negative to stop): ");
            double userInput = double.Parse(Console.ReadLine());
            if (userInput <= 0)
            {
                break;
            }
            total += userInput;
        }

        // Displaying the total sum
        Console.WriteLine($"The total sum is {total}");
    }
}