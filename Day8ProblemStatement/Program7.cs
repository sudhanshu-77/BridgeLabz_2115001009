// 7. Toggle Case of Characters
// Problem:
// Write a C# program to toggle the case of each character in a given string. Convert
// uppercase letters to lowercase and vice versa.
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a string:");
        string input = Console.ReadLine();
        string toggled = "";

        foreach (char c in input)
        {
            if (c >= 'a' && c <= 'z') // Convert lowercase to uppercase
                toggled += (char)(c - 32);
            else if (c >= 'A' && c <= 'Z') // Convert uppercase to lowercase
                toggled += (char)(c + 32);
            else
                toggled += c; // Keep non-alphabetic characters as is
        }

        Console.WriteLine($"Toggled String: {toggled}");
    }
}
