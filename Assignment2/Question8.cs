// 8. Create a program to convert distance in kilometers to miles.
// Hint:
// Create a variable km and assign type as double as in double km;
// Create Scanner Object to take user input from Standard Input that is the Keyboard as in Scanner input = new Scanner(System.in);
// Use Scanner Object to take user input for km as in km = input.nextInt();
// Use 1 mile = 1.6 km formulae to calculate miles and show the output
// I/P => km 
// O/P => The total miles is  __15.00___ mile for the given _24__ km


using System;

class Question8
{
    public void ConvertDistanceWithInput()
    {
        // Take user input for kilometers
        Console.Write("Enter the distance in kilometers: ");
        double kilometers = Convert.ToDouble(Console.ReadLine());

        // Convert kilometers to miles
        double miles = kilometers / 1.6;

        // Display the result
        Console.WriteLine($"The total miles is {miles:F2} mile for the given {kilometers} km");
    }
}
