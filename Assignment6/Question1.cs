// Question1.cs
using System;

class Question1
{
    public void CheckArmstrongNumber()
    {
        // Taking user input for a number
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());
        int originalNumber = number;
        int sum = 0;

        // Checking if the number is an Armstrong number
        while (originalNumber != 0)
        {
            int digit = originalNumber % 10;
            sum += digit * digit * digit;
            originalNumber /= 10;
        }

        // Displaying the result
        Console.WriteLine($"Is the number {number} an Armstrong number? {sum == number}");
    }
}
