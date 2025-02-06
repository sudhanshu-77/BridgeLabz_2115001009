Object Modeling: Object Relationships and Communication
Assisted Problems
Problem 1: Library and Books (Aggregation)
Description: Create a Library class that contains multiple Book objects. Model the relationship such that a library can have many books, but a book can exist independently (outside of a specific library).
Tasks:
Define a Library class with a List<Book> collection.
Define a Book class with attributes such as Title and Author.
Demonstrate the aggregation relationship by creating books and adding them to different libraries.
Goal: Understand aggregation by modeling a real-world relationship where the Library aggregates Book objects.

using System;
using System.Collections.Generic;

// Book class with attributes Title and Author
class Book
{
    public string Title { get; set; }
    public string Author { get; set; }

    public Book(string title, string author)
    {
        Title = title;
        Author = author;
    }
}

// Library class containing a collection of Book objects
class Library
{
    public string Name { get; set; }
    public List<Book> Books { get; set; }

    public Library(string name)
    {
        Name = name;
        Books = new List<Book>();
    }

    public void AddBook(Book book)
    {
        Books.Add(book);
    }

    public void DisplayBooks()
    {
        Console.WriteLine($"Library: {Name}");
        foreach (var book in Books)
        {
            Console.WriteLine($"Title: {book.Title}, Author: {book.Author}");
        }
    }
}

// Demonstration of aggregation
class Program
{
    static void Main(string[] args)
    {
        Book book1 = new Book("1984", "George Orwell");
        Book book2 = new Book("To Kill a Mockingbird", "Harper Lee");

        Library library1 = new Library("Central Library");
        library1.AddBook(book1);
        library1.AddBook(book2);

        Library library2 = new Library("Community Library");
        library2.AddBook(book1); // Same book can exist in multiple libraries

        library1.DisplayBooks();
        library2.DisplayBooks();
    }
}



