using System;

class Person
{
    public string Name { get; set; }
    public int Age { get; set; }

    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }
}

// Teacher class inheriting from Person
class Teacher : Person
{
    public string Subject { get; set; }

    public Teacher(string name, int age, string subject)
        : base(name, age)
    {
        Subject = subject;
    }

    // Method to display role
    public void DisplayRole()
    {
        Console.WriteLine("Teacher");
    }
}

// Student class inheriting from Person
class Student : Person
{
    public string Grade { get; set; }

    // Constructor to initialize the Student's details
    public Student(string name, int age, string grade)
        : base(name, age)
    {
        Grade = grade;
    }

    // Method to display role
    public void DisplayRole()
    {
        Console.WriteLine("Student");
    }
}

// Staff class inheriting from Person
class Staff : Person
{
    public string Department { get; set; }

    // Constructor to initialize the Staff's details
    public Staff(string name, int age, string department)
        : base(name, age)
    {
        Department = department;
    }

    // Method to display role
    public void DisplayRole()
    {
        Console.WriteLine("Staff");
    }
}

class MainSchool
{
    static void Main(string[] args)
    {
        // Create instances of Teacher, Student, and Staff
        Teacher teacher = new Teacher("Mr. Smith", 40, "Mathematics");
        Student student = new Student("Alice", 16, "10th Grade");
        Staff staff = new Staff("Mrs. Johnson", 35, "Administration");

        // Display roles
        teacher.DisplayRole();
        student.DisplayRole();
        staff.DisplayRole();
    }
}
