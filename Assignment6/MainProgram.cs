// MainProgram.cs
using System;

class MainProgram
{
    static void Main(string[] args)
    {
        Console.WriteLine("Executing all questions sequentially...");

        // Create an instance of Question1 and call the CheckArmstrongNumber function
        Question1 question1 = new Question1();
        question1.CheckArmstrongNumber();
        Console.ReadKey(); // Wait for key press

        // Create an instance of Question2 and call the CountDigits function
        Question2 question2 = new Question2();
        question2.CountDigits();
        Console.ReadKey(); // Wait for key press

        // Create an instance of Question3 and call the CheckHarshadNumber function
        Question3 question3 = new Question3();
        question3.CheckHarshadNumber();
        Console.ReadKey(); // Wait for key press

        // Create an instance of Question4 and call the CheckAbundantNumber function
        Question4 question4 = new Question4();
        question4.CheckAbundantNumber();
        Console.ReadKey(); // Wait for key press

        // Create an instance of Question5 and call the DayOfWeek function
        Question5 question5 = new Question5();
        question5.DayOfWeek();
        Console.ReadKey(); // Wait for key press

        // Create an instance of Question6 and call the Calculator function
        Question6 question6 = new Question6();
        question6.Calculator();
        Console.ReadKey(); // Wait for key press

        Console.WriteLine("All questions executed successfully.");
    }
}
