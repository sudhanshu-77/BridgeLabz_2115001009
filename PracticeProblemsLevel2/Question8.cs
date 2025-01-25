
// Create a program to take input marks of students in 3 subjects physics, chemistry, and maths. Compute the percentage and then calculate the grade  as per the following guidelines 

// Hint => 
// Take input for the number of students
// Create arrays to store marks, percentages, and grades of the students
// Take input for marks of students in physics, chemistry, and maths. If the marks are negative, ask the user to enter positive values and decrement the index
// Calculate the percentage and grade of the students based on the percentage
// Display the marks, percentages, and grades of each student
using System;

class Question8
{
    public void CalculateGrades()
    {
        // Ask for the number of students
        Console.Write("Enter the number of students: ");
        int numStudents = Convert.ToInt32(Console.ReadLine());

        // Create arrays to store marks, percentages, and grades
        int[] physicsMarks = new int[numStudents];
        int[] chemistryMarks = new int[numStudents];
        int[] mathsMarks = new int[numStudents];
        double[] percentages = new double[numStudents];
        string[] grades = new string[numStudents];

        // Loop to take input for each student
        for (int i = 0; i < numStudents; i++)
        {
            Console.WriteLine($"\nEnter marks for Student {i + 1}:");

            // Input marks for physics, chemistry, and maths, with validation
            Console.Write("Enter marks for Physics: ");
            physicsMarks[i] = GetValidMarks();

            Console.Write("Enter marks for Chemistry: ");
            chemistryMarks[i] = GetValidMarks();

            Console.Write("Enter marks for Maths: ");
            mathsMarks[i] = GetValidMarks();

            // Calculate total marks and percentage
            int totalMarks = physicsMarks[i] + chemistryMarks[i] + mathsMarks[i];
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
        Console.WriteLine("\n------------");
        Console.WriteLine("Results for all students:");

        for (int i = 0; i < numStudents; i++)
        {
            Console.WriteLine($"\nStudent {i + 1}:");
            Console.WriteLine($"Physics: {physicsMarks[i]}");
            Console.WriteLine($"Chemistry: {chemistryMarks[i]}");
            Console.WriteLine($"Maths: {mathsMarks[i]}");
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

