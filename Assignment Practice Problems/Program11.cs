// 11. Validate a Credit Card Number (Visa, MasterCard, etc.)
// A Visa card number starts with 4 and has 16 digits.
// A MasterCard starts with 5 and has 16 digits.
using System;
using System.Text.RegularExpressions;

class Program11
{
    static void Main()
    {
        string[] cardNumbers = { "4123456789012345", "5123456789012345", "6123456789012345", "4123456789012" };
        
        foreach (var card in cardNumbers)
        {
            if (IsValidVisaCard(card))
            {
                Console.WriteLine($"\"{card}\" is a Valid Visa Card");
            }
            else if (IsValidMasterCard(card))
            {
                Console.WriteLine($"\"{card}\" is a Valid MasterCard");
            }
            else
            {
                Console.WriteLine($"\"{card}\" is Invalid");
            }
        }
    }

    static bool IsValidVisaCard(string card)
    {
        // Regex pattern for Visa card: starts with 4 and has 16 digits
        string pattern = @"^4\d{15}$";
        return Regex.IsMatch(card, pattern);
    }

    static bool IsValidMasterCard(string card)
    {
        // Regex pattern for MasterCard: starts with 5 and has 16 digits
        string pattern = @"^5\d{15}$";
        return Regex.IsMatch(card, pattern);
    }
}



