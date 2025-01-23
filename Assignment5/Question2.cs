// Question2.cs
using System;

class Question2
{
    public void CalculateGrade()
    {
        // Get marks for Physics, Chemistry, and Maths
        Console.Write("Enter marks for Physics: ");
        int physicsMarks = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter marks for Chemistry: ");
        int chemistryMarks = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter marks for Maths: ");
        int mathsMarks = Convert.ToInt32(Console.ReadLine());

        // Calculate total marks and percentage
        int totalMarks = physicsMarks + chemistryMarks + mathsMarks;
        double percentage = (double)totalMarks / 300 * 100;

        // Determine the grade and remarks
        string grade;
        string remarks;

        if (percentage >= 80)
        {
            grade = "A";
            remarks = "(Level 4, above agency-normalized standards)";
        }
        else if (percentage >= 70)
        {
            grade = "B";
            remarks = "(Level 3, at agency-normalized standards)";
        }
        else if (percentage >= 60)
        {
            grade = "C";
            remarks = "(Level 2, below, but approaching agency-normalized standards)";
        }
        else if (percentage >= 50)
        {
            grade = "D";
            remarks = "(Level 1, well below agency-normalized standards)";
        }
        else if (percentage >= 40)
        {
            grade = "E";
            remarks = "(Level 1-, too below agency-normalized standards)";
        }
        else
        {
            grade = "R";
            remarks = "(Remedial standards)";
        }

        // Display the results
        Console.WriteLine("\n-----------------------");
        Console.WriteLine("Results:");
        Console.WriteLine("-----------------------");
        Console.WriteLine($"Average Mark: {totalMarks / 3:F2}");
        Console.WriteLine($"Percentage: {percentage:F2}%");
        Console.WriteLine($"Grade: {grade}");
        Console.WriteLine($"Remarks: {remarks}");
    }
}
