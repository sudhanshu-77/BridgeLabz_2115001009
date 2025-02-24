// 5. Extract All Capitalized Words from a Sentence
// Example Text: "The Eiffel Tower is in Paris and the Statue of Liberty is in New York."
// Expected Output:
// Eiffel, Tower, Paris, Statue, Liberty, New, York
using System;
using System.Text.RegularExpressions;

class Program5
{
    static void Main()
    {
        string input = "The Eiffel Tower is in Paris and the Statue of Liberty is in New York.";
        string pattern = @"\b[A-Z][a-z]*\b";

        MatchCollection matches = Regex.Matches(input, pattern);
        foreach (Match match in matches)
        {
            Console.WriteLine(match.Value);
        }
    }
}




