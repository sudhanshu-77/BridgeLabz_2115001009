using System;

class Question10
{
    public void SumUntilZero()
    {
        double total = 0.0;
        double userInput;

        // Sum numbers until user enters 0
        do
        {
            Console.Write("Enter a number (0 to stop): ");
            userInput = double.Parse(Console.ReadLine());
            total += userInput;
        } while (userInput != 0);

        // Displaying the total sum
        Console.WriteLine($"The total sum is {total}");
    }
}

