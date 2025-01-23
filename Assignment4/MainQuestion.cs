using System;

class MainProgram
{
    static void Main(string[] args)
    {
        Console.WriteLine("Executing all questions sequentially...");

        // Create an instance of Question1 and call the CheckDivisibilityBy5 function
        Question1 question1 = new Question1();
        question1.CheckDivisibilityBy5();
        Console.ReadKey(); // Wait for key press

        // Create an instance of Question2 and call the CheckSmallestOfThree function
        Question2 question2 = new Question2();
        question2.CheckSmallestOfThree();
        Console.ReadKey(); 

        // Create an instance of Question3 and call the CheckLargestOfThree function
        Question3 question3 = new Question3();
        question3.CheckLargestOfThree();
        Console.ReadKey(); 

        // Create an instance of Question4 and call the SumOfNaturalNumbers function
        Question4 question4 = new Question4();
        question4.SumOfNaturalNumbers();
        Console.ReadKey();

        // Create an instance of Question5 and call the CheckVotingEligibility function
        Question5 question5 = new Question5();
        question5.CheckVotingEligibility();
        Console.ReadKey(); 

        // Create an instance of Question6 and call the CheckNumberSign function
        Question6 question6 = new Question6();
        question6.CheckNumberSign();
        Console.ReadKey(); 

        // Create an instance of Question7 and call the CheckSpringSeason function
        Question7 question7 = new Question7();
        question7.CheckSpringSeason();
        Console.ReadKey(); 

        // Create an instance of Question8 and call the CountdownWhileLoop function
        Question8 question8 = new Question8();
        question8.CountdownWhileLoop();
        Console.ReadKey(); 

        // Create an instance of Question9 and call the CountdownForLoop function
        Question9 question9 = new Question9();
        question9.CountdownForLoop();
        Console.ReadKey();

        // Create an instance of Question10 and call the SumUntilZero function
        Question10 question10 = new Question10();
        question10.SumUntilZero();
        Console.ReadKey(); 

        // Create an instance of Question11 and call the SumUntilZeroOrNegative function
        Question11 question11 = new Question11();
        question11.SumUntilZeroOrNegative();
        Console.ReadKey(); 

        // Create an instance of Question12 and call the SumOfNaturalNumbersWhileLoop function
        Question12 question12 = new Question12();
        question12.SumOfNaturalNumbersWhileLoop();
        Console.ReadKey(); 

        // Create an instance of Question13 and call the SumOfNaturalNumbersForLoop function
        Question13 question13 = new Question13();
        question13.SumOfNaturalNumbersForLoop();
        Console.ReadKey(); 

        // Create an instance of Question14 and call the FactorialWhileLoop function
        Question14 question14 = new Question14();
        question14.FactorialWhileLoop();
        Console.ReadKey(); 

        // Create an instance of Question15 and call the FactorialForLoop function
        Question15 question15 = new Question15();
        question15.FactorialForLoop();
        Console.ReadKey();

        // Create an instance of Question16 and call the PrintOddEvenNumbers function
        Question16 question16 = new Question16();
        question16.PrintOddEvenNumbers();
        Console.ReadKey(); 

        // Create an instance of Question17 and call the CalculateEmployeeBonus function
        Question17 question17 = new Question17();
        question17.CalculateEmployeeBonus();
        Console.ReadKey();

        // Create an instance of Question18 and call the MultiplicationTable function
        Question18 question18 = new Question18();
        question18.MultiplicationTable();
        Console.ReadKey(); 

        Console.WriteLine("All questions executed successfully.");
    }
}



