using System;

class Question1
{
    public void CheckDivisibilityBy5()
    {
        // Taking user input for a number
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        // Checking divisibility by 5
        bool isDivisible = number % 5 == 0;

        // Displaying the result
        Console.WriteLine($"Is the number {number} divisible by 5? {isDivisible}");
    }
}