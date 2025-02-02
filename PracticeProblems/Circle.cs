
// Circle Class
// Write a Circle class with a radius attribute.
// Use constructor chaining to initialize radius with both default and user-provided values.
using System;

class Circle
{
    private double radius;

    // Default constructor
    public Circle() : this(1.0) // Constructor chaining
    {
    }

    // Parameterized constructor
    public Circle(double radius)
    {
        this.radius = radius;
    }

    // Method to display circle details
    public void DisplayCircleDetails()
    {
        Console.WriteLine($"Radius: {radius}");
    }
}

