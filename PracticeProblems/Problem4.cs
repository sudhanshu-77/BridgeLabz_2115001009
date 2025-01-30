
// 4. Problem 4: Date Comparison
// Write a program that:
// ● Takes two date inputs and compares them to check if the first date is
// before, after, or the same as the second date.

// Hint: Use DateTime.Compare(), DateTime.CompareTo(), or direct comparison
// using DateTime methods.

using System;

class Problem4
{
    public void CompareDates()
    {
        // Take two date inputs
        Console.Write("Enter the first date (yyyy-MM-dd): ");
        DateTime firstDate = DateTime.Parse(Console.ReadLine());
        Console.Write("Enter the second date (yyyy-MM-dd): ");
        DateTime secondDate = DateTime.Parse(Console.ReadLine());

        // Compare the dates
        int comparisonResult = DateTime.Compare(firstDate, secondDate);

        // Display the comparison result
        if (comparisonResult < 0)
        {
            Console.WriteLine("The first date is before the second date.");
        }
        else if (comparisonResult > 0)
        {
            Console.WriteLine("The first date is after the second date.");
        }
        else
        {
            Console.WriteLine("The first date is the same as the second date.");
        }
    }
}

