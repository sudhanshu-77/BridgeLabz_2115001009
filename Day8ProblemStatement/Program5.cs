// 5. Find the Longest Word in a Sentence
// Problem:
// Write a C# program that takes a sentence as input and returns the longest word in the
// Sentence.
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a sentence:");
        string sentence = Console.ReadLine();
        string longestWord = "";
        string currentWord = "";

        foreach (char c in sentence + " ") // Add a space at the end to process the last word
        {
            if (c != ' ')
            {
                currentWord += c; // Build the current word
            }
            else
            {
                if (currentWord.Length > longestWord.Length) // Check if it's the longest
                {
                    longestWord = currentWord;
                }
                currentWord = ""; // Reset for the next word
            }
        }

        Console.WriteLine($"Longest Word: {longestWord}");
    }
}