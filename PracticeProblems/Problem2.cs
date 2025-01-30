// 2. Problem 2: Date Arithmetic
// Create a program that:
// ● Takes a date input and adds 7 days, 1 month, and 2 years to it.
// ● Then subtracts 3 weeks from the result.
// Hint: Use DateTime.AddDays(), DateTime.AddMonths(), DateTime.AddYears(),
// and DateTime.AddWeeks() methods.

using System;

class Problem2
{
    public void DateArithmetic()
    {
        // Take a date input
        Console.Write("Enter a date (yyyy-MM-dd): ");
        DateTime inputDate = DateTime.Parse(Console.ReadLine());

        // Add 7 days, 1 month, and 2 years
        DateTime newDate = inputDate.AddDays(7).AddMonths(1).AddYears(2);
        Console.WriteLine($"Date after adding 7 days, 1 month, and 2 years: {newDate:yyyy-MM-dd}");

        // Subtract 3 weeks
        newDate = newDate.AddDays(-21);
        Console.WriteLine($"Date after subtracting 3 weeks: {newDate:yyyy-MM-dd}");
    }
}

