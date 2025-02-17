// StringBuilder Problem 2: Remove Duplicates from a String Using StringBuilder
// Problem: Write a program that uses StringBuilder to remove all duplicate characters from a given string while maintaining the original order.
// using System;
using System.Text;
using System.Collections.Generic;

class Program2
{
    static string RemoveDuplicates(string input)
    {
        HashSet<char> seen = new HashSet<char>();
        StringBuilder sb = new StringBuilder();

        foreach (char c in input)
        {
            if (!seen.Contains(c))
            {
                seen.Add(c);
                sb.Append(c);
            }
        }
        return sb.ToString();
    }

    static void Main()
    {
        string input = "programming";
        string result = RemoveDuplicates(input);
        Console.WriteLine("String without duplicates: " + result);
    }
}

