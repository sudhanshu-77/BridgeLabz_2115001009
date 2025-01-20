/* 2. Add Two Numbers
Write a program that takes two numbers as input from the user and prints
their sum. */


using System;

class Program2
{
    static void Main()
    {
        Console.Write("Enter the first number: ");
        int num1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the second number: ");
        int num2 = Convert.ToInt32(Console.ReadLine());

        int sum = num1 + num2;
        Console.WriteLine("The sum is: " + sum);
    }
}
