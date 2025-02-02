
// Library Book System
// Create a Book class with attributes title, author, price, and availability.
// Implement a method BorrowBook() to borrow a book.

using System;

class LibraryBook
{
    private string title;
    private string author;
    private double price;
    private bool availability;

    // Constructor
    public LibraryBook(string title, string author, double price, bool availability)
    {
        this.title = title;
        this.author = author;
        this.price = price;
        this.availability = availability;
    }

    // Method to borrow a book
    public void BorrowBook()
    {
        if (availability)
        {
            availability = false;
            Console.WriteLine($"The book '{title}' has been borrowed.");
        }
        else
        {
            Console.WriteLine($"The book '{title}' is not available.");
        }
    }

    // Method to display book details
    public void DisplayBookDetails()
    {
        Console.WriteLine($"Title: {title}, Author: {author}, Price: {price}, Available: {availability}");
    }
}


