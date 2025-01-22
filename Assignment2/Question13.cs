// 13. Write a program to find the side of the square whose perimeter you read from user
// Hint: Perimeter of Square is 4 times side
// I/P => perimeter
// O/P => The length of the side is _30.00__ whose perimeter is _120___


using System;

class Question13
{
    public void SquareSide()
    {
        // Take user input for the perimeter of the square
        Console.Write("Enter the perimeter of the square: ");
        double perimeter = Convert.ToDouble(Console.ReadLine());

        // Calculate the side length
        double side = perimeter / 4;

        // Display the result
        Console.WriteLine($"The length of the side is {side:F2} whose perimeter is {perimeter}.");
    }
}
