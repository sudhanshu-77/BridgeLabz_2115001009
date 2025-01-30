
// 4. Remove Duplicates from a String
// Problem:
// Write a C# program to remove all duplicate characters from a given string and return the
// modified string.

using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a string:");
        string input = Console.ReadLine();
        string result = "";

        foreach (char c in input)
        {
            if (!result.Contains(c)) // Add character only if it's not already in the result
            {
                result += c;
            }
        }

        Console.WriteLine($"String without duplicates: {result}");
    }
}
