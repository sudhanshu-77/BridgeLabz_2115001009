// 11.Write a program calculate the wind chill temperature given the temperature and wind speed
// Hint => 
// Write a method to calculate the wind chill temperature using the formula 
// windChill = 35.74 + 0.6215 *temp + (0.4275*temp - 35.75) * windSpeed0.16 
// public double CalculateWindChill(double temperature, double windSpeed)


using System;

class Question11
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
