// 10. Write a program that takes your height in centimeters and converts it into feet and inches
// Hint: 1 foot = 12 inches and 1 inch = 2.54 cm
// I/P => height
// O/P => Your Height in cm is _ 6.00__ while in feet is __ 0_ and inches is 2.36___


using System;

class Question10
{
    public void HeightConverter()
    {
        // Take user input for height in centimeters
        Console.Write("Enter your height in centimeters: ");
        double heightCm = Convert.ToDouble(Console.ReadLine());

        // Convert height to feet and inches
        double heightInches = heightCm / 2.54;
        int feet = (int)(heightInches / 12);
        double inches = heightInches % 12;

        // Display the result
        Console.WriteLine($"Your Height in cm is {heightCm:F2} while in feet is {feet} and inches is {inches:F2}");
    }
}
