using System;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            // Display main menu options
            Console.WriteLine("Select a System to Run:");
            Console.WriteLine("1. Bank Account System");
            Console.WriteLine("2. Employee Management System");
            Console.WriteLine("3. Shopping Cart System");
            Console.WriteLine("4. University Student Management");
            Console.WriteLine("5. Hospital Management System");
            Console.WriteLine("6. Vehicle Registration System");
            Console.WriteLine("7. Exit");

          
            int choice = Convert.ToInt16(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    // Run Bank Account System
                    BankAccountSystem.Print();
                    break;

                case 2:
                    // Run Employee Management System
                    EmployeeManagement.Print();
                    break;

                case 3:
                    // Run Shopping Cart System
                    ShoppingCart.Print();
                    break;

                case 4:
                    // Run University Student Management
                    UniversityManagement.Print();
                    break;

                case 5:
                    // Run Hospital Management System
                    HospitalManagement.Print();
                    break;

                case 6:
                    // Run Vehicle Registration System
                    VehicleRegistration.Print();
                    break;

                case 7:
                   
                    return;

                default:
                    
                    Console.WriteLine("INVALID OPTION");
                    break;
            }
        }
    }
}
