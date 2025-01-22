// Level 2 Practice Programs

// 1. Write a program to take 2 numbers and print their quotient and remainder
// Hint: Use division operator (/) for quotient and modulus operator (%) for remainder
// I/P => number1, number2
// O/P => The Quotient is _0__ and Remainder is _10 __ of two numbers _10__ and _15__

using System;
class Question1
{
    public void CalculateQuotientAndRemainder()
    {
        // Taking user input for two numbers
        Console.Write("Enter the first number: ");
        int number1 = int.Parse(Console.ReadLine());
        Console.Write("Enter the second number: ");
        int number2 = int.Parse(Console.ReadLine());

        // Calculating quotient and remainder
        int quotient = number1 / number2;
        int remainder = number1 % number2;

        // Displaying the result
        Console.WriteLine($"The Quotient is {quotient} and Remainder is {remainder} of two numbers {number1} and {number2}");
    }
}
