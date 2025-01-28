// MainProgram.cs
using System;

class MainProgram
{
    static void Main(string[] args)
    {
        Console.WriteLine("Executing all questions sequentially...");

        // Create an instance of Question1 and call the AnalyzeHeights function
        Question1 question1 = new Question1();
        question1.AnalyzeHeights();
        Console.ReadKey(); // Wait for key press

        // Create an instance of Question2 and call the NumberCheckerTasks function
        Question2 question2 = new Question2();
        question2.NumberCheckerTasks();
        Console.ReadKey(); // Wait for key press

        // Create an instance of Question3 and call the NumberCheckerTasks2 function
        Question3 question3 = new Question3();
        question3.NumberCheckerTasks2();
        Console.ReadKey(); // Wait for key press

        // Create an instance of Question4 and call the NumberCheckerTasks3 function
        Question4 question4 = new Question4();
        question4.NumberCheckerTasks3();
        Console.ReadKey(); // Wait for key press

        // Create an instance of Question5 and call the NumberCheckerTasks4 function
        Question5 question5 = new Question5();
        question5.NumberCheckerTasks4();
        Console.ReadKey(); // Wait for key press

        // Create an instance of Question6 and call the NumberCheckerTasks5 function
        Question6 question6 = new Question6();
        question6.NumberCheckerTasks5();
        Console.ReadKey(); // Wait for key press

        // Create an instance of Question7 and call the GenerateUniqueOTPs function
        Question7 question7 = new Question7();
        question7.GenerateUniqueOTPs();
        Console.ReadKey(); // Wait for key press

        // Create an instance of Question8 and call the DisplayCalendar function
        Question8 question8 = new Question8();
        question8.DisplayCalendar();
        Console.ReadKey(); // Wait for key press

        // Create an instance of Question9 and call the CalculateDistanceAndLineEquation function
        Question9 question9 = new Question9();
        question9.CalculateDistanceAndLineEquation();
        Console.ReadKey(); // Wait for key press

        // Create an instance of Question10 and call the CheckCollinearity function
        Question10 question10 = new Question10();
        question10.CheckCollinearity();
        Console.ReadKey(); // Wait for key press

        // Create an instance of Question11 and call the CalculateEmployeeBonus function
        Question11 question11 = new Question11();
        question11.CalculateEmployeeBonus();
        Console.ReadKey(); // Wait for key press

        // Create an instance of Question12 and call the CalculateStudentScores function
        Question12 question12 = new Question12();
        question12.CalculateStudentScores();
        Console.ReadKey(); // Wait for key press

        // Create an instance of Question13 and call the MatrixOperations function
        Question13 question13 = new Question13();
        question13.MatrixOperations();
        Console.ReadKey(); // Wait for key press

        Console.WriteLine("All questions executed successfully.");
    }
}
