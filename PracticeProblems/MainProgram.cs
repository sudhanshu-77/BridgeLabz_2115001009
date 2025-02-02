using System;

class MainProgram
{
    static void Main(string[] args)
    {
        Console.WriteLine("Executing all programs sequentially");

        Book book1 = new Book();
        book1.DisplayBookDetails();
        Console.ReadKey();  

        Book book2 = new Book("1984", "George Orwell", 15.99);
        book2.DisplayBookDetails();
        Console.ReadKey();  

        Circle circle1 = new Circle();
        circle1.DisplayCircleDetails();
        Console.ReadKey();  

        Circle circle2 = new Circle(5.5);
        circle2.DisplayCircleDetails();
        Console.ReadKey();  

        Person person1 = new Person("John Doe", 30);
        person1.DisplayPersonDetails();
        Console.ReadKey();  

        Person person2 = new Person(person1);
        person2.DisplayPersonDetails();
        Console.ReadKey();  

        HotelBooking booking1 = new HotelBooking();
        booking1.DisplayBookingDetails();
        Console.ReadKey();  

        HotelBooking booking2 = new HotelBooking("Alice", "Deluxe", 3);
        booking2.DisplayBookingDetails();
        Console.ReadKey();  

        LibraryBook libraryBook1 = new LibraryBook("The Great Gatsby", "F. Scott Fitzgerald", 10.99, true);
        libraryBook1.DisplayBookDetails();
        libraryBook1.BorrowBook();
        libraryBook1.DisplayBookDetails();
        Console.ReadKey();  

        CarRental rental1 = new CarRental("Bob", "Toyota Camry", 5);
        rental1.DisplayRentalDetails();
        Console.ReadKey();  

        Console.WriteLine("All programs successfully executed.");
    }
}



