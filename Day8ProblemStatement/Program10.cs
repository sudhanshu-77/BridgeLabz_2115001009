
// 10. Remove a Specific Character from a String
// Problem:
// Write a C# program to remove all occurrences of a specific character from a string.
// Example Input:
// String: "Hello World"
// Character to Remove: 'l'
// Expected Output:
// Modified String: "Heo Word"
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a string:");
        string input = Console.ReadLine();
        Console.WriteLine("Enter the character to remove:");
        char toRemove = Console.ReadLine()[0];
        string result = "";

        foreach (char c in input)
        {
            if (c != toRemove)
                result += c;
        }

        Console.WriteLine($"Modified String: {result}");
    }
}
