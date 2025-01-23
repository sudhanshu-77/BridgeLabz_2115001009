// Question3.cs
using System;

class Question3
{
    public void CheckHarshadNumber()
    {
        // Taking user input for a number
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());
        int originalNumber = number;
        int sum = 0;

        // Calculating the sum of digits
        while (originalNumber != 0)
        {
            int digit = originalNumber % 10;
            sum += digit;
            originalNumber /= 10;
        }

        // Checking if the number is a Harshad number
        bool isHarshad = number % sum == 0;

        // Displaying the result
        Console.WriteLine($"Is the number {number} a Harshad number? {isHarshad}");
    }
}
