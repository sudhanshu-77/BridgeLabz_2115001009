// MainProgram.cs
using System;

class MainProgram
{
    static void Main(string[] args)
    {
        Console.WriteLine("Executing all questions sequentially...");

        // Create an instance of Question1 and call the CalculateAge function
        Question1 question1 = new Question1();
        question1.CalculateAge();
        Console.ReadKey(); // Wait for key press

        // Create an instance of Question2 and call the CalculateAverage function
        Question2 question2 = new Question2();
        question2.CalculateAverage();
        Console.ReadKey(); // Wait for key press

        // Create an instance of Question3 and call the ConvertDistance function
        Question3 question3 = new Question3();
        question3.ConvertDistance();
        Console.ReadKey(); // Wait for key press

        // Create an instance of Question4 and call the CalculateProfit function
        Question4 question4 = new Question4();
        question4.CalculateProfit();
        Console.ReadKey(); // Wait for key press

        // Create an instance of Question5 and call the DistributePens function
        Question5 question5 = new Question5();
        question5.DistributePens();
        Console.ReadKey(); // Wait for key press

        // Create an instance of Question6 and call the UniversityFee function
        Question6 question6 = new Question6();
        question6.UniversityFee();
        Console.ReadKey(); // Wait for key press

        // Create an instance of Question7 and call the EarthVolume function
        Question7 question7 = new Question7();
        question7.EarthVolume();
        Console.ReadKey(); // Wait for key press

        // Create an instance of Question8 and call the ConvertDistanceWithInput function
        Question8 question8 = new Question8();
        question8.ConvertDistanceWithInput();
        Console.ReadKey(); // Wait for key press

        // Create an instance of Question9 and call the DiscountWithInput function
        Question9 question9 = new Question9();
        question9.DiscountWithInput();
        Console.ReadKey(); // Wait for key press

        // Create an instance of Question10 and call the HeightConverter function
        Question10 question10 = new Question10();
        question10.HeightConverter();
        Console.ReadKey(); // Wait for key press

        // Create an instance of Question11 and call the BasicCalculator function
        Question11 question11 = new Question11();
        question11.BasicCalculator();
        Console.ReadKey(); // Wait for key press

        // Create an instance of Question12 and call the TriangleArea function
        Question12 question12 = new Question12();
        question12.TriangleArea();
        Console.ReadKey(); // Wait for key press

        // Create an instance of Question13 and call the SquareSide function
        Question13 question13 = new Question13();
        question13.SquareSide();
        Console.ReadKey(); // Wait for key press

        // Create an instance of Question14 and call the DistanceConversion function
        Question14 question14 = new Question14();
        question14.DistanceConversion();
        Console.ReadKey(); // Wait for key press

        // Create an instance of Question15 and call the PurchasePrice function
        Question15 question15 = new Question15();
        question15.PurchasePrice();
        Console.ReadKey(); // Wait for key press

        // Create an instance of Question16 and call the MaximumHandshakes function
        Question16 question16 = new Question16();
        question16.MaximumHandshakes();
        Console.ReadKey(); // Wait for key press

        Console.WriteLine("All questions executed successfully.");
    }
}
