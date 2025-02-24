
// Advanced Problems
// 10. Validate an IP Address
// A valid IPv4 address consists of four groups of numbers (0-255) separated by dots.
using System;
using System.Text.RegularExpressions;

class Program10
{
    static void Main()
    {
        string[] ipAddresses = { "192.168.1.1", "256.100.50.25", "10.0.0.256", "172.16.254.1" };
        
        foreach (var ip in ipAddresses)
        {
            if (IsValidIPAddress(ip))
            {
                Console.WriteLine($"\"{ip}\" is Valid");
            }
            else
            {
                Console.WriteLine($"\"{ip}\" is Invalid");
            }
        }
    }

    static bool IsValidIPAddress(string ip)
    {
        // Regex pattern to match a valid IPv4 address
        string pattern = @"^(25[0-5]|2[0-4][0-9]|1[0-9]{2}|[1-9]?[0-9])(\.(25[0-5]|2[0-4][0-9]|1[0-9]{2}|[1-9]?[0-9])){3}$";
        return Regex.IsMatch(ip, pattern);
    }
}

