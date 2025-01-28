// 5.               Extend or Create a UnitConvertor utility class similar to the one shown in the notes to do the following.  Please define static methods for all the UnitConvertor class methods. E.g. 
// public static double ConvertYardsToFeet(double yards) => 
// a.               Method to convert yards to feet and return the value. Use following code to convert  double yards2feet = 3;
// b.               Method to convert feet to yards and return the value. Use following code to convert  double feet2yards = 0.333333;
// c.                Method to convert meters to inches and return the value. Use following code to convert  double meters2inches = 39.3701;
// d.               Method to convert inches to meters and return the value. Use following code to convert  double inches2meters = 0.0254;
// e.               Method to convert inches to centimeters and return the value. Use the following code  double inches2cm = 2.54;
using System;

class Question5
{
    public void UnitConverterExtended()
    {
        Console.WriteLine("Extended Unit Converter");

        // Convert yards to feet
        double yards = 10;
        double feet = ConvertYardsToFeet(yards);
        Console.WriteLine($"{yards} yards is {feet} feet");

        // Convert feet to yards
        feet = 30;
        yards = ConvertFeetToYards(feet);
        Console.WriteLine($"{feet} feet is {yards} yards");

        // Convert meters to inches
        double meters = 2;
        double inches = ConvertMetersToInches(meters);
        Console.WriteLine($"{meters} meters is {inches} inches");

        // Convert inches to meters
        inches = 78.74;
        meters = ConvertInchesToMeters(inches);
        Console.WriteLine($"{inches} inches is {meters} meters");

        // Convert inches to centimeters
        inches = 12;
        double cm = ConvertInchesToCm(inches);
        Console.WriteLine($"{inches} inches is {cm} centimeters");
    }

    public static double ConvertYardsToFeet(double yards)
    {
        double yards2feet = 3;
        return yards * yards2feet;
    }

    public static double ConvertFeetToYards(double feet)
    {
        double feet2yards = 0.333333;
        return feet * feet2yards;
    }

    public static double ConvertMetersToInches(double meters)
    {
        double meters2inches = 39.3701;
        return meters * meters2inches;
    }

    public static double ConvertInchesToMeters(double inches)
    {
        double inches2meters = 0.0254;
        return inches * inches2meters;
    }

    public static double ConvertInchesToCm(double inches)
    {
        double inches2cm = 2.54;
        return inches * inches2cm;
    }
}
