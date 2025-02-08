using System;

class Book
{
    public string Title { get; set; }
    public int PublicationYear { get; set; }

    // Constructor to initialize the Book's details
    public Book(string title, int publicationYear)
    {
        Title = title;
        PublicationYear = publicationYear;
    }

    // Virtual method to display book information
    public virtual void DisplayInfo()
    {
        Console.WriteLine($"Title: {Title}, Publication Year: {PublicationYear}");
    }
}

class Author : Book
{
    public string Name { get; set; }
    public string Bio { get; set; }

    // Constructor to initialize the Author's details
    public Author(string title, int publicationYear, string name, string bio)
        : base(title, publicationYear)
    {
        Name = name;
        Bio = bio;
    }

    // Override the DisplayInfo method to include Author's details
    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"Author: {Name}, Bio: {Bio}");
    }
}

class MainLibrary
{
    static void Main(string[] args)
    {
        // Create an instance of Author
        Author author = new Author("C# Programming", 2021, "Ravi", "Expert in C# and .NET");

        // Display book and author information
        author.DisplayInfo();
    }
}
