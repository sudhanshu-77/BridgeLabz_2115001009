// 9. Using Nested try-catch Blocks
// 💡 Problem Statement:
// Write a C# program that:
// Takes an array and a divisor as input.
// Tries to access an element at an index.
// Tries to divide that element by the divisor.
// Uses nested try-catch to handle:
// IndexOutOfRangeException if the index is invalid.
// DivideByZeroException if the divisor is zero.
// Expected Behavior:
// If valid, print the division result.
// If the index is invalid, catch and display "Invalid array index!".
// If division by zero, catch and display "Cannot divide by zero!".
using System;

class NestedTryCatch
{
    public static void Main()
    {
        int[] numbers = { 10, 20, 30, 40, 50 };
        Console.WriteLine("Enter the index of the element you want to access:");
        int index = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the divisor:");
        int divisor = int.Parse(Console.ReadLine());

        try
        {
            // Attempt to access the element at the specified index
            int element = numbers[index];

            try
            {
                // Attempt to divide the element by the divisor
                int result = element / divisor;
                Console.WriteLine($"Result of division: {result}");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Cannot divide by zero!");
            }
        }
        catch (IndexOutOfRangeException)
        {
            Console.WriteLine("Invalid array index!");
        }
    }
}

