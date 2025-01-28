// An athlete runs in a triangular park with sides provided as input by the user in meters. If the athlete wants to complete a 5 km run, then how many rounds must the athlete complete
// Hint => 
// Take user input for 3 sides of a triangle 
// The perimeter of a triangle is the addition of all sides and rounds is distance/perimeter
// Write a Method to compute the number of rounds user needs to do to complete 5km run

using System;

class Question4
{
    public void CheckNumberSign()
    {
        // Taking user input for a number
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        // Checking if the number is positive, negative, or zero
        int result = number > 0 ? 1 : (number < 0 ? -1 : 0);

        // Displaying the result
        Console.WriteLine($"The number {number} is {(result == 1 ? "positive" : (result == -1 ? "negative" : "zero"))}");
    }
}
