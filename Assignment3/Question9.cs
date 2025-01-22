// 9. An athlete runs in a triangular park with sides provided as input by the user in meters. If the athlete wants to complete a 5 km run, then how many rounds must the athlete complete?
// Hint:
// The perimeter of a triangle is the addition of all sides.
// Rounds = distance / perimeter
// I/P => side1, side2, side3
// O/P => The total number of rounds the athlete will run is _278__ to complete 5 km


using System;

class Question9
{
    public void CalculateAthleteRounds()
    {
        // Taking user input for the sides of the triangular park
        Console.Write("Enter the length of side 1 in meters: ");
        double side1 = double.Parse(Console.ReadLine());
        Console.Write("Enter the length of side 2 in meters: ");
        double side2 = double.Parse(Console.ReadLine());
        Console.Write("Enter the length of side 3 in meters: ");
        double side3 = double.Parse(Console.ReadLine());

        // Calculating the perimeter of the triangle
        double perimeter = side1 + side2 + side3;

        // Calculating the number of rounds to complete 5 km
        double rounds = 5000 / perimeter;

        // Displaying the result
        Console.WriteLine($"The total number of rounds the athlete will run is {Math.Ceiling(rounds)} to complete 5 km");
    }
}
