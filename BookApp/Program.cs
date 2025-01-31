using System;

public class Book
{
    // Fields (Attributes)
    private string title;
    private string author;
    private double price;

    // Constructor
    public Book(string title, string author, double price)
    {
        this.title = title;
        this.author = author;
        this.price = price;
    }

    // Method to display book details
    public void DisplayDetails()
    {
        Console.WriteLine("Title: " + title);
        Console.WriteLine("Author: " + author);
        Console.WriteLine("Price: $" + price);
    }
}

// Main Class to Test
public class Program
{
    public static void Main(string[] args)
    {
        // Create Book objects
        Book book1 = new Book("1984", "George Orwell", 15.99);
        Book book2 = new Book("To Kill a Mockingbird", "Harper Lee", 12.99);

        // Display details of each book
        Console.WriteLine("=== Book 1 ===");
        book1.DisplayDetails();
        Console.WriteLine("\n=== Book 2 ===");
        book2.DisplayDetails();
    }
}
