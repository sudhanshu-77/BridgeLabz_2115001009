// Replace and Modify Strings
// 8. Replace Multiple Spaces with a Single Space
// Example Input: "This is an example with multiple spaces."
// Expected Output: "This is an example with multiple spaces."
using System;
using System.Text.RegularExpressions;

class Program8
{
    static void Main()
    {
        string input = "This is an example with multiple spaces.";
        string pattern = @"\s+";
        string replacement = " ";

        string result = Regex.Replace(input, pattern, replacement);
        Console.WriteLine(result); // Output: "This is an example with multiple spaces."
    }
}



