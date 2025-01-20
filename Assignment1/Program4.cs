/* 4. Area of a Circle
Write a program to calculate the area of a circle. Take the radius as input
and use the formula:
Area = π * radius^2. */

using System;

class Program4
{
    static void Main()
    {
        Console.Write("Enter the radius of the circle: ");
        double radius = Convert.ToDouble(Console.ReadLine());

        double area = Math.PI * Math.Pow(radius, 2);
        Console.WriteLine("Area of the circle: " + area);
    }
}
