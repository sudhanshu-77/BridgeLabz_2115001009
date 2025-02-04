// Sample Program 3: Employee Management System
// Design an Employee class with the following features:
// static: 
// A static variable CompanyName shared by all employees.
// A static method DisplayTotalEmployees() to show the total number of employees.
// this: 
// Use this to initialize Name, Id, and Designation in the constructor.
// readonly: 
// Use a readonly variable Id for the employee ID, which cannot be modified after assignment.
// is operator: 
// Check if a given object is an instance of the Employee class before printing the employee details.



using System;

class EmployeeManagement
{
    public static void Print()
    {
        while (true)
        {
            Console.WriteLine("1. Add Employee");
            Console.WriteLine("2. Display Total Employees");
            Console.WriteLine("3. Exit");

            int choice = Convert.ToInt16(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine("Enter Employee Name");
                    string name = Console.ReadLine();

                    Console.WriteLine("Enter Employee ID");
                    int id = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Enter Designation");
                    string designation = Console.ReadLine();

                    Employee employee = new Employee(name, id, designation);

                    if (employee is Employee)
                    {
                        employee.DisplayDetails();
                    }
                    break;

                case 2:
                    Employee.DisplayTotalEmployees();
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

class Employee
{
    static string CompanyName = "Tech Corp";
    public string Name;
    readonly int Id;
    public string Designation;
    public static int TotalEmployees;

    public Employee(string name, int id, string designation)
    {
        this.Name = name;
        this.Id = id;
        this.Designation = designation;
        TotalEmployees++;
    }

    public static void DisplayTotalEmployees()
    {
        Console.WriteLine("Total Employees in " + CompanyName + ": " + TotalEmployees);
    }

    public void DisplayDetails()
    {
        Console.WriteLine("Company Name: " + CompanyName);
        Console.WriteLine("Name: " + Name);
        Console.WriteLine("ID: " + Id);
        Console.WriteLine("Designation: " + Designation);
    }
}
