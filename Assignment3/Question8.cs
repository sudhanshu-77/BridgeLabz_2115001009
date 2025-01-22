// 8. Rewrite the Sample Program 2 with user inputs
// Hint:
// Create variables and take user inputs for name, fromCity, viaCity, toCity.
// Create variables and take user inputs for distances: fromToVia and viaToFinalCity in miles.
// Create variables and take the time taken for the journey.
// Finally, print the results and try to understand operator precedence.
// I/P => name, fromCity, viaCity, toCity, fromToVia, viaToFinalCity, timeTaken
// O/P => The results of the trip are: _ 700__, _400 __, and _5__

using System;

class Question8
{
    public void TripDetails()
    {
        // Taking user inputs for trip details
        Console.Write("Enter your name: ");
        string name = Console.ReadLine();
        Console.Write("Enter the starting city: ");
        string fromCity = Console.ReadLine();
        Console.Write("Enter the via city: ");
        string viaCity = Console.ReadLine();
        Console.Write("Enter the destination city: ");
        string toCity = Console.ReadLine();
        Console.Write("Enter the distance from starting city to via city in miles: ");
        double fromToVia = double.Parse(Console.ReadLine());
        Console.Write("Enter the distance from via city to destination city in miles: ");
        double viaToFinalCity = double.Parse(Console.ReadLine());
        Console.Write("Enter the time taken for the journey in hours: ");
        double timeTaken = double.Parse(Console.ReadLine());

        // Displaying the trip details
        Console.WriteLine($"The results of the trip are: {name}, {fromCity} to {viaCity} to {toCity}, covering distances {fromToVia} and {viaToFinalCity} miles in {timeTaken} hours.");
    }
}
