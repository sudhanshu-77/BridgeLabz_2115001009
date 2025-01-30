
// 6. Factorial Using Recursion:
// Write a program that calculates the factorial of a number using a recursive function.
// ● Include modular code to separate input, calculation, and output processes.

using System;

class Question6
{
    public void FactorialUsingRecursion()
    {
        int number = GetInput("Enter a number to calculate its factorial: ");
        long factorial = CalculateFactorial(number);
        Console.WriteLine($"The factorial of {number} is {factorial}");
    }

    private int GetInput(string prompt)
    {
        Console.Write(prompt);
        return int.Parse(Console.ReadLine());
    }

    private long CalculateFactorial(int number)
    {
        if (number <= 1) return 1;
        return number * CalculateFactorial(number - 1);
    }
}

