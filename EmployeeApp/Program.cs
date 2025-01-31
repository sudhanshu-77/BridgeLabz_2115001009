using System;

public class Employee
{
    // Fields (Attributes)
    private string name;
    private int id;
    private double salary;

    // Constructor
    public Employee(string name, int id, double salary)
    {
        this.name = name;
        this.id = id;
        this.salary = salary;
    }

    // Method to display employee details
    public void DisplayDetails()
    {
        Console.WriteLine("Employee Name: " + name);
        Console.WriteLine("Employee ID: " + id);
        Console.WriteLine("Salary: $" + salary);
    }
}

// Main Class to Test
public class Program
{
    public static void Main(string[] args)
    {
        // Create Employee objects
        Employee employee1 = new Employee("Alice", 101, 50000);
        Employee employee2 = new Employee("Bob", 102, 60000);

        // Display details of each employee
        Console.WriteLine("=== Employee 1 ===");
        employee1.DisplayDetails();
        Console.WriteLine("\n=== Employee 2 ===");
        employee2.DisplayDetails();
    }
}
