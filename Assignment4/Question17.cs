using System;

class Question17
{
    public void CalculateEmployeeBonus()
    {
        // Taking user input for salary and years of service
        Console.Write("Enter the salary: ");
        double salary = double.Parse(Console.ReadLine());
        Console.Write("Enter the years of service: ");
        int yearsOfService = int.Parse(Console.ReadLine());

        // Calculating bonus
        double bonus = yearsOfService > 5 ? salary * 0.05 : 0;

        // Displaying the bonus
        Console.WriteLine($"The bonus amount is {bonus}");
    }
}

