//  2. Validate a License Plate Number
// License plate format: Starts with two uppercase letters, followed by four digits.
// Example: "AB1234" is valid, but "A12345" is invalid.

using System;
using System.Text.RegularExpressions;

class Program2
{
    static void Main()
    {
        string[] licensePlates = { "AB1234", "A12345", "XY9876", "1234AB", "CD5678" };
        
        foreach (var plate in licensePlates)
        {
            if (IsValidLicensePlate(plate))
            {
                Console.WriteLine($"\"{plate}\" is Valid");
            }
            else
            {
                Console.WriteLine($"\"{plate}\" is Invalid");
            }
        }
    }

    static bool IsValidLicensePlate(string plate)
    {
        // Regex pattern to match the criteria
        string pattern = @"^[A-Z]{2}\d{4}$";
        return Regex.IsMatch(plate, pattern);
    }
}



