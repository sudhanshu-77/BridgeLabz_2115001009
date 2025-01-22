// MainProgram.cs
using System;

class MainProgram
{
    static void Main(string[] args)
    {
        Console.WriteLine("Executing all questions sequentially...");

        // Create an instance of Question1 and call the CalculateQuotientAndRemainder function
        Question1 question1 = new Question1();
        question1.CalculateQuotientAndRemainder();
        Console.ReadKey(); // Wait for key press

        // Create an instance of Question2 and call the PerformIntegerOperations function
        Question2 question2 = new Question2();
        question2.PerformIntegerOperations();
        Console.ReadKey(); // Wait for key press

        // Create an instance of Question3 and call the PerformDoubleOperations function
        Question3 question3 = new Question3();
        question3.PerformDoubleOperations();
        Console.ReadKey(); // Wait for key press

        // Create an instance of Question4 and call the ConvertCelsiusToFahrenheit function
        Question4 question4 = new Question4();
        question4.ConvertCelsiusToFahrenheit();
        Console.ReadKey(); // Wait for key press

        // Create an instance of Question5 and call the ConvertFahrenheitToCelsius function
        Question5 question5 = new Question5();
        question5.ConvertFahrenheitToCelsius();
        Console.ReadKey(); // Wait for key press

        // Create an instance of Question6 and call the CalculateTotalIncome function
        Question6 question6 = new Question6();
        question6.CalculateTotalIncome();
        Console.ReadKey(); // Wait for key press

        // Create an instance of Question7 and call the SwapNumbers function
        Question7 question7 = new Question7();
        question7.SwapNumbers();
        Console.ReadKey(); // Wait for key press

        // Create an instance of Question8 and call the TripDetails function
        Question8 question8 = new Question8();
        question8.TripDetails();
        Console.ReadKey(); // Wait for key press

        // Create an instance of Question9 and call the CalculateAthleteRounds function
        Question9 question9 = new Question9();
        question9.CalculateAthleteRounds();
        Console.ReadKey(); // Wait for key press

        // Create an instance of Question10 and call the DivideChocolates function
        Question10 question10 = new Question10();
        question10.DivideChocolates();
        Console.ReadKey(); // Wait for key press

        // Create an instance of Question11 and call the CalculateSimpleInterest function
        Question11 question11 = new Question11();
        question11.CalculateSimpleInterest();
        Console.ReadKey(); // Wait for key press

        // Create an instance of Question12 and call the ConvertWeight function
        Question12 question12 = new Question12();
        question12.ConvertWeight();
        Console.ReadKey(); // Wait for key press

        Console.WriteLine("All questions executed successfully.");
    }
}
