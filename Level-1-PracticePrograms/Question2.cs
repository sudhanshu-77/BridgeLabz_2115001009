// Create a program to find the maximum number of handshakes among N number of students.
// Hint => 
// Get integer input for number of students
// Use the combination = (n * (n - 1)) / 2 formula to calculate the maximum number of possible handshakes.
// Write a method to use the combination formulae to calculate the number of handshakes


using System;

class Question2
{
    public void CalculateHandshakes()
    {
        // Taking user input for number of students
        Console.Write("Enter the number of students: ");
        int numberOfStudents = int.Parse(Console.ReadLine());

        // Calculating maximum number of handshakes
        int handshakes = (numberOfStudents * (numberOfStudents - 1)) / 2;

        // Displaying the result
        Console.WriteLine($"The maximum number of handshakes among {numberOfStudents} students is {handshakes}");
    }
}
