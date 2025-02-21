// 1. Word Frequency Counter
// Read a text file and count the frequency of each word using a Dictionary<string, int>.
// Example:
// Input: "Hello world, hello Java!"
// Output: { "hello": 2, "world": 1, "java": 1 }
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;

class WordFrequencyCounter
{
    public static Dictionary<string, int> CountWordFrequency(string filePath)
    {
        Dictionary<string, int> wordFrequency = new Dictionary<string, int>();
        string text = File.ReadAllText(filePath).ToLower();
        string[] words = Regex.Split(text, @"\W+");

        foreach (var word in words)
        {
            if (string.IsNullOrWhiteSpace(word))
                continue;

            if (wordFrequency.ContainsKey(word))
            {
                wordFrequency[word]++;
            }
            else
            {
                wordFrequency[word] = 1;
            }
        }

        return wordFrequency;
    }

    static void Main()
    {
        string filePath = "path/to/your/textfile.txt";
        Dictionary<string, int> frequency = CountWordFrequency(filePath);
        foreach (var kvp in frequency)
        {
            Console.WriteLine($"{kvp.Key}: {kvp.Value}");
        }
    }
}

