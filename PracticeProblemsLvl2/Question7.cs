// 7. GCD and LCM Calculator:
// Create a program that calculates the Greatest Common Divisor (GCD) and Least Common
// Multiple (LCM) of two numbers using functions.
// ● Use separate functions for GCD and LCM calculations, showcasing how modular code
// Works.

using System;

class Question7
{
    public void GCDAndLCMCalculator()
    {
        int a = GetInput("Enter the first number: ");
        int b = GetInput("Enter the second number: ");

        int gcd = CalculateGCD(a, b);
        int lcm = CalculateLCM(a, b, gcd);

        Console.WriteLine($"The GCD of {a} and {b} is {gcd}");
        Console.WriteLine($"The LCM of {a} and {b} is {lcm}");
    }

    private int GetInput(string prompt)
    {
        Console.Write(prompt);
        return int.Parse(Console.ReadLine());
    }

    private int CalculateGCD(int a, int b)
    {
        while (b != 0)
        {
            int temp = b;
            b = a % b;
            a = temp;
        }
        return a;
    }

    private int CalculateLCM(int a, int b, int gcd)
    {
        return (a * b) / gcd;
    }
}



