// 14. Write a program to find the distance in yards and miles for the distance provided by the user in feet
// Hint: 1 mile = 1760 yards and 1 yard is 3 feet
// I/P => distanceInFeet
// O/P => Your Height in cm is _15__ while in feet is _5.00__ and inches is _0.00__


using System;

class Question14
{
    public void DistanceConversion()
    {
        // Take user input for distance in feet
        Console.Write("Enter the distance in feet: ");
        double distanceFeet = Convert.ToDouble(Console.ReadLine());

        // Convert distance to yards and miles
        double distanceYards = distanceFeet / 3;
        double distanceMiles = distanceYards / 1760;

        // Display the result
        Console.WriteLine($"The distance in feet is {distanceFeet}, which is {distanceYards:F2} yards and {distanceMiles:F2} miles.");
    }
}
