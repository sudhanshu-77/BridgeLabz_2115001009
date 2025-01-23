// Question5.cs
using System;

class Question5
{
    public void DayOfWeek()
    {
        // Taking user input for month, day, and year
        Console.Write("Enter month (1-12): ");
        int m = int.Parse(Console.ReadLine());
        Console.Write("Enter day (1-31): ");
        int d = int.Parse(Console.ReadLine());
        Console.Write("Enter year: ");
        int y = int.Parse(Console.ReadLine());

        // Calculating day of the week
        int y0 = y - (14 - m) / 12;
        int x = y0 + y0 / 4 - y0 / 100 + y0 / 400;
        int m0 = m + 12 * ((14 - m) / 12) - 2;
        int d0 = (d + x + 31 * m0 / 12) % 7;

        // Displaying the result
        Console.WriteLine($"The day of the week is {d0}");
    }
}
