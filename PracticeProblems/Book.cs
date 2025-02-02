// Level 1 Practice Programs
// Book Class
// Create a Book class with attributes title, author, and price.
// Provide both default and parameterized constructors.
// using System;
class Book
{
    private string title;
    private string author;
    private double price;

    // Default constructor
    public Book()
    {
        this.title = "Unknown";
        this.author = "Unknown";
        this.price = 0.0;
    }

    // Parameterized constructor
    public Book(string title, string author, double price)
    {
        this.title = title;
        this.author = author;
        this.price = price;
    }

    // Method to display book details
    public void DisplayBookDetails()
    {
        Console.WriteLine($"Title: {title}, Author: {author}, Price: {price}");
    }
}

