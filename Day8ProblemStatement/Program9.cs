

// 9. Find the Most Frequent Character
// Problem:
// Write a C# program to find the most frequent character in a string.
// Example Input:
// String: "success"
// Expected Output:
// Most Frequent Character: 's'
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a string:");
        string input = Console.ReadLine();
        int[] freq = new int[256]; // ASCII size

        foreach (char c in input)
        {
            freq[c]++;
        }

        char mostFrequent = '\0';
        int maxCount = 0;

        for (int i = 0; i < freq.Length; i++)
        {
            if (freq[i] > maxCount)
            {
                maxCount = freq[i];
                mostFrequent = (char)i;
            }
        }

        Console.WriteLine($"Most Frequent Character: {mostFrequent}");
    }
}
