// 2.               Write a program to find the sum of n natural numbers using recursive method and compare the result with the formulae n*(n+1)/2 and show the result from both computations is correct. 
// Hint => 
// a.               Take the user input number and check whether it's a Natural number, if not exit
// b.               Write a Method to find the sum of n natural numbers using recursion
// c.                Write a Method to find the sum of n natural numbers using the formulae  
//              n*(n+1)/2 
// d.               Compare the two results and print the result
using System;

class Question2
{
    public void SumOfNaturalNumbers()
    {
        Console.Write("Enter a natural number: ");
        int number = int.Parse(Console.ReadLine());

        if (number < 0)
        {
            Console.WriteLine("Not a natural number.");
            return;
        }

        // Calculate sum using recursion
        int sumRecursive = SumRecursive(number);

        // Calculate sum using formula
        int sumFormula = SumFormula(number);

        // Display results
        Console.WriteLine($"Sum using recursion: {sumRecursive}");
        Console.WriteLine($"Sum using formula: {sumFormula}");
        Console.WriteLine($"Both methods give the same result: {sumRecursive == sumFormula}");
    }

    private int SumRecursive(int n)
    {
        if (n == 0)
            return 0;
        return n + SumRecursive(n - 1);
    }

    private int SumFormula(int n)
    {
        return n * (n + 1) / 2;
    }
}
