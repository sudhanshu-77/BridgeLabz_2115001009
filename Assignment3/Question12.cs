// 12. Create a program to convert weight in pounds to kilograms.
// Hint:
// 1 pound = 2.2 kg
// I/P => weight (in pounds)
// O/P => The weight of the person in pounds is _78 __ and in kg is _35.45__


using System;

class Question12
{
    public void ConvertWeight()
    {
        // Taking user input for weight in pounds
        Console.Write("Enter the weight in pounds: ");
        double weightPounds = double.Parse(Console.ReadLine());

        // Converting pounds to kilograms
        double weightKg = weightPounds / 2.2;

        // Displaying the result
        Console.WriteLine($"The weight of the person in pounds is {weightPounds} and in kg is {weightKg:F2}");
    }
}
