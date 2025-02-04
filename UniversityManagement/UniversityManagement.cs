
// Sample Program 5: University Student Management
// Create a Student class to manage student data with the following features:
// static: 
// A static variable UniversityName shared across all students.
// A static method DisplayTotalStudents() to show the number of students enrolled.
// this: 
// Use this in the constructor to initialize Name, RollNumber, and Grade.
// readonly: 
// Use a readonly variable RollNumber for each student that cannot be changed.
// is operator: 
// Check if a given object is an instance of the Student class before performing operations like displaying or updating grades.
// using System;



using System;

class UniversityManagement
{
    public static void Print()
    {
        while (true)
        {
            Console.WriteLine("1. Add Student");
            Console.WriteLine("2. Display Total Students");
            Console.WriteLine("3. Exit");

            int choice = Convert.ToInt16(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine("Enter Student Name");
                    string name = Console.ReadLine();

                    Console.WriteLine("Enter Roll Number");
                    int rollNumber = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Enter Grade");
                    string grade = Console.ReadLine();

                    Student student = new Student(name, rollNumber, grade);

                    if (student is Student)
                    {
                        student.DisplayDetails();
                    }
                    break;

                case 2:
                    Student.DisplayTotalStudents();
                    break;

                case 3:
                    return;

                default:
                    Console.WriteLine("INVALID FUNCTION");
                    break;
            }
        }
    }
}

class Student
{
    static string UniversityName = "Global University";
    public string Name;
    readonly int RollNumber;
    public string Grade;
    public static int TotalStudents;

    public Student(string name, int rollNumber, string grade)
    {
        this.Name = name;
        this.RollNumber = rollNumber;
        this.Grade = grade;
        TotalStudents++;
    }

    public static void DisplayTotalStudents()
    {
        Console.WriteLine("Total Students in " + UniversityName + ": " + TotalStudents);
    }

    public void DisplayDetails()
    {
        Console.WriteLine("University Name: " + UniversityName);
        Console.WriteLine("Name: " + Name);
        Console.WriteLine("Roll Number: " + RollNumber);
        Console.WriteLine("Grade: " + Grade);
    }
}
