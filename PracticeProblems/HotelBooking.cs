
// Hotel Booking System
// Create a HotelBooking class with attributes guestName, roomType, and nights.
// Use default, parameterized, and copy constructors to initialize bookings.

using System;

class HotelBooking
{
    private string guestName;
    private string roomType;
    private int nights;

    // Default constructor
    public HotelBooking()
    {
        this.guestName = "Unknown";
        this.roomType = "Standard";
        this.nights = 1;
    }

    // Parameterized constructor
    public HotelBooking(string guestName, string roomType, int nights)
    {
        this.guestName = guestName;
        this.roomType = roomType;
        this.nights = nights;
    }

    // Copy constructor
    public HotelBooking(HotelBooking other)
    {
        this.guestName = other.guestName;
        this.roomType = other.roomType;
        this.nights = other.nights;
    }

    // Method to display booking details
    public void DisplayBookingDetails()
    {
        Console.WriteLine($"Guest Name: {guestName}, Room Type: {roomType}, Nights: {nights}");
    }
}

