// 5. Library Management System
// Description: Develop a library management system:
// Use an abstract class LibraryItem with fields like itemId, title, and author.
// Add an abstract method GetLoanDuration() and a concrete method GetItemDetails().
// Create subclasses Book, Magazine, and DVD, overriding GetLoanDuration() with specific logic.
// Implement an interface IReservable with methods ReserveItem() and CheckAvailability().
// Apply encapsulation to secure details like the borrower’s personal data.
// Use polymorphism to allow a general LibraryItem reference to manage all items.


using System;
using System.Collections.Generic;

// Abstract class representing a Library Item
abstract class LibraryItem
{
    private string itemId;
    private string title;
    private string author;

    public string ItemId { get => itemId; set => itemId = value; }
    public string Title { get => title; set => title = value; }
    public string Author { get => author; set => author = value; }

    public abstract int GetLoanDuration();

    public void GetItemDetails()
    {
        Console.WriteLine($"Item ID: {ItemId}, Title: {Title}, Author: {Author}");
    }
}

// Interface for reservable items
interface IReservable
{
    void ReserveItem();
    bool CheckAvailability();
}

// Book class
class Book : LibraryItem, IReservable
{
    public override int GetLoanDuration()
    {
        return 14; //  loan duration
    }

    public void ReserveItem()
    {
        Console.WriteLine("Book reserved.");
    }

    public bool CheckAvailability()
    {
        return true; //  availability check
    }
}

// Magazine class
class Magazine : LibraryItem, IReservable
{
    public override int GetLoanDuration()
    {
        return 7; //  loan duration
    }

    public void ReserveItem()
    {
        Console.WriteLine("Magazine reserved.");
    }

    public bool CheckAvailability()
    {
        return false; //  availability check
    }
}

// DVD class
class DVD : LibraryItem, IReservable
{
    public override int GetLoanDuration()
    {
        return 3; //  loan duration
    }

    public void ReserveItem()
    {
        Console.WriteLine("DVD reserved.");
    }

    public bool CheckAvailability()
    {
        return true; //  availability check
    }
}

class Program
{
    static void Main(string[] args)
    {
        // List of library items
        List<LibraryItem> items = new List<LibraryItem>();

        // Taking user input for library items
        Console.WriteLine("Enter details for 3 library items:");

        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine($"\nEnter details for item {i + 1}:");
            Console.Write("Enter item type (Book/Magazine/DVD): ");
            string itemType = Console.ReadLine();

            Console.Write("Enter Item ID: ");
            string itemId = Console.ReadLine();

            Console.Write("Enter Title: ");
            string title = Console.ReadLine();

            Console.Write("Enter Author/Director: ");
            string author = Console.ReadLine();

            LibraryItem item = null;

            switch (itemType.ToLower())
            {
                case "book":
                    item = new Book { ItemId = itemId, Title = title, Author = author };
                    break;
                case "magazine":
                    item = new Magazine { ItemId = itemId, Title = title, Author = author };
                    break;
                case "dvd":
                    item = new DVD { ItemId = itemId, Title = title, Author = author };
                    break;
                default:
                    Console.WriteLine("Invalid item type. Please enter Book, Magazine, or DVD.");
                    i--; // Decrement index to re-enter details
                    continue;
            }

            items.Add(item);
        }

        // Process each item and display details
        foreach (var item in items)
        {
            item.GetItemDetails();
            Console.WriteLine($"Loan Duration: {item.GetLoanDuration()} days");

            if (item is IReservable reservableItem)
            {
                reservableItem.ReserveItem();
                Console.WriteLine($"Availability: {reservableItem.CheckAvailability()}");
            }
        }
    }
}
