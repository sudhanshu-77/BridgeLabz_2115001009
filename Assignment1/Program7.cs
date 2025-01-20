/* 2. Perimeter of a Rectangle
Write a program to calculate the perimeter of a rectangle. Take the length
and width as inputs and use the formula:
Perimeter = 2 * (length + width). */

using System;

class Program7
{
    static void Main()
    {
        Console.Write("Enter the length of the rectangle: ");
        double length = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the width of the rectangle: ");
        double width = Convert.ToDouble(Console.ReadLine());

        double perimeter = 2 * (length + width);
        Console.WriteLine("Perimeter of the rectangle: " + perimeter);
    }
}
