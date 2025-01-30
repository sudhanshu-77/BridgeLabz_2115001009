Strings - Handling strings and common string functions
// Functions - parameter passing, return

// 1. Count Vowels and Consonants
// Problem:
// Write a C# program to count the number of vowels and consonants in a given string.
// using System;

class Program1
{
    static void Main()
    {
        Console.WriteLine("Enter a string:");
        string input = Console.ReadLine();
        int vowels = 0, consonants = 0;

        foreach (char c in input.ToLower())
        {
            if (c >= 'a' && c <= 'z') // Check if the character is a letter
            {
                if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u') // Check for vowels
                    vowels++;
                else
                    consonants++; // If not a vowel, it's a consonant
            }
        }

        Console.WriteLine($"Vowels: {vowels}, Consonants: {consonants}");
    }
}
