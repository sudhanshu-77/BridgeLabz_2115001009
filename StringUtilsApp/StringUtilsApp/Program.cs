using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringUtilsApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringUtils stringUtils = new StringUtils();

            string original = "hello";
            string reversed = stringUtils.Reverse(original);
            Console.WriteLine($"Original: {original}, Reversed: {reversed}");

            string palindrome = "madam";
            bool isPalindrome = stringUtils.IsPalindrome(palindrome);
            Console.WriteLine($"Is '{palindrome}' a palindrome? {isPalindrome}");

            string toUpper = "hello world";
            string upperCased = stringUtils.ToUpperCase(toUpper);
            Console.WriteLine($"Original: {toUpper}, Uppercase: {upperCased}");
        }
    }
}
