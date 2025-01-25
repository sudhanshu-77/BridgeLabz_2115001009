// An organization took up an exercise to find the Body Mass Index (BMI) of all the persons in the team. For this create a program to find the BMI and display the height, weight, BMI and status of each individual
// Hint => 
// Take input for a number of persons
// Create arrays to store the weight, height, BMI, and weight status of the persons
// Take input for the weight and height of the persons
// Calculate the BMI of all the persons and store them in an array and also find the weight status of the persons
// Display the height, weight, BMI, and weight status of each person
// Use the table to determine the weight status of the person
 
using System;

class Question6
{
    public void  BMICalculator()
    {

         //User to enter the number of persons
        Console.Write("Enter the number of persons: ");
        int numberOfPersons = int.Parse(Console.ReadLine());

        // Arrays to store the height, weight, BMI, and weight status
        double[] heights = new double[numberOfPersons];
        double[] weights = new double[numberOfPersons];
        double[] bmis = new double[numberOfPersons];
        string[] statuses = new string[numberOfPersons];

        // Input weight and height for each person
        for (int i = 0; i < numberOfPersons; i++)
        {
            Console.WriteLine($"\nPerson {i + 1}:");

            // Input height
            Console.Write("Enter height in meters: ");
            heights[i] = double.Parse(Console.ReadLine());

            // Input weight
            Console.Write("Enter weight in kilograms: ");
            weights[i] = double.Parse(Console.ReadLine());
        }

        // Calculate BMI and determine weight status for each person
        for (int i = 0; i < numberOfPersons; i++)
        {
            bmis[i] = weights[i] / (heights[i] * heights[i]); // BMI formula

            // Determine weight status based on BMI
            if (bmis[i] <= 18.4)
                statuses[i] = "Underweight";
            else if (bmis[i] >= 18.5 && bmis[i] <= 24.9)
                statuses[i] = "Normal";
            else if (bmis[i] >= 25.0 && bmis[i] <= 39.9)
                statuses[i] = "Overweight";
            else if (bmis[i] >= 40.0)
                statuses[i] = "Obese";
        }

        // Display height, weight, BMI, and weight status for each person
        Console.WriteLine("\nResults:");
        Console.WriteLine("--------------------------------------------------");
        Console.WriteLine("Person | Height (m) | Weight (kg) | BMI   | Status");
        Console.WriteLine("--------------------------------------------------");
        for (int i = 0; i < numberOfPersons; i++)
        {
            Console.WriteLine($"{i + 1,6} | {heights[i],10:F2} | {weights[i],11:F2} | {bmis[i],5:F1} | {statuses[i]}");
        }
       
    }
}

