using System;

// Base class representing a generic Employee
class Employee
{
    public string Name { get; set; }
    public int Id { get; set; }
    public double Salary { get; set; }

    // Constructor to initialize the Employee's details
    public Employee(string name, int id, double salary)
    {
        Name = name;
        Id = id;
        Salary = salary;
    }

    // Virtual method to display employee details
    public virtual void DisplayDetails()
    {
        Console.WriteLine($"Name: {Name}, ID: {Id}, Salary: {Salary}");
    }
}

// Manager class inheriting from Employee
class Manager : Employee
{
    public int TeamSize { get; set; }

    // Constructor to initialize the Manager's details
    public Manager(string name, int id, double salary, int teamSize)
        : base(name, id, salary)
    {
        TeamSize = teamSize;
    }

    // Override the DisplayDetails method to include TeamSize
    public override void DisplayDetails()
    {
        base.DisplayDetails();
        Console.WriteLine($"Team Size: {TeamSize}");
    }
}

// Developer class inheriting from Employee
class Developer : Employee
{
    public string ProgrammingLanguage { get; set; }

    // Constructor to initialize the Developer's details
    public Developer(string name, int id, double salary, string programmingLanguage)
        : base(name, id, salary)
    {
        ProgrammingLanguage = programmingLanguage;
    }

    // Override the DisplayDetails method to include ProgrammingLanguage
    public override void DisplayDetails()
    {
        base.DisplayDetails();
        Console.WriteLine($"Programming Language: {ProgrammingLanguage}");
    }
}

// Intern class inheriting from Employee
class Intern : Employee
{
    public string InternshipDuration { get; set; }

    // Constructor to initialize the Intern's details
    public Intern(string name, int id, double salary, string internshipDuration)
        : base(name, id, salary)
    {
        InternshipDuration = internshipDuration;
    }

    // Override the DisplayDetails method to include InternshipDuration
    public override void DisplayDetails()
    {
        base.DisplayDetails();
        Console.WriteLine($"Internship Duration: {InternshipDuration}");
    }
}

// Main class to demonstrate the Employee Management System
class MainEmployee
{
    static void Main(string[] args)
    {
        // Create instances of Manager, Developer, and Intern
        Employee manager = new Manager("Alice", 101, 75000, 10);
        Employee developer = new Developer("Bob", 102, 60000, "C#");
        Employee intern = new Intern("Charlie", 103, 20000, "6 months");

        // Display details of each employee
        manager.DisplayDetails();
        developer.DisplayDetails();
        intern.DisplayDetails();
    }
}
