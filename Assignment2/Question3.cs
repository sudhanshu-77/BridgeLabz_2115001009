// 3. Create a program to convert the distance of 10.8 kilometers to miles.
// Hint: 1 km = 1.6 miles
// I/P => NONE
// O/P => The distance _10.8__ km in miles is ___6.75

using System;

class Question3
{
    public void ConvertDistance()
    {
        // Create a double variable 'kilometers' and assign value 10.8
        double kilometers = 10.8;

        // Convert kilometers to miles using the formula 1 mile = 1.6 km
        double miles = kilometers / 1.6;

        // Display the result
        Console.WriteLine($"The distance {kilometers} km in miles is {miles:F2}");
    }
}
