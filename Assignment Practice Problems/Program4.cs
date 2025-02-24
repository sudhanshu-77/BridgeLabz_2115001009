// Extraction Problems
// 4. Extract All Email Addresses from a Text
// Example Text: "Contact us at support@example.com and info@company.org"
// Expected Output:

// support@example.com
// info@company.org
using System;
using System.Text.RegularExpressions;

class Program4
{
    static void Main()
    {
        string input = "Contact us at support@example.com and info@company.org";
        string pattern = @"[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}";

        MatchCollection matches = Regex.Matches(input, pattern);
        foreach (Match match in matches)
        {
            Console.WriteLine(match.Value);
        }
    }
}





