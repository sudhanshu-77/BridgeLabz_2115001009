// 11.             Create a program to find the bonus of 10 employees based on their years of service as well as the total bonus amount the 10-year-old company Zara has to pay as a bonus, along with the old and new salary.
// Hint => 
// a.                Zara decides to give a bonus of 5% to employees whose year of service is more than 5 years or 2% if less than 5 years
// b.                Create a Method to determine the Salary and years of service and return the same. Use the Math.Random() method to determine the 5-digit salary for each employee and also use the random method to determine the years of service. Define 2D Array to save the salary and years of service.
// c.                Write a Method to calculate the new salary and bonus based on the logic defined above and return the new 2D Array of the latest salary and bonus amount 
// d.                Write a Method to Calculate the sum of the Old Salary, the Sum of the New Salary, and the Total Bonus Amount and display it in a Tabular Format
using System;

class Question11
{
    public void CalculateEmployeeBonus()
    {
        double[,] employeeData = GenerateEmployeeData();
        double[,] newSalariesAndBonuses = CalculateNewSalariesAndBonuses(employeeData);
        DisplaySalaryDetails(employeeData, newSalariesAndBonuses);
    }

    private double[,] GenerateEmployeeData()
    {
        double[,] data = new double[10, 2];
        Random rand = new Random();

        for (int i = 0; i < 10; i++)
        {
            data[i, 0] = rand.Next(10000, 100000); // Random 5-digit salary
            data[i, 1] = rand.Next(1, 11); // Random years of service
        }
        return data;
    }

    private double[,] CalculateNewSalariesAndBonuses(double[,] employeeData)
    {
        double[,] newSalariesAndBonuses = new double[10, 2];

        for (int i = 0; i < 10; i++)
        {
            double salary = employeeData[i, 0];
            double yearsOfService = employeeData[i, 1];
            double bonus = yearsOfService > 5 ? salary * 0.05 : salary * 0.02;
            double newSalary = salary + bonus;

            newSalariesAndBonuses[i, 0] = newSalary;
            newSalariesAndBonuses[i, 1] = bonus;
        }
        return newSalariesAndBonuses;
    }

    private void DisplaySalaryDetails(double[,] employeeData, double[,] newSalariesAndBonuses)
    {
        double totalOldSalary = 0, totalNewSalary = 0, totalBonus = 0;

        Console.WriteLine("Employee\tOld Salary\tNew Salary\tBonus");
        for (int i = 0; i < 10; i++)
        {
            double oldSalary = employeeData[i, 0];
            double newSalary = newSalariesAndBonuses[i, 0];
            double bonus = newSalariesAndBonuses[i, 1];

            totalOldSalary += oldSalary;
            totalNewSalary += newSalary;
            totalBonus += bonus;

            Console.WriteLine($"{i + 1}\t\t{oldSalary}\t{newSalary}\t{bonus}");
        }

        Console.WriteLine($"\nTotal Old Salary: {totalOldSalary}");
        Console.WriteLine($"Total New Salary: {totalNewSalary}");
        Console.WriteLine($"Total Bonus: {totalBonus}");
    }
}
