// Question8.cs
using System;

class Question8
{
    public void FindGreatestFactor()
    {
        // Taking user input for a number
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        // Finding the greatest factor
        int greatestFactor = 1;
        for (int i = number - 1; i >= 1; i--)
        {
            if (number % i == 0)
            {
                greatestFactor = i;
                break;
            }
        }

        // Displaying the result
        Console.WriteLine($"The greatest factor of {number} besides itself is {greatestFactor}");
    }
}
