using System;

class Device
{
    public string DeviceId { get; set; }
    public string Status { get; set; }

    // Constructor to initialize the Device's details
    public Device(string deviceId, string status)
    {
        DeviceId = deviceId;
        Status = status;
    }

    // Virtual method to display device status
    public virtual void DisplayStatus()
    {
        Console.WriteLine($"Device ID: {DeviceId}, Status: {Status}");
    }
}

// Thermostat class inheriting from Device
class Thermostat : Device
{
    public double TemperatureSetting { get; set; }

    // Constructor to initialize the Thermostat's details
    public Thermostat(string deviceId, string status, double temperatureSetting)
        : base(deviceId, status)
    {
        TemperatureSetting = temperatureSetting;
    }

    // Override the DisplayStatus method to include TemperatureSetting
    public override void DisplayStatus()
    {
        base.DisplayStatus();
        Console.WriteLine($"Temperature Setting: {TemperatureSetting}°C");
    }
}

class MainDevice
{
    static void Main(string[] args)
    {
        // Create an instance of Thermostat
        Thermostat thermostat = new Thermostat("TH123", "Active", 22.5);

        // Display device status
        thermostat.DisplayStatus();
    }
}
