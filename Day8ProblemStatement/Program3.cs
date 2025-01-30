
// 3. Palindrome String Check
// Problem:
// Write a C# program to check if a given string is a palindrome (a string that reads the
// same forward and backward).
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a string:");
        string input = Console.ReadLine();
        bool isPalindrome = true;

        for (int i = 0, j = input.Length - 1; i < j; i++, j--) // Compare characters from both ends
        {
            if (input[i] != input[j])
            {
                isPalindrome = false;
                break;
            }
        }

        Console.WriteLine(isPalindrome ? "The string is a palindrome." : "The string is not a palindrome.");
    }
}
