// 12. Write a program that takes the base and height to find the area of a triangle in square inches and square centimeters
// Hint: Area of a Triangle is ½ * base * height
// I/P => base, height
// O/P => Your Height in cm is _45.00__ while in feet is __ and inches is _6.98__


using System;

class Question12
{
    public void TriangleArea()
    {
        // Take user inputs for base and height of the triangle
        Console.Write("Enter the base of the triangle in cm: ");
        double baseCm = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter the height of the triangle in cm: ");
        double heightCm = Convert.ToDouble(Console.ReadLine());

        // Calculate area in square centimeters and square inches
        double areaCm = 0.5 * baseCm * heightCm;
        double areaInches = areaCm / 6.4516;

        // Display the result
        Console.WriteLine($"The area of the triangle is {areaCm:F2} square centimeters and {areaInches:F2} square inches.");
    }
}
