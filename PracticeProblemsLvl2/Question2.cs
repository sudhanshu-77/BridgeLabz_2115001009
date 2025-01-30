
// 2. Maximum of Three Numbers:
// Write a program that takes three integer inputs from the user and finds the maximum of the
// three numbers.
// ● Ensure your program follows best practices for organizing code into modular
// functions, such as separate functions for taking input and calculating the maximum
// Value.

using System;

class Question2
{
    public void FindMaximumOfThree()
    {
        int a = GetInput("Enter the first number: ");
        int b = GetInput("Enter the second number: ");
        int c = GetInput("Enter the third number: ");

        int max = CalculateMaximum(a, b, c);
        Console.WriteLine($"The maximum of the three numbers is: {max}");
    }

    private int GetInput(string prompt)
    {
        Console.Write(prompt);
        return int.Parse(Console.ReadLine());
    }

    private int CalculateMaximum(int a, int b, int c)
    {
        return Math.Max(a, Math.Max(b, c));
    }
}

