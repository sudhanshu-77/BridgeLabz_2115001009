using System;

class Question2
{
    public void CheckSmallestOfThree()
    {
        // Taking user input for three numbers
        Console.Write("Enter the first number: ");
        int number1 = int.Parse(Console.ReadLine());
        Console.Write("Enter the second number: ");
        int number2 = int.Parse(Console.ReadLine());
        Console.Write("Enter the third number: ");
        int number3 = int.Parse(Console.ReadLine());

        // Checking if the first number is the smallest
        bool isSmallest = number1 < number2 && number1 < number3;

        // Displaying the result
        Console.WriteLine($"Is the first number the smallest? {isSmallest}");
    }
}