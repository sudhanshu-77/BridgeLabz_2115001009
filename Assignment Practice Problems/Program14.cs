
// 14. Find Repeating Words in a Sentence
// Example Input: "This is is a repeated repeated word test."
// Expected Output:
// is, repeated
using System;
using System.Text.RegularExpressions;

class Program14
{
    static void Main()
    {
        string input = "This is is a repeated repeated word test.";
        string pattern = @"\b(\w+)\s+\1\b";

        MatchCollection matches = Regex.Matches(input, pattern);
        foreach (Match match in matches)
        {
            Console.WriteLine(match.Groups[1].Value);
        }
    }
}



