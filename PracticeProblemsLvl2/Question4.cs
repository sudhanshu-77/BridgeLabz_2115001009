// Additional Problem Statements:
// 4. Fibonacci Sequence Generator:
// Write a program that generates the Fibonacci sequence up to a specified number of terms
// entered by the user.
// ● Organize the code by creating a function that calculates and prints the Fibonacci
// Sequence.

using System;

class Question4
{
    public void FibonacciSequenceGenerator()
    {
        int terms = GetInput("Enter the number of terms for the Fibonacci sequence: ");
        GenerateFibonacci(terms);
    }

    private int GetInput(string prompt)
    {
        Console.Write(prompt);
        return int.Parse(Console.ReadLine());
    }

    private void GenerateFibonacci(int terms)
    {
        int a = 0, b = 1, c;
        Console.WriteLine("Fibonacci Sequence:");
        for (int i = 0; i < terms; i++)
        {
            Console.WriteLine(a);
            c = a + b;
            a = b;
            b = c;
        }
    }
}

