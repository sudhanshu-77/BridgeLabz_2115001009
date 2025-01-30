
// 3. Problem 3: Date Formatting
// Write a program that:
// ● Displays the current date in three different formats:
// o dd/MM/yyyy
// o yyyy-MM-dd
// o EEE, MMM dd, yyyy

// Hint: Use DateTime.ToString() with custom date format strings.

using System;

class Problem3
{
    public void DisplayDateFormats()
    {
        // Get the current date
        DateTime currentDate = DateTime.Now;

        // Display the current date in different formats
        Console.WriteLine($"Current date in dd/MM/yyyy format: {currentDate:dd/MM/yyyy}");
        Console.WriteLine($"Current date in yyyy-MM-dd format: {currentDate:yyyy-MM-dd}");
        Console.WriteLine($"Current date in EEE, MMM dd, yyyy format: {currentDate:ddd, MMM dd, yyyy}");
    }
}

