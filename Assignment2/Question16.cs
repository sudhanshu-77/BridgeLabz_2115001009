
// 16. Create a program to find the maximum number of handshakes among N number of students.
// Hint:
// Get integer input for numberOfStudents variable.
// Use the combination = (n * (n - 1)) / 2 formula to calculate the maximum number of possible handshakes.
// Display the number of possible handshakes.
// O/P => The maximum number of handshakes among 15 students is 105.


using System;

class Question16
{
    public void MaximumHandshakes()
    {
        // Take user input for the number of students
        Console.Write("Enter the number of students: ");
        int numberOfStudents = Convert.ToInt32(Console.ReadLine());

        // Calculate the maximum number of handshakes using combination formula
        int handshakes = (numberOfStudents * (numberOfStudents - 1)) / 2;

        // Display the result
        Console.WriteLine($"The maximum number of handshakes among {numberOfStudents} students is {handshakes}.");
    }
}
