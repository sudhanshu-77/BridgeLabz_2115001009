// Write a program SpringSeason that takes two int values month and day from the command line and prints “Its a Spring Season” otherwise prints “Not a Spring Season”. 
// Hint => Spring Season is from March 20 to June 20. Write a Method to check for Spring season and return a boolean true or false 
using System;

class Question6
{
    public void SumOfNaturalNumbers()
    {
        // Taking user input for a number
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        // Calculating sum of natural numbers
        int sum = 0;
        for (int i = 1; i <= number; i++)
        {
            sum += i;
        }

        // Displaying the result
        Console.WriteLine($"The sum of {number} natural numbers is {sum}");
    }
}
