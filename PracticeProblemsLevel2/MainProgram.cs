// MainProgram.cs
using System;

class MainProgram
{
    static void Main(string[] args)
    {
        Console.WriteLine("Executing all questions sequentially...");

        //   instance of Question1 and call the CalculateEmployeeBonus function
        Question1 question1 = new Question1();
        question1.CalculateEmployeeBonus();
        Console.ReadKey(); 

        //   instance of Question2 and call the FindYoungestAndTallest function
        Question2 question2 = new Question2();
        question2.FindYoungestAndTallest();
        Console.ReadKey(); 

        //   instance of Question3 and call the FindLargestAndSecondLargest function
        Question3 question3 = new Question3();
        question3.FindLargestAndSecondLargest();
        Console.ReadKey(); 

        //   instance of Question4 and call the ReverseNumber function
        Question4 question4 = new Question4();
        question4.FindLargendSecondLarge();
        Console.ReadKey(); 

        //   instance of Question5 and call the CalculateBMI function
        Question5 question5 = new Question5();
        question5.ReverseNumber();
        Console.ReadKey(); 

        //   instance of Question6 and call the CalculateBMIWith2DArray function
        Question7 question7 = new Question7();
        question7.CalculateBMIWith2DArray();
        Console.ReadKey(); 

        //   instance of Question7 and call the CalculateStudentGrades function
        Question8 question8 = new Question8();
        question8.CalculateGrades();
        Console.ReadKey(); 

        //   instance of Question8 and call the CalculateStudentGradesWith2DArray function
        Question9 question9 = new Question9();
        question9.CalculateGrades2();
        Console.ReadKey(); 

        //   instance of Question9 and call the FindDigitFrequency function
        Question10 question10 = new Question10();
        question10.FindDigitFrequency();
        Console.ReadKey(); 

        Console.WriteLine("All questions executed successfully.");
    }
}
