// 1. Write a program to find the age of Harry if the birth year is 2000. Assume the Current Year is 2024
// I/P => NONE
// O/P => Harry's age in 2024 is __24





using System;
class Question1
{
    public void CalculateAge()
    {
        // Creating an integer variable 'birthYear' and assign value 2000
        int birthYear = 2000;

        // Creating an integer variable 'currentYear' and assign value 2024
        int currentYear = 2024;

        // Calculating age by subtracting birth year from current year
        int age = currentYear - birthYear;

        // Display the result
        Console.WriteLine($"Harry's age in {currentYear} is {age}");
    }
}
