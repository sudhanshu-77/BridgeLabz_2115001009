using System;

class Vehicle
{
    public int MaxSpeed { get; set; }
    public string Model { get; set; }

    // Constructor to initialize the Vehicle's details
    public Vehicle(int maxSpeed, string model)
    {
        MaxSpeed = maxSpeed;
        Model = model;
    }
}

// Interface representing a Refuelable vehicle
interface Refuelable
{
    void Refuel();
}

// ElectricVehicle class inheriting from Vehicle
class ElectricVehicle : Vehicle
{
    // Constructor to initialize the ElectricVehicle's details
    public ElectricVehicle(int maxSpeed, string model) : base(maxSpeed, model) { }

    // Method to charge the electric vehicle
    public void Charge()
    {
        Console.WriteLine("Charging electric vehicle");
    }
}

// PetrolVehicle class inheriting from Vehicle and implementing Refuelable
class PetrolVehicle : Vehicle, Refuelable
{
    // Constructor to initialize the PetrolVehicle's details
    public PetrolVehicle(int maxSpeed, string model) : base(maxSpeed, model) { }

    // Implement the Refuel method
    public void Refuel()
    {
        Console.WriteLine("Refueling petrol vehicle");
    }
}

class MainVehicleManagement
{
    static void Main(string[] args)
    {
        // Create instances of ElectricVehicle and PetrolVehicle
        ElectricVehicle electricVehicle = new ElectricVehicle(150, "Tesla Model S");
        PetrolVehicle petrolVehicle = new PetrolVehicle(180, "Ford Mustang");

        // Charge and refuel vehicles
        electricVehicle.Charge();
        petrolVehicle.Refuel();
    }
}
