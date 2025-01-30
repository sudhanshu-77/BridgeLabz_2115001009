// Problem Statements for Practice in C#
// 1. Problem 1: Time Zones and DateTimeOffset
// Write a program that displays the current time in different time zones:
// ● GMT (Greenwich Mean Time)
// ● IST (Indian Standard Time)
// ● PST (Pacific Standard Time)
// Hint: Use DateTimeOffset and TimeZoneInfo to work with different time zones.

using System;

class Problem1
{
    public void DisplayTimeZones()
    {
        // Display current time in GMT
        DateTimeOffset gmtTime = DateTimeOffset.UtcNow;
        Console.WriteLine($"Current GMT Time: {gmtTime}");

        // Display current time in IST
        TimeZoneInfo istZone = TimeZoneInfo.FindSystemTimeZoneById("India Standard Time");
        DateTimeOffset istTime = TimeZoneInfo.ConvertTime(gmtTime, istZone);
        Console.WriteLine($"Current IST Time: {istTime}");

        // Display current time in PST
        TimeZoneInfo pstZone = TimeZoneInfo.FindSystemTimeZoneById("Pacific Standard Time");
        DateTimeOffset pstTime = TimeZoneInfo.ConvertTime(gmtTime, pstZone);
        Console.WriteLine($"Current PST Time: {pstTime}");
    }
}

