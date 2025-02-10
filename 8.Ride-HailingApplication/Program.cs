// 8. Ride-Hailing Application
// Description: Develop a ride-hailing application.
// Abstract Class:
// Define an abstract class Vehicle with fields: vehicleId, driverName, and ratePerKm.
// Add an abstract method CalculateFare(double distance).
// Implement a concrete method GetVehicleDetails().
// Subclasses:
// Extend Vehicle into Car, Bike, and Auto.
// Override CalculateFare() based on type-specific rates.
// Interface:
// Implement an interface IGPS.
// Define methods GetCurrentLocation() and UpdateLocation().
// Encapsulation:
// Secure driver and vehicle details using private fields and properties.
// Polymorphism:
// Create a method that processes multiple vehicle types dynamically.
// Calculate fares based on the Vehicle reference.


using System;
using System.Collections.Generic;

// Abstract class representing a Vehicle
abstract class Vehicle
{
    private string vehicleId;
    private string driverName;
    private double ratePerKm;

    public string VehicleId { get => vehicleId; set => vehicleId = value; }
    public string DriverName { get => driverName; set => driverName = value; }
    public double RatePerKm { get => ratePerKm; set => ratePerKm = value; }

    public abstract double CalculateFare(double distance);

    public void GetVehicleDetails()
    {
        Console.WriteLine($"Vehicle ID: {VehicleId}, Driver Name: {DriverName}, Rate per Km: {RatePerKm}");
    }
}

// Interface for GPS functionality
interface IGPS
{
    string GetCurrentLocation();
    void UpdateLocation(string location);
}

// Car class
class Car : Vehicle, IGPS
{
    private string currentLocation;

    public override double CalculateFare(double distance)
    {
        return RatePerKm * distance; //   fare calculation
    }

    public string GetCurrentLocation()
    {
        return currentLocation;
    }

    public void UpdateLocation(string location)
    {
        currentLocation = location;
    }
}

// Bike class
class Bike : Vehicle, IGPS
{
    private string currentLocation;

    public override double CalculateFare(double distance)
    {
        return RatePerKm * distance * 0.8; //   fare calculation
    }

    public string GetCurrentLocation()
    {
        return currentLocation;
    }

    public void UpdateLocation(string location)
    {
        currentLocation = location;
    }
}

// Auto class
class Auto : Vehicle, IGPS
{
    private string currentLocation;

    public override double CalculateFare(double distance)
    {
        return RatePerKm * distance * 1.2; //   fare calculation
    }

    public string GetCurrentLocation()
    {
        return currentLocation;
    }

    public void UpdateLocation(string location)
    {
        currentLocation = location;
    }
}

class Program
{
    static void Main(string[] args)
    {
        List<Vehicle> vehicles = new List<Vehicle>();

        Console.WriteLine("Enter details for 3 vehicles:");

        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine($"Enter details for vehicle {i + 1}:");

            Console.Write("Enter vehicle type (Car/Bike/Auto): ");
            string vehicleType = Console.ReadLine();

            Console.Write("Enter Vehicle ID: ");
            string vehicleId = Console.ReadLine();

            Console.Write("Enter Driver Name: ");
            string driverName = Console.ReadLine();

            Console.Write("Enter Rate per Km: ");
            double ratePerKm = double.Parse(Console.ReadLine());

            Vehicle vehicle = null;

            switch (vehicleType.ToLower())
            {
                case "car":
                    vehicle = new Car { VehicleId = vehicleId, DriverName = driverName, RatePerKm = ratePerKm };
                    break;
                case "bike":
                    vehicle = new Bike { VehicleId = vehicleId, DriverName = driverName, RatePerKm = ratePerKm };
                    break;
                case "auto":
                    vehicle = new Auto { VehicleId = vehicleId, DriverName = driverName, RatePerKm = ratePerKm };
                    break;
                default:
                    Console.WriteLine("Invalid vehicle type. Please enter Car, Bike, or Auto.");
                    i--; // Decrement index to re-enter details
                    continue;
            }

            vehicles.Add(vehicle);
        }

        // Process each vehicle and display details
        foreach (var vehicle in vehicles)
        {
            vehicle.GetVehicleDetails();
            Console.WriteLine($"Fare for 10 km: {vehicle.CalculateFare(10)}");

            if (vehicle is IGPS gpsVehicle)
            {
                gpsVehicle.UpdateLocation("Delhi");
                Console.WriteLine($"Current Location: {gpsVehicle.GetCurrentLocation()}");
            }
        }
    }
}
