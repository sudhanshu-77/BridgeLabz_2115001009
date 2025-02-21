// 2. Handling Division and Input Errors
// 💡 Problem Statement:
// Write a C# program that asks the user to enter two numbers and divides them. Handle possible exceptions such as:
// DivideByZeroException if division by zero occurs.
// FormatException if the user enters a non-numeric value.
// Expected Behavior:
// If the user enters valid numbers, print the result of the division.
// If the user enters 0 as the denominator, catch and handle DivideByZeroException.
// If the user enters a non-numeric value, catch and handle FormatException.
using System;

class DivisionProgram
{
    public static void Main()
    {
        try
        {
            Console.WriteLine("Enter the first number:");
            string input1 = Console.ReadLine();
            double number1 = Convert.ToDouble(input1);

            Console.WriteLine("Enter the second number:");
            string input2 = Console.ReadLine();
            double number2 = Convert.ToDouble(input2);

            double result = number1 / number2;
            Console.WriteLine($"The result of dividing {number1} by {number2} is: {result}");
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Error: Division by zero is not allowed.");
        }
        catch (FormatException)
        {
            Console.WriteLine("Error: Please enter a valid numeric value.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An unexpected error occurred: {ex.Message}");
        }
    }
}

