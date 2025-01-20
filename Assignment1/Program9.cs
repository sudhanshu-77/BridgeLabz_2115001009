/* 4. Calculate Average of Three Numbers
Write a program that takes three numbers as input from the user and prints
their average. */

using System;

class Program9
{
    static void Main()
    {
        Console.Write("Enter the first num ");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the second num ");
        double num2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the third num ");
        double num3 = Convert.ToDouble(Console.ReadLine());

        double average = (num1 + num2 + num3) / 3;
        Console.WriteLine("Average: " + average);
    }
}
