// 15. Validate a Social Security Number (SSN)
// Example Input: "My SSN is 123-45-6789."
// Expected Output:
// ✅ "123-45-6789" is valid
// ❌ "123456789" is invalid
using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        string[] ssns = { "123-45-6789", "123456789", "987-65-4321" };
        
        foreach (var ssn in ssns)
        {
            if (IsValidSSN(ssn))
            {
                Console.WriteLine($"\"{ssn}\" is Valid");
            }
            else
            {
                Console.WriteLine($"\"{ssn}\" is Invalid");
            }
        }
    }

    static bool IsValidSSN(string ssn)
    {
        // Regex pattern to match a valid SSN
        string pattern = @"^\d{3}-\d{2}-\d{4}$";
        return Regex.IsMatch(ssn, pattern);
    }
}

