// 13. Extract Currency Values from a Text
// Example Text: "The price is $45.99, and the discount is $ 10.50."
// Expected Output:
// $45.99, 10.50
using System;
using System.Text.RegularExpressions;

class Program13
{
    static void Main()
    {
        string input = "The price is $45.99, and the discount is $ 10.50.";
        string pattern = @"\$\s*\d+\.\d{2}";

        MatchCollection matches = Regex.Matches(input, pattern);
        foreach (Match match in matches)
        {
            Console.WriteLine(match.Value.Trim());
        }
    }
}




