// 6. Create a program to find the total income of a person by taking salary and bonus from the user
// Hint:
// Create a variable named salary and take user input.
// Create another variable bonus and take user input.
// Compute income by adding salary and bonus and print the result.
// I/P => salary, bonus
// O/P => The salary is INR __1200 _ and bonus is INR _15__. Hence Total Income is INR _1215__


using System;

class Question6
{
    public void CalculateTotalIncome()
    {
        // Taking input for salary and bonus
        Console.Write("Enter salary: ");
        double salary = double.Parse(Console.ReadLine());
        Console.Write("Enter bonus: ");
        double bonus = double.Parse(Console.ReadLine());

        // Calculating total income
        double totalIncome = salary + bonus;

        // Displaying the result
        Console.WriteLine($"The salary is INR {salary} and bonus is INR {bonus}. Hence Total Income is INR {totalIncome}");
    }
}
