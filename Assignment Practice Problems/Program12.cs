// 12. Extract Programming Language Names from a Text
// Example Text: "I love Java, Python, and JavaScript, but I haven't tried Go yet."
// Expected Output:
// Java, Python, JavaScript, Go
using System;
using System.Text.RegularExpressions;

class Program12
{
    static void Main()
    {
        string input = "I love Java, Python, and JavaScript, but I haven't tried Go yet.";
        string pattern = @"\b(Java|Python|JavaScript|Go)\b";

        MatchCollection matches = Regex.Matches(input, pattern);
        foreach (Match match in matches)
        {
            Console.WriteLine(match.Value);
        }
    }
}



