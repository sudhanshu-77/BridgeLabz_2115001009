/* 5. Convert Kilometers to Miles
Write a program that takes the distance in kilometers as input from the user
and converts it into miles using the formula:
Miles = Kilometers * 0.621371. */

using System;

class Program10
{
    static void Main()
    {
        Console.Write("Enter the distance in kilometers: ");
        double kilometers = Convert.ToDouble(Console.ReadLine());

        double miles = kilometers * 0.621371;
        Console.WriteLine("Distance in miles: " + miles);
    }
}
