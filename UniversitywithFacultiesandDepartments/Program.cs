// Problem 2: University with Faculties and Departments (Composition and Aggregation)
// Description: Create a University with multiple Faculty members and Department objects. Model it so that the University and its Departments are in a composition relationship (deleting a university deletes all departments), and the Faculty members are in an aggregation relationship (faculty can exist outside of any specific department).
// Tasks:
// Define a University class with Department and Faculty classes.
// Demonstrate how deleting a University also deletes its Departments.
// Show that Faculty members can exist independently of a Department.
// Goal: Understand the differences between composition and aggregation in modeling complex hierarchical relationships.
using System;
using System.Collections.Generic;

// Faculty class representing a faculty member
class Faculty
{
    public string Name { get; set; }

    public Faculty(string name)
    {
        Name = name;
    }
}

// Department class containing faculty members
class Department
{
    public string Name { get; set; }
    public List<Faculty> Faculties { get; set; }

    public Department(string name)
    {
        Name = name;
        Faculties = new List<Faculty>();
    }

    public void AddFaculty(Faculty faculty)
    {
        Faculties.Add(faculty);
    }
}

// University class containing departments
class University
{
    public string Name { get; set; }
    public List<Department> Departments { get; set; }

    public University(string name)
    {
        Name = name;
        Departments = new List<Department>();
    }

    public void AddDepartment(Department department)
    {
        Departments.Add(department);
    }
}

// Demonstration of composition and aggregation
class Program
{
    static void Main(string[] args)
    {
        University university = new University("State University");

        Department dept1 = new Department("Computer Science");
        dept1.AddFaculty(new Faculty("Dr. Smith"));
        dept1.AddFaculty(new Faculty("Dr. Johnson"));

        Department dept2 = new Department("Physics");
        dept2.AddFaculty(new Faculty("Dr. Brown"));

        university.AddDepartment(dept1);
        university.AddDepartment(dept2);

        // Display university structure
        Console.WriteLine($"University: {university.Name}");
        foreach (var dept in university.Departments)
        {
            Console.WriteLine($"Department: {dept.Name}");
            foreach (var faculty in dept.Faculties)
            {
                Console.WriteLine($"Faculty: {faculty.Name}");
            }
        }
    }
}



