using System;

public class Circle
{
    // Field (Attribute)
    private double radius;

    // Constructor
    public Circle(double radius)
    {
        this.radius = radius;
    }

    // Method to calculate area
    public double CalculateArea()
    {
        return Math.PI * radius * radius;
    }

    // Method to calculate circumference
    public double CalculateCircumference()
    {
        return 2 * Math.PI * radius;
    }

    // Method to display area and circumference
    public void DisplayDetails()
    {
        Console.WriteLine("Radius: " + radius);
        Console.WriteLine("Area: " + CalculateArea());
        Console.WriteLine("Circumference: " + CalculateCircumference());
    }
}

// Main Class to Test
public class Program
{
    public static void Main(string[] args)
    {
        // Create Circle objects
        Circle circle1 = new Circle(5);
        Circle circle2 = new Circle(10);

        // Display details of each circle
        Console.WriteLine("=== Circle 1 ===");
        circle1.DisplayDetails();
        Console.WriteLine("\n=== Circle 2 ===");
        circle2.DisplayDetails();
    }
}
