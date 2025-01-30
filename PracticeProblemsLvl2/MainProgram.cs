using System;

class MainProgram
{
    static void Main(string[] args)
    {
       
        Question1 question1 = new Question1();
        question1.NumberGuessingGame();
        Console.ReadKey();
        
        Question2 question2 = new Question2();
        question2.FindMaximumOfThree();
        Console.ReadKey(); 

        Question3 question3 = new Question3();
        question3.PrimeNumberChecker();
        Console.ReadKey(); 

        Question4 question4 = new Question4();
        question4.FibonacciSequenceGenerator();
        Console.ReadKey(); 

        Question5 question5 = new Question5();
        question5.PalindromeChecker();
        Console.ReadKey(); 
        
        Question6 question6 = new Question6();
        question6.FactorialUsingRecursion();
        Console.ReadKey(); 
       
        Question7 question7 = new Question7();
        question7.GCDAndLCMCalculator();
        Console.ReadKey(); 

        Question8 question8 = new Question8();
        question8.TemperatureConverter();
        Console.ReadKey(); 
      
        Question9 question9 = new Question9();
        question9.BasicCalculator();
        Console.ReadKey(); 

        Console.WriteLine("All questions executed successfully.");
    }
}


