// MainProgram.cs
using System;

class MainProgram
{
    static void Main(string[] args)
    {
        Console.WriteLine("Executing all questions sequentially...");

        //   instance of Question1 and call  FindFactors function
        Question1 question1 = new Question1();
        question1.FindFactors();
        Console.ReadKey();  

        //   instance of Question2 and call   SumOfNaturalNumbers function
        Question2 question2 = new Question2();
        question2.SumOfNaturalNumbers();
        Console.ReadKey();  

        //   instance of Question3 and call   CheckLeapYear function
        Question3 question3 = new Question3();
        question3.CheckLeapYear();
        Console.ReadKey();   

        //   instance of Question4 and call   UnitConverter function
        Question4 question4 = new Question4();
        question4.UnitConverter();
        Console.ReadKey();  

        //   instance of Question5 and call   UnitConverterExtended function
        Question5 question5 = new Question5();
        question5.UnitConverterExtended();
        Console.ReadKey();  

        //   instance of Question6 and call   UnitConverterTemperature function
        Question6 question6 = new Question6();
        question6.UnitConverterTemperature();
        Console.ReadKey();  

        //   instance of Question7 and call   CheckStudentVotingEligibility function
        Question7 question7 = new Question7();
        question7.CheckStudentVotingEligibility();
        Console.ReadKey();  

        //   instance of Question8 and call   FindYoungestAndTallest function
        Question8 question8 = new Question8();
        question8.FindYoungestAndTallest();
        Console.ReadKey();  

        //   instance of Question9 and call   CheckNumberProperties function
        Question9 question9 = new Question9();
        question9.CheckNumberProperties();
        Console.ReadKey();  

        //   instance of Question10 and call   CalculateBMI function
        Question10 question10 = new Question10();
        question10.CalculateBMI();
        Console.ReadKey();  

        //   instance of Question11 and call   FindQuadraticRoots function
        Question11 question11 = new Question11();
        question11.FindQuadraticRoots();
        Console.ReadKey();  

        //   instance of Question12 and call   GenerateRandomNumbers function
        Question12 question12 = new Question12();
        question12.GenerateRandomNumbers();
        Console.ReadKey();  

        Console.WriteLine("All questions executed successfully.");
    }
}
