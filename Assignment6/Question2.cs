// Question2.cs
using System;

class Question2
{
    public void CountDigits()
    {
        // Taking user input for a number
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());
        int count = 0;

        // Counting the number of digits
        while (number != 0)
        {
            number /= 10;
            count++;
        }

        // Displaying the result
        Console.WriteLine($"The number of digits is {count}");
    }
}
