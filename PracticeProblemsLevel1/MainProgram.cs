// MainProgram.cs
using System;

class MainProgram
{
    static void Main(string[] args)
    {
        Console.WriteLine("Executing all questions sequentially...");

        //  instance of Question1 and call the CheckVotingEligibility function
        Question1 question1 = new Question1();
        question1.CheckVotingEligibility();
        Console.ReadKey(); 

        //  instance of Question2 and call the CheckNumberProperties function
        Question2 question2 = new Question2();
        question2.CheckNumberProperties();
        Console.ReadKey();  

        //  instance of Question3 and call the MultiplicationTable function
        Question3 question3 = new Question3();
        question3.MultiplicationTable();
        Console.ReadKey();  

        //  instance of Question4 and call the StoreValuesInArray function
        Question4 question4 = new Question4();
        question4.StoreValuesInArray();
        Console.ReadKey();  

        //  instance of Question5 and call the MultiplicationTableRange function
        Question5 question5 = new Question5();
        question5.MultiplicationTableRange();
        Console.ReadKey();  

        //  instance of Question6 and call the CalculateMeanHeight function
        Question6 question6 = new Question6();
        question6.CalculateMeanHeight();
        Console.ReadKey();  

        //  instance of Question7 and call the SaveOddEvenNumbers function
        Question7 question7 = new Question7();
        question7.SaveOddEvenNumbers();
        Console.ReadKey();  

        //  instance of Question8 and call the FindFactors function
        Question8 question8 = new Question8();
        question8.FindFactors();
        Console.ReadKey();  

        //  instance of Question9 and call the Copy2DArrayTo1D function
        Question9 question9 = new Question9();
        question9.Copy2DArrayTo1D();
        Console.ReadKey();  

        //  instance of Question10 and call the FizzBuzz function
        Question10 question10 = new Question10();
        question10.FizzBuzz();
        Console.ReadKey();  

        Console.WriteLine("All questions executed successfully.");
    }
}
