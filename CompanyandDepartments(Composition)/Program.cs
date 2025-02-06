// Problem 3: Company and Departments (Composition)
// Description: A Company has several Department objects, and each department contains Employee objects. Model this using composition, where deleting a Company should also delete all departments and employees.
// Tasks:
// Define a Company class that contains multiple Department objects.
// Define an Employee class within each Department.
// Show the composition relationship by ensuring that when a Company object is deleted, all associated Department and Employee objects are also removed.
// Goal: Understand composition by implementing a relationship where Department and Employee objects cannot exist without a Company.
using System;
using System.Collections.Generic;

// Employee class representing an employee
class Employee
{
    public string Name { get; set; }

    public Employee(string name)
    {
        Name = name;
    }
}

// Department class containing employees
class Department
{
    public string Name { get; set; }
    public List<Employee> Employees { get; set; }

    public Department(string name)
    {
        Name = name;
        Employees = new List<Employee>();
    }

    public void AddEmployee(Employee employee)
    {
        Employees.Add(employee);
    }
}

// Company class containing departments
class Company
{
    public string Name { get; set; }
    public List<Department> Departments { get; set; }

    public Company(string name)
    {
        Name = name;
        Departments = new List<Department>();
    }

    public void AddDepartment(Department department)
    {
        Departments.Add(department);
    }
}

// Demonstration of composition
class Program
{
    static void Main(string[] args)
    {
        Company company = new Company("TechCorp");

        Department dept1 = new Department("IT");
        dept1.AddEmployee(new Employee("Aman"));
        dept1.AddEmployee(new Employee("Pankaj"));

        Department dept2 = new Department("HR");
        dept2.AddEmployee(new Employee("Ravi"));

        company.AddDepartment(dept1);
        company.AddDepartment(dept2);

        // Display company structure
        Console.WriteLine($"Company: {company.Name}");
        foreach (var dept in company.Departments)
        {
            Console.WriteLine($"Department: {dept.Name}");
            foreach (var emp in dept.Employees)
            {
                Console.WriteLine($"Employee: {emp.Name}");
            }
        }
    }
}

