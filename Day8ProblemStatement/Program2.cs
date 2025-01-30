// 2. Reverse a String
// Problem:
// Write a C# program to reverse a given string without using any built-in reverse functions.
using System;

class Program2
{
    static void Main()
    {
        Console.WriteLine("Enter a string:");
        string input = Console.ReadLine();
        string reversed = "";

        for (int i = input.Length - 1; i >= 0; i--) // Loop from the end of the string
        {
            reversed += input[i];
        }

        Console.WriteLine($"Reversed String: {reversed}");
    }
}
