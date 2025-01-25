// Rewrite the above program using multi-dimensional array to store height, weight, and BMI in 2D array for all the persons
// Hint => 
// Take input for a number of persons
// Create a multi-dimensional array to store weight, height and BMI. Also create an to store the weight status of the persons
//        double[][] personData = new double[number][3];
//        String[] weightStatus = new String[number];
// Take input for weight and height of the persons and for negative values, ask the user to enter positive values
// Calculate BMI of all the persons and store them in the personData array and also find the weight status and put them in the weightStatus array
// Display the height, weight, BMI and status of each person
using System;

class Question7
{
    public void  CalculateBMIWith2DArray()
    {      
	  
	  // User to enter the number of persons
        Console.Write("Enter the number of persons: ");
        int numberOfPersons = int.Parse(Console.ReadLine());

        // Multi-dimensional array to store height, weight, and BMI
        double[,] personData = new double[numberOfPersons, 3];
        string[] weightStatus = new string[numberOfPersons];

        // Input weight and height for each person
        for (int i = 0; i < numberOfPersons; i++)
        {
            Console.WriteLine($"\nPerson {i + 1}:");

            // Input height with validation
            do
            {
                Console.Write("Enter height in meters (positive value): ");
                personData[i, 0] = double.Parse(Console.ReadLine());
                if (personData[i, 0] <= 0)
                    Console.WriteLine("Height must be a positive value.");
            } while (personData[i, 0] <= 0);

            // Input weight with validation
            do
            {
                Console.Write("Enter weight in kilograms (positive value): ");
                personData[i, 1] = double.Parse(Console.ReadLine());
                if (personData[i, 1] <= 0)
                    Console.WriteLine("Weight must be a positive value.");
            } while (personData[i, 1] <= 0);
        }

        // Calculate BMI and determine weight status for each person
        for (int i = 0; i < numberOfPersons; i++)
        {
            // Calculate BMI
            personData[i, 2] = personData[i, 1] / (personData[i, 0] * personData[i, 0]); // BMI formula

            // Determine weight status based on BMI
            if (personData[i, 2] <= 18.4)
                weightStatus[i] = "Underweight";
            else if (personData[i, 2] >= 18.5 && personData[i, 2] <= 24.9)
                weightStatus[i] = "Normal";
            else if (personData[i, 2] >= 25.0 && personData[i, 2] <= 39.9)
                weightStatus[i] = "Overweight";
            else if (personData[i, 2] >= 40.0)
                weightStatus[i] = "Obese";
        }

        // Display height, weight, BMI, and weight status for each person
        Console.WriteLine("\nResults:");
        Console.WriteLine("--------------------------------------------------");
        Console.WriteLine("Person | Height (m) | Weight (kg) | BMI   | Status");
        Console.WriteLine("--------------------------------------------------");
        for (int i = 0; i < numberOfPersons; i++)
        {
            Console.WriteLine($"{i + 1,6} | {personData[i, 0],10:F2} | {personData[i, 1],11:F2} | {personData[i, 2],5:F1} | {weightStatus[i]}");
        }
       
    }
}

