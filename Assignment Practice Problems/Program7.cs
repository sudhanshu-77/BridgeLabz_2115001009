// 7. Extract Links from a Web Page
// Example Text: "Visit https://www.google.com and http://example.org for more info."
// Expected Output:
// https://www.google.com, http://example.org 
using System;
using System.Text.RegularExpressions;

class Program7
{
    static void Main()
    {
        string input = "Visit https://www.google.com and http://example.org for more info.";
        string pattern = @"https?://[^\s]+";

        MatchCollection matches = Regex.Matches(input, pattern);
        foreach (Match match in matches)
        {
            Console.WriteLine(match.Value);
        }
    }
}

