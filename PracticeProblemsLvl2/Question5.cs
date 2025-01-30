// 5. Palindrome Checker:
// Write a program that checks if a given string is a palindrome (a word, phrase, or sequence
// that reads the same backward as forward).
// ● Break the program into functions for input, checking the palindrome condition, and
// displaying the result.

using System;

class Question5
{
    public void PalindromeChecker()
    {
        string input = GetInput("Enter a string to check if it's a palindrome: ");
        bool isPalindrome = CheckPalindrome(input);
        Console.WriteLine($"Is the string \"{input}\" a palindrome? {isPalindrome}");
    }

    private string GetInput(string prompt)
    {
        Console.Write(prompt);
        return Console.ReadLine();
    }

    private bool CheckPalindrome(string input)
    {
        int length = input.Length;
        for (int i = 0; i < length / 2; i++)
        {
            if (input[i] != input[length - i - 1])
                return false;
        }
        return true;
    }
}

