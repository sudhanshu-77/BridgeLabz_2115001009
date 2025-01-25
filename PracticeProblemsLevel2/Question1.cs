// Level 2 Practice Programs
// Create a program to find the bonus of 10 employees based on their years of service and the total bonus amount the company Zara has to pay, along with the old and new salary.
// Hint => 
// Zara decides to give a bonus of 5% to employees whose year of service is more than 5 years or 2% if less than 5 years
// Define a double array to save salary and years of service for each of the 10 employees
// Also define a double array to save the new salary and the bonus amount as well as variables to save the total bonus, total old salary, and new salary
// Define a loop to take input from the user. If salary or year of service is an invalid number then ask the user to enter again. Note in this case you will have to decrement the index counter
// Define another loop to calculate the bonus of 10 employees based on their years of service. Save the bonus in the array, compute the new salary, and save in the array. Also, the total bonus and total old and new salary can be calculated in the loop
// Print the total bonus payout as well as the total old and new salary of all the employees

using System;

class Question1
{
    public void CalculateEmployeeBonus()
    {
        double[] salaries = new double[10];
        double[] yearsOfService = new double[10];
        double[] bonuses = new double[10];
        double[] newSalaries = new double[10];
        double totalBonus = 0, totalOldSalary = 0, totalNewSalary = 0;

        // Input salaries and years of service
        for (int i = 0; i < 10; i++)
        {
            Console.Write($"Enter salary for employee {i + 1}: ");
            salaries[i] = double.Parse(Console.ReadLine());
            Console.Write($"Enter years of service for employee {i + 1}: ");
            yearsOfService[i] = double.Parse(Console.ReadLine());

            // Validate input
            if (salaries[i] < 0 || yearsOfService[i] < 0)
            {
                Console.WriteLine("Invalid input. Please enter positive values.");
                i--; // Decrement index to re-enter values
                continue;
            }

            // Calculate bonus and new salary
            bonuses[i] = yearsOfService[i] > 5 ? salaries[i] * 0.05 : salaries[i] * 0.02;
            newSalaries[i] = salaries[i] + bonuses[i];

            // Accumulate totals
            totalBonus += bonuses[i];
            totalOldSalary += salaries[i];
            totalNewSalary += newSalaries[i];
        }

        // Display results
        Console.WriteLine($"Total bonus payout: {totalBonus}");
        Console.WriteLine($"Total old salary: {totalOldSalary}");
        Console.WriteLine($"Total new salary: {totalNewSalary}");
    }
}

