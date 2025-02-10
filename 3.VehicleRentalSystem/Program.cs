// 3. Vehicle Rental System
// Description: Design a system to manage vehicle rentals:
// Define an abstract class Vehicle with fields like vehicleNumber, type, and rentalRate.
// Add an abstract method CalculateRentalCost(int days).
// Create subclasses Car, Bike, and Truck with specific implementations of CalculateRentalCost().
// Use an interface IInsurable with methods CalculateInsurance() and GetInsuranceDetails().
// Apply encapsulation to restrict access to sensitive details like insurance policy numbers.
// Demonstrate polymorphism by iterating over a list of vehicles and calculating rental and insurance costs for each.


using System;
using System.Collections.Generic;

// Abstract class representing a Vehicle
abstract class Vehicle
{
    private string vehicleNumber;
    private string type;
    private double rentalRate;

    public string VehicleNumber { get => vehicleNumber; set => vehicleNumber = value; }
    public string Type { get => type; set => type = value; }
    public double RentalRate { get => rentalRate; set => rentalRate = value; }

    public abstract double CalculateRentalCost(int days);

    public void DisplayVehicleDetails()
    {
        Console.WriteLine($"Vehicle Number: {VehicleNumber}, Type: {Type}, Rental Rate: {RentalRate}");
    }
}

// Interface for insurable vehicles
interface IInsurable
{
    double CalculateInsurance();
    string GetInsuranceDetails();
}

// Car class
class Car : Vehicle, IInsurable
{
    public override double CalculateRentalCost(int days)
    {
        return RentalRate * days; //    rental cost calculation
    }

    public double CalculateInsurance()
    {
        return 100; //    insurance calculation
    }

    public string GetInsuranceDetails()
    {
        return "Insurance: $100";
    }
}

// Bike class
class Bike : Vehicle, IInsurable
{
    public override double CalculateRentalCost(int days)
    {
        return RentalRate * days * 0.8; //    rental cost calculation
    }

    public double CalculateInsurance()
    {
        return 50; //    insurance calculation
    }

    public string GetInsuranceDetails()
    {
        return "Insurance: $50";
    }
}

// Truck class
class Truck : Vehicle, IInsurable
{
    public override double CalculateRentalCost(int days)
    {
        return RentalRate * days * 1.5; //    rental cost calculation
    }

    public double CalculateInsurance()
    {
        return 200; //    insurance calculation
    }

    public string GetInsuranceDetails()
    {
        return "Insurance: $200";
    }
}

class Program
{
    static void Main(string[] args)
    {
        List<Vehicle> vehicles = new List<Vehicle>();

        Console.Write("Enter the number of vehicles: ");
        int numberOfVehicles = int.Parse(Console.ReadLine());

        for (int i = 0; i < numberOfVehicles; i++)
        {
            Console.WriteLine($"Enter details for vehicle {i + 1}:");
            Console.Write("Enter Vehicle Number: ");
            string vehicleNumber = Console.ReadLine();
            Console.Write("Enter Vehicle Type (Car/Bike/Truck): ");
            string type = Console.ReadLine();
            Console.Write("Enter Rental Rate: ");
            double rentalRate = double.Parse(Console.ReadLine());

            Vehicle vehicle;
            switch (type.ToLower())
            {
                case "car":
                    vehicle = new Car { VehicleNumber = vehicleNumber, Type = type, RentalRate = rentalRate };
                    break;
                case "bike":
                    vehicle = new Bike { VehicleNumber = vehicleNumber, Type = type, RentalRate = rentalRate };
                    break;
                case "truck":
                    vehicle = new Truck { VehicleNumber = vehicleNumber, Type = type, RentalRate = rentalRate };
                    break;
                default:
                    Console.WriteLine("Invalid vehicle type. Skipping this entry.");
                    continue;
            }

            vehicles.Add(vehicle);
        }

        Console.Write("Enter the number of rental days: ");
        int rentalDays = int.Parse(Console.ReadLine());

        // Process each vehicle and display details
        foreach (var vehicle in vehicles)
        {
            vehicle.DisplayVehicleDetails();
            Console.WriteLine($"Rental Cost for {rentalDays} days: {vehicle.CalculateRentalCost(rentalDays)}");

            if (vehicle is IInsurable insurableVehicle)
            {
                Console.WriteLine(insurableVehicle.GetInsuranceDetails());
            }
        }
    }
}
