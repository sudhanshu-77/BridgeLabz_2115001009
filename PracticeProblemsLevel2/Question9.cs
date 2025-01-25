
// Rewrite the above program to store the marks of the students in physics, chemistry, and maths in a 2D array and then compute the percentage and grade
// Hint => 
// All the steps are the same as the problem 8 except the marks are stored in a 2D array
// Use the 2D array to calculate the percentages, and grades of the students
using System;

class Question9
{
    public void CalculateGrades2()
    {
        // Ask for the number of students
        Console.Write("Enter the number of students: ");
        int numStudents = Convert.ToInt32(Console.ReadLine());

        // Create a 2D array to store marks for physics, chemistry, and maths
        int[,] marks = new int[numStudents, 3]; // 3 columns: physics, chemistry, maths
        double[] percentages = new double[numStudents];
        string[] grades = new string[numStudents];

        // Loop to take input for each student
        for (int i = 0; i < numStudents; i++)
        {
            Console.WriteLine($"\nEnter marks for Student {i + 1}:");

            // Input marks for physics, chemistry, and maths with validation
            Console.Write("Enter marks for Physics: ");
            marks[i, 0] = GetValidMarks();

            Console.Write("Enter marks for Chemistry: ");
            marks[i, 1] = GetValidMarks();

            Console.Write("Enter marks for Maths: ");
            marks[i, 2] = GetValidMarks();

            // Calculate total marks and percentage
            int totalMarks = marks[i, 0] + marks[i, 1] + marks[i, 2];
            percentages[i] = (double)totalMarks / 300 * 100;

            // Calculate the grade based on percentage
            if (percentages[i] >= 80)
            {
                grades[i] = "A";
            }
            else if (percentages[i] >= 70)
            {
                grades[i] = "B";
            }
            else if (percentages[i] >= 60)
            {
                grades[i] = "C";
            }
            else if (percentages[i] >= 50)
            {
                grades[i] = "D";
            }
            else if (percentages[i] >= 40)
            {
                grades[i] = "E";
            }
            else
            {
                grades[i] = "R";
            }
        }

        // Display results for each student
        Console.WriteLine("\n-------------");
        Console.WriteLine("Results for all students:");

        for (int i = 0; i < numStudents; i++)
        {
            Console.WriteLine($"\nStudent {i + 1}:");
            Console.WriteLine($"Physics: {marks[i, 0]}");
            Console.WriteLine($"Chemistry: {marks[i, 1]}");
            Console.WriteLine($"Maths: {marks[i, 2]}");
            Console.WriteLine($"Percentage: {percentages[i]:F2}%");
            Console.WriteLine($"Grade: {grades[i]}");
           
        }
    }

    // Method to validate marks input
    private int GetValidMarks()
    {
        int marks;
        do
        {
            marks = Convert.ToInt32(Console.ReadLine());
            if (marks < 0 || marks > 100)
            {
                Console.WriteLine("Invalid marks! Please enter a value between 0 and 100.");
                Console.Write("Re-enter marks: ");
            }
        } while (marks < 0 || marks > 100);

        return marks;
    }
}

