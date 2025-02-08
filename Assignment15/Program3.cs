using System;

class Vehicle
{
    public int MaxSpeed { get; set; }
    public string FuelType { get; set; }

    public Vehicle(int maxSpeed, string fuelType)
    {
        MaxSpeed = maxSpeed;
        FuelType = fuelType;
    }

    public virtual void DisplayInfo()
    {
        Console.WriteLine($"Max Speed: {MaxSpeed}, Fuel Type: {FuelType}");
    }
}

class Car : Vehicle
{
    public int SeatCapacity { get; set; }

    public Car(int maxSpeed, string fuelType, int seatCapacity)
        : base(maxSpeed, fuelType)
    {
        SeatCapacity = seatCapacity;
    }

    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"Seat Capacity: {SeatCapacity}");
    }
}

class Truck : Vehicle
{
    public int PayloadCapacity { get; set; }

    public Truck(int maxSpeed, string fuelType, int payloadCapacity)
        : base(maxSpeed, fuelType)
    {
        PayloadCapacity = payloadCapacity;
    }

    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"Payload Capacity: {PayloadCapacity}");
    }
}

class Motorcycle : Vehicle
{
    public bool HasSidecar { get; set; }

    public Motorcycle(int maxSpeed, string fuelType, bool hasSidecar)
        : base(maxSpeed, fuelType)
    {
        HasSidecar = hasSidecar;
    }

    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"Has Sidecar: {HasSidecar}");
    }
}

class MainVehicle
{
    static void Main(string[] args)
    {
     
        Vehicle car = new Car(200, "Petrol", 5);
        Vehicle truck = new Truck(120, "Diesel", 10000);
        Vehicle motorcycle = new Motorcycle(180, "Petrol", false);

       
        Vehicle[] vehicles = { car, truck, motorcycle };
        foreach (var vehicle in vehicles)
        {
            vehicle.DisplayInfo();
            Console.WriteLine();
        }
    }
}
