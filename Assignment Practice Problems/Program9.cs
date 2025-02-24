// 9. Censor Bad Words in a Sentence
// Given a list of bad words, replace them with ****.
// Example Input: "This is a damn bad example with some stupid words."
// Expected Output: "This is a **** bad example with some **** words."
using System;
using System.Text.RegularExpressions;

class Program9
{
    static void Main()
    {
        string input = "This is a damn bad example with some stupid words.";
        string[] badWords = { "damn", "stupid" };
        string pattern = string.Join("|", badWords);

        string result = Regex.Replace(input, pattern, "****", RegexOptions.IgnoreCase);
        Console.WriteLine(result); 
    }
}



