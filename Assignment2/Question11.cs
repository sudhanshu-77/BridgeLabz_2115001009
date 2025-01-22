// 11. Write a program to create a basic calculator that can perform addition, subtraction, multiplication, and division. The program should ask for two numbers (floating point) and perform all the operations
// Hint:
// Create a variable number1 and number 2 and take user inputs.
// Perform Arithmetic Operations of addition, subtraction, multiplication, and division and assign the result to a variable and finally print the result
// I/P => number1, number2
// O/P => The addition, subtraction, multiplication and division value of 2 numbers _12__ and __7_ is  __19___, _5___, __84__, and _1.71 __


using System;

class Question11
{
    public void BasicCalculator()
    {
        // Take user inputs for two numbers
        Console.Write("Enter the first number: ");
        double number1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter the second number: ");
        double number2 = Convert.ToDouble(Console.ReadLine());

        // Perform arithmetic operations
        double addition = number1 + number2;
        double subtraction = number1 - number2;
        double multiplication = number1 * number2;
        double division = number2 != 0 ? number1 / number2 : double.NaN;

        // Display the results
        Console.WriteLine($"The addition, subtraction, multiplication, and division of {number1} and {number2} are: {addition}, {subtraction}, {multiplication}, and {division:F2} respectively.");
    }
}
