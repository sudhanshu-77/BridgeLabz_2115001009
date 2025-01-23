// MainProgram.cs
using System;

class MainProgram
{
    static void Main(string[] args)
    {
        Console.WriteLine("Executing all questions sequentially...");

        // Create an instance of Question1 and call the CheckLeapYear function
        Question1 question1 = new Question1();
        question1.CheckLeapYear();
        Console.ReadKey();  // Wait for key press

        // Create an instance of Question2 and call the CalculateGrade function
        Question2 question2 = new Question2();
        question2.CalculateGrade();
        Console.ReadKey();  

        // Create an instance of Question3 and call the CheckPrimeNumber function
        Question3 question3 = new Question3();
        question3.CheckPrimeNumber();
        Console.ReadKey();  

        // Create an instance of Question4 and call the FizzBuzzForLoop function
        Question4 question4 = new Question4();
        question4.FizzBuzzForLoop();
        Console.ReadKey();  

        // Create an instance of Question5 and call the FizzBuzzWhileLoop function
        Question5 question5 = new Question5();
        question5.FizzBuzzWhileLoop();
        Console.ReadKey();  

        // Create an instance of Question6 and call the CalculateBMI function
        Question6 question6 = new Question6();
        question6.CalculateBMI();
        Console.ReadKey();  

        // Create an instance of Question7 and call the FindYoungestAndTallest function
        Question7 question7 = new Question7();
        question7.FindYoungestAndTallest();
        Console.ReadKey();  

        // Create an instance of Question8 and call the FindGreatestFactor function
        Question8 question8 = new Question8();
        question8.FindGreatestFactor();
        Console.ReadKey();  

        // Create an instance of Question9 and call the CalculatePower function
        Question9 question9 = new Question9();
        question9.CalculatePower();
        Console.ReadKey();  

        // Create an instance of Question10 and call the FindFactors function
        Question10 question10 = new Question10();
        question10.FindFactors();
        Console.ReadKey();  

        // Create an instance of Question11 and call the FindMultiplesBelow100 function
        Question11 question11 = new Question11();
        question11.FindMultiplesBelow100();
        Console.ReadKey();  

        Console.WriteLine("All questions executed successfully.");
    }
}
