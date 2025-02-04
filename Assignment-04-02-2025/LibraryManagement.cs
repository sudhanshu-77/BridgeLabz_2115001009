// Sample Program 2: Library Management System
// Create a Book class to manage library books with the following features:
// static: 
// A static variable LibraryName shared across all books.
// A static method DisplayLibraryName() to print the library name.
// this: 
// Use this to initialize Title, Author, and ISBN in the constructor.
// readonly: 
// Use a readonly variable ISBN to ensure the unique identifier of a book cannot be changed.
// is operator: 
// Verify if an object is an instance of the Book class before displaying its details.



using System;

class LibraryManagement
{
    public static void Print()
    {
        while (true)
        {
            Console.WriteLine("1. Add Book");
            Console.WriteLine("2. Display Library Name");
            Console.WriteLine("3. Exit");

            int choice = Convert.ToInt16(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine("Enter the Book Title");
                    string title = Console.ReadLine();

                    Console.WriteLine("Enter the Author Name");
                    string author = Console.ReadLine();

                    Console.WriteLine("Enter the ISBN");
                    int isbn = Convert.ToInt32(Console.ReadLine());

                    Book book = new Book(title, author, isbn);

                    if (book is Book)
                    {
                        book.DisplayDetails();
                    }
                    break;

                case 2:
                    Book.DisplayLibraryName();
                    break;

                case 3:
                    return;

                default:
                    Console.WriteLine("INVALID FUNCTION");
                    break;
            }
        }
    }
}

class Book
{
    static string LibraryName = "City Library";
    public string Title;
    public string Author;
    readonly int ISBN;

    public Book(string title, string author, int isbn)
    {
        this.Title = title;
        this.Author = author;
        this.ISBN = isbn;
    }

    public static void DisplayLibraryName()
    {
        Console.WriteLine("Library Name: " + LibraryName);
    }

    public void DisplayDetails()
    {
        Console.WriteLine("Library Name: " + LibraryName);
        Console.WriteLine("Title: " + Title);
        Console.WriteLine("Author: " + Author);
        Console.WriteLine("ISBN: " + ISBN);
    }
}
