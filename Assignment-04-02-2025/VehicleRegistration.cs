// Sample Program 6: Vehicle Registration System
// Create a Vehicle class with the following features:
// static: 
// A static variable RegistrationFee common for all vehicles.
// A static method UpdateRegistrationFee() to modify the fee.
// this: 
// Use this to initialize OwnerName, VehicleType, and RegistrationNumber in the constructor.
// readonly: 
// Use a readonly variable RegistrationNumber to uniquely identify each vehicle.
// is operator: 
// Check if an object belongs to the Vehicle class before displaying its registration details.
// using System;


using System;

class VehicleRegistration
{
    // Main method to handle user interaction
    public static void Print()
    {
        while (true)
        {
            // Display menu options
            Console.WriteLine("1. Register Vehicle");
            Console.WriteLine("2. Update Registration Fee");
            Console.WriteLine("3. Exit");

            // Read user choice
            int choice = Convert.ToInt16(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    // Register a new vehicle
                    Console.WriteLine("Enter Owner Name");
                    string ownerName = Console.ReadLine();

                    Console.WriteLine("Enter Vehicle Type");
                    string vehicleType = Console.ReadLine();

                    Console.WriteLine("Enter Registration Number");
                    int registrationNumber = Convert.ToInt32(Console.ReadLine());

                    // Create a new Vehicle object
                    Vehicle vehicle = new Vehicle(ownerName, vehicleType, registrationNumber);

                    // Check if the object is an instance of Vehicle and display details
                    if (vehicle is Vehicle)
                    {
                        vehicle.DisplayDetails();
                    }
                    break;

                case 2:
                    // Update the registration fee
                    Console.WriteLine("Enter New Registration Fee");
                    double fee = Convert.ToDouble(Console.ReadLine());
                    Vehicle.UpdateRegistrationFee(fee);
                    break;

                case 3:
                    // Exit the program
                    return;

                default:
                    // Handle invalid input
                    Console.WriteLine("INVALID FUNCTION");
                    break;
            }
        }
    }
}

class Vehicle
{
    // Static variable shared across all instances
    static double RegistrationFee = 500.0;

    // Instance variables
    public string OwnerName;
    public string VehicleType;
    readonly int RegistrationNumber;

    // Constructor to initialize a new vehicle
    public Vehicle(string ownerName, string vehicleType, int registrationNumber)
    {
        this.OwnerName = ownerName;
        this.VehicleType = vehicleType;
        this.RegistrationNumber = registrationNumber;
    }

    // Static method to update the registration fee
    public static void UpdateRegistrationFee(double newFee)
    {
        RegistrationFee = newFee;
        Console.WriteLine("Registration Fee updated to: " + RegistrationFee);
    }

    // Method to display vehicle details
    public void DisplayDetails()
    {
        Console.WriteLine("Owner Name: " + OwnerName);
        Console.WriteLine("Vehicle Type: " + VehicleType);
        Console.WriteLine("Registration Number: " + RegistrationNumber);
        Console.WriteLine("Registration Fee: " + RegistrationFee);
    }
}
