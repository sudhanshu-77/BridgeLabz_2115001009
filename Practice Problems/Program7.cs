// 7. Demonstrating finally Block Execution
// 💡 Problem Statement:
// Write a program that performs integer division and demonstrates the finally block execution.
// The program should:
// Take two integers from the user.
// Perform division.
// Handle DivideByZeroException (if dividing by zero).
// Ensure "Operation completed" is always printed using finally.
// Expected Behavior:
// If valid, print the result.
// If an exception occurs, handle it and still print "Operation completed".
using System;

class DivisionDemo
{
    public static void Main()
    {
        try
        {
            Console.WriteLine("Enter the first integer:");
            int numerator = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the second integer:");
            int denominator = int.Parse(Console.ReadLine());

            int result = numerator / denominator;
            Console.WriteLine($"Result: {result}");
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Error: Cannot divide by zero.");
        }
        catch (FormatException)
        {
            Console.WriteLine("Error: Please enter valid integers.");
        }
        finally
        {
            Console.WriteLine("Operation completed.");
        }
    }
}



