// Problem 2: Count the Occurrence of a Word in a File Using StreamReader
// Problem: Write a program that reads a file and counts how many times a specific word appears in the file.

using System;
using System.IO;

class Program6
{
    static int CountWordOccurrences(string filePath, string word)
    {
        int count = 0;
        using (StreamReader reader = new StreamReader(filePath))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                string[] words = line.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                foreach (string w in words)
                {
                    if (w.Equals(word, StringComparison.OrdinalIgnoreCase))
                    {
                        count++;
                    }
                }
            }
        }
        return count;
    }

    static void Main()
    {
        string filePath = "example.txt";
        string word = "example";
        int count = CountWordOccurrences(filePath, word);
        Console.WriteLine($"The word '{word}' appears {count} times.");
    }
}

