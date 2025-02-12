using System;

public class Student
{
    public int RollNumber { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
    public string Grade { get; set; }
    public Student Next { get; set; }
}

public class StudentLinkedList
{
    private Student head;

    public void AddStudentAtBeginning(int rollNumber, string name, int age, string grade)
    {
        Student newStudent = new Student
        {
            RollNumber = rollNumber,
            Name = name,
            Age = age,
            Grade = grade,
            Next = head
        };
        head = newStudent;
    }

    public void AddStudentAtEnd(int rollNumber, string name, int age, string grade)
    {
        Student newStudent = new Student
        {
            RollNumber = rollNumber,
            Name = name,
            Age = age,
            Grade = grade,
            Next = null
        };

        if (head == null)
        {
            head = newStudent;
            return;
        }

        Student current = head;
        while (current.Next != null)
        {
            current = current.Next;
        }
        current.Next = newStudent;
    }

    public void DeleteStudentByRollNumber(int rollNumber)
    {
        if (head == null) return;

        if (head.RollNumber == rollNumber)
        {
            head = head.Next;
            return;
        }

        Student current = head;
        while (current.Next != null && current.Next.RollNumber != rollNumber)
        {
            current = current.Next;
        }

        if (current.Next != null)
        {
            current.Next = current.Next.Next;
        }
    }

    public Student SearchStudentByRollNumber(int rollNumber)
    {
        Student current = head;
        while (current != null)
        {
            if (current.RollNumber == rollNumber)
            {
                return current;
            }
            current = current.Next;
        }
        return null;
    }

    public void DisplayAllStudents()
    {
        Student current = head;
        while (current != null)
        {
            Console.WriteLine($"Roll Number: {current.RollNumber}, Name: {current.Name}, Age: {current.Age}, Grade: {current.Grade}");
            current = current.Next;
        }
    }

    public void UpdateStudentGrade(int rollNumber, string newGrade)
    {
        Student student = SearchStudentByRollNumber(rollNumber);
        if (student != null)
        {
            student.Grade = newGrade;
        }
    }
}

class Program
{
    static void Main()
    {
        StudentLinkedList studentList = new StudentLinkedList();
        studentList.AddStudentAtBeginning(1, "Sudhanshu", 20, "A");
        studentList.AddStudentAtEnd(2, "Vaibhav", 21, "B");
        studentList.AddStudentAtEnd(3, "Aman", 22, "C");

        Console.WriteLine("All Students:");
        studentList.DisplayAllStudents();

        Console.WriteLine("\nUpdating grade to A+");
        studentList.UpdateStudentGrade(2, "A+");

        Console.WriteLine("\nAll Students after update:");
        studentList.DisplayAllStudents();

        Console.WriteLine("\nDeleting student with Roll Number");
        studentList.DeleteStudentByRollNumber(1);

        Console.WriteLine("\nAll Students after deletion:");
        studentList.DisplayAllStudents();
    }
}
