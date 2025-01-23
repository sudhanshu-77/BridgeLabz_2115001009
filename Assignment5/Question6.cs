// Question6.cs
using System;

class Question6
{
    public void CalculateBMI()
    {
        // Get the user's weight and height
        Console.WriteLine("Enter your weight (in kg):");
        double weight = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter your height (in cm):");
        double height = Convert.ToDouble(Console.ReadLine());

        // Calculate the BMI
        double bmi = weight / Math.Pow((height / 100), 2);

        // Determine the weight status
        string status;
        if (bmi <= 18.4)
        {
            status = "Underweight";
        }
        else if (bmi >= 18.5 && bmi <= 24.9)
        {
            status = "Normal";
        }
        else if (bmi >= 25.0 && bmi <= 39.9)
        {
            status = "Overweight";
        }
        else
        {
            status = "Obese";
        }

        // Display the results
        Console.WriteLine($"Your BMI is: {bmi:F2}");
        Console.WriteLine($"Your weight status is: {status}");
    }
}
