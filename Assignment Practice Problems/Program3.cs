// 3. Validate a Hex Color Code
// A valid hex color:
// Starts with a #
// Followed by 6 hexadecimal characters (0-9, A-F, a-f).
// Example Inputs & Outputs:
// ✅ "#FFA500" → Valid
// ✅ "#ff4500" → Valid
// ❌ "#123" → Invalid (too short)
using System;
using System.Text.RegularExpressions;

class Program3
{
    static void Main()
    {
        string[] hexColors = { "#FFA500", "#ff4500", "#123", "#ABCDEF", "#123456", "#GHIJKL" };
        
        foreach (var color in hexColors)
        {
            if (IsValidHexColor(color))
            {
                Console.WriteLine($"\"{color}\" is Valid");
            }
            else
            {
                Console.WriteLine($"\"{color}\" is Invalid");
            }
        }
    }

    static bool IsValidHexColor(string color)
    {
        // Regex pattern to match the criteria
        string pattern = @"^#[0-9A-Fa-f]{6}$";
        return Regex.IsMatch(color, pattern);
    }
}

