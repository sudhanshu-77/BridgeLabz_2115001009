// 1. Employee Management System

// Description: Build an employee management system with the following requirements:
// Use an abstract class Employee with fields like employeeId, name, and baseSalary.
// Provide an abstract method CalculateSalary() and a concrete method DisplayDetails().c
// Create two subclasses: FullTimeEmployee and PartTimeEmployee, implementing CalculateSalary() based on work hours or fixed salary.
// Use encapsulation to restrict direct access to fields and provide properties for access.
// Create an interface IDepartment with methods like AssignDepartment() and GetDepartmentDetails().
// Ensure polymorphism by processing a list of employees and displaying their details using the Employee reference.

using System;
using System.Collections.Generic;

// Abstract class representing an Employee
abstract class Employee
{
    // Private fields for encapsulation
    private int employeeId;
    private string name;
    private double baseSalary;

    // Public properties for accessing private fields
    public int EmployeeId { get => employeeId; set => employeeId = value; }
    public string Name { get => name; set => name = value; }
    public double BaseSalary { get => baseSalary; set => baseSalary = value; }

    // Abstract method to calculate salary
    public abstract double CalculateSalary();

    // Concrete method to display employee details
    public void DisplayDetails()
    {
        Console.WriteLine($"Employee ID: {EmployeeId}, Name: {Name}, Base Salary: {BaseSalary}");
    }
}

// Interface for department-related operations
interface IDepartment
{
    void AssignDepartment(string department);
    string GetDepartmentDetails();
}

// Full-time employee class
class FullTimeEmployee : Employee, IDepartment
{
    private string department;

    public override double CalculateSalary()
    {
        // Calculate salary for full-time employee
        return BaseSalary * 1.2; // Example calculation
    }

    public void AssignDepartment(string department)
    {
        this.department = department;
    }

    public string GetDepartmentDetails()
    {
        return $"Department: {department}";
    }
}

// Part-time employee class
class PartTimeEmployee : Employee, IDepartment
{
    private string department;

    public override double CalculateSalary()
    {
        // Calculate salary for part-time employee
        return BaseSalary * 0.8; // Calculation
    }

    public void AssignDepartment(string department)
    {
        this.department = department;
    }

    public string GetDepartmentDetails()
    {
        return $"Department: {department}";
    }
}

class Program
{
    static void Main(string[] args)
    {
        // List of employees
        List<Employee> employees = new List<Employee>();

        Console.Write("Enter the number of employees: ");
        int numberOfEmployees = int.Parse(Console.ReadLine());

        for (int i = 0; i < numberOfEmployees; i++)
        {
            Console.WriteLine($"Enter details for employee {i + 1}:");
            Console.Write("Enter Employee ID: ");
            int employeeId = int.Parse(Console.ReadLine());

            Console.Write("Enter Name: ");
            string name = Console.ReadLine();

            Console.Write("Enter Base Salary: ");
            double baseSalary = double.Parse(Console.ReadLine());

            Console.Write("Enter Employee Type (FullTime/PartTime): ");
            string employeeType = Console.ReadLine();

            Employee employee;
            if (employeeType.Equals("FullTime", StringComparison.OrdinalIgnoreCase))
            {
                employee = new FullTimeEmployee();
            }
            else if (employeeType.Equals("PartTime", StringComparison.OrdinalIgnoreCase))
            {
                employee = new PartTimeEmployee();
            }
            else
            {
                Console.WriteLine("Invalid employee type. Skipping entry.");
                continue;
            }

            employee.EmployeeId = employeeId;
            employee.Name = name;
            employee.BaseSalary = baseSalary;

            Console.Write("Enter Department: ");
            string department = Console.ReadLine();
            ((IDepartment)employee).AssignDepartment(department);

            employees.Add(employee);
        }

        // Process each employee and display details
        foreach (var employee in employees)
        {
            employee.DisplayDetails();
            Console.WriteLine($"Calculated Salary: {employee.CalculateSalary()}");
            Console.WriteLine(((IDepartment)employee).GetDepartmentDetails());
            Console.WriteLine();
        }
    }
}
