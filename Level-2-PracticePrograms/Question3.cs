// 3.               Write a program that takes a year as input and outputs the Year is a Leap Year or not 
// Hint => 
// a.               The LeapYear program only works for year >= 1582, corresponding to a year in the 
//                   Gregorian calendar. 
// b.               Also Leap year is divisible by 4 and not divisible by 100 or divisible by 400
// c.                Write a method to check for Leap Year using the conditions a and b
// using System;

class Question3
{
    public void CheckLeapYear()
    {
        Console.Write("Enter a year: ");
        int year = int.Parse(Console.ReadLine());

        // Check if the year is a leap year
        bool isLeapYear = IsLeapYear(year);

        // Display result
        Console.WriteLine($"The year {year} is {(isLeapYear ? "a Leap Year" : "not a Leap Year")}");
    }

    private bool IsLeapYear(int year)
    {
        if (year < 1582)
        {
            Console.WriteLine("The LeapYear program only works for year >= 1582.");
            return false;
        }
        return (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0);
    }
}
