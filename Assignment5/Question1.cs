// Question1.cs
using System;

class Question1
{
    public void CheckLeapYear()
    {
         Console.WriteLine("Enter a year:");
        int year = int.Parse(Console.ReadLine());

        // Using multiple if-else statements
        if (year < 1582)
        {
            Console.WriteLine("Invalid year. The Gregorian calendar starts in 1582.");
        }
        else if (year % 4 != 0)
        {
            Console.WriteLine("The year is not a leap year.");
        }
        else if (year % 100 == 0 && year % 400 != 0)
        {
            Console.WriteLine("The year is not a leap year.");
        }
        else
        {
            Console.WriteLine("The year is a leap year.");
        }

        // Using a single if statement with logical operators
        if ((year >= 1582) && ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0)))
        {
            Console.WriteLine("The year is a leap year.");
        }
        else
        {
            Console.WriteLine("The year is not a leap year.");
        }
    }
}
