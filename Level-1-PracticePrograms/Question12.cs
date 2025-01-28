
// 12.Write a program to calculate various trigonometric functions using Math class given an angle in degrees
// Hint => 
// Method to calculate various trigonometric functions, Firstly convert to radians and then use Math function to find sine, cosine and tangent.
// public double[] calculateTrigonometricFunctions(double angle)

using System;

class Question12
{
    public void CalculateTrigonometricFunctions()
    {
        // Taking user input for an angle in degrees
        Console.Write("Enter an angle in degrees: ");
        double angle = double.Parse(Console.ReadLine());

        // Converting angle to radians
        double radians = Math.PI * angle / 180.0;

        // Calculating trigonometric functions
        double sine = Math.Sin(radians);
        double cosine = Math.Cos(radians);
        double tangent = Math.Tan(radians);

        // Displaying the results
        Console.WriteLine($"Sine: {sine:F4}, Cosine: {cosine:F4}, Tangent: {tangent:F4}");
    }
}


