// Car Rental System
// Create a CarRental class with attributes customerName, carModel, and rentalDays.
// Add constructors to initialize the rental details and calculate total cost.

using System;

class CarRental
{
    private string customerName;
    private string carModel;
    private int rentalDays;
    private double totalCost;

    // Constructor
    public CarRental(string customerName, string carModel, int rentalDays)
    {
        this.customerName = customerName;
        this.carModel = carModel;
        this.rentalDays = rentalDays;
        this.totalCost = CalculateTotalCost();
    }

    // Method to calculate total cost
    private double CalculateTotalCost()
    {
        double dailyRate = 50.0; // Example rate
        return rentalDays * dailyRate;
    }

    // Method to display rental details
    public void DisplayRentalDetails()
    {
        Console.WriteLine($"Customer Name: {customerName}, Car Model: {carModel}, Rental Days: {rentalDays}, Total Cost: {totalCost}");
    }
}

