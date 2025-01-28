// 10.            An organization took up the exercise to find the Body Mass Index (BMI) of all the persons in the team of 10 members. For this create a program to find the BMI and display the height, weight, BMI and status of each individual
// Hint => 
// a.               Take user input in double for the weight (in kg) of the person and height (in cm) for the person and store it in the corresponding 2D array of 10 rows and 3 columns. The First Column storing the weight, the second column storing the height in cm and the third column is the BMI
// b.               Create a Method to find the BMI of every person and populate the array. Use the formula BMI = weight / (height * height). Note unit is kg/m^2. For this convert cm to meter
// c.                Create a Method to determine the BMI status using the logic shown in the figure below. and return the array of all the persons BMI Status. 
           

using System;

class Question10
{
    public void CalculateBMI()
    {
        double[,] personData = new double[10, 3];
        string[] bmiStatus = new string[10];

        // Input weight and height
        for (int i = 0; i < 10; i++)
        {
            Console.Write($"Enter weight for person {i + 1} in kg: ");
            personData[i, 0] = double.Parse(Console.ReadLine());
            Console.Write($"Enter height for person {i + 1} in cm: ");
            personData[i, 1] = double.Parse(Console.ReadLine());

            // Calculate BMI
            personData[i, 2] = CalculateBMI(personData[i, 0], personData[i, 1]);

            // Determine BMI status
            bmiStatus[i] = DetermineBMIStatus(personData[i, 2]);
        }

        // Display results
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine($"Person {i + 1}: Height = {personData[i, 1]} cm, Weight = {personData[i, 0]} kg, BMI = {personData[i, 2]:F2}, Status = {bmiStatus[i]}");
        }
    }

    private double CalculateBMI(double weight, double heightCm)
    {
        double heightM = heightCm / 100;
        return weight / (heightM * heightM);
    }

    private string DetermineBMIStatus(double bmi)
    {
        if (bmi < 18.5)
            return "Underweight";
        else if (bmi < 24.9)
            return "Normal weight";
        else if (bmi < 29.9)
            return "Overweight";
        else
            return "Obesity";
    }
}
