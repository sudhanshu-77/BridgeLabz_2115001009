using System;

public class Book
{
    public string Title { get; set; }
    public string Author { get; set; }
    public string Genre { get; set; }
    public int BookID { get; set; }
    public bool IsAvailable { get; set; }
    public Book Next { get; set; }
    public Book Prev { get; set; }
}

public class LibraryLinkedList
{
    private Book head;
    private Book tail;
    private int count;

    public void AddBookAtBeginning(string title, string author, string genre, int bookId, bool isAvailable)
    {
        Book newBook = new Book
        {
            Title = title,
            Author = author,
            Genre = genre,
            BookID = bookId,
            IsAvailable = isAvailable,
            Next = head,
            Prev = null
        };

        if (head != null)
        {
            head.Prev = newBook;
        }
        head = newBook;

        if (tail == null)
        {
            tail = newBook;
        }

        count++;
    }

    public void AddBookAtEnd(string title, string author, string genre, int bookId, bool isAvailable)
    {
        Book newBook = new Book
        {
            Title = title,
            Author = author,
            Genre = genre,
            BookID = bookId,
            IsAvailable = isAvailable,
            Next = null,
            Prev = tail
        };

        if (tail != null)
        {
            tail.Next = newBook;
        }
        tail = newBook;

        if (head == null)
        {
            head = newBook;
        }

        count++;
    }

    public void RemoveBookById(int bookId)
    {
        Book current = head;
        while (current != null)
        {
            if (current.BookID == bookId)
            {
                if (current.Prev != null)
                {
                    current.Prev.Next = current.Next;
                }
                else
                {
                    head = current.Next;
                }

                if (current.Next != null)
                {
                    current.Next.Prev = current.Prev;
                }
                else
                {
                    tail = current.Prev;
                }

                count--;
                return;
            }
            current = current.Next;
        }
    }

    public Book SearchBookByTitle(string title)
    {
        Book current = head;
        while (current != null)
        {
            if (current.Title.Equals(title, StringComparison.OrdinalIgnoreCase))
            {
                return current;
            }
            current = current.Next;
        }
        return null;
    }

    public Book SearchBookByAuthor(string author)
    {
        Book current = head;
        while (current != null)
        {
            if (current.Author.Equals(author, StringComparison.OrdinalIgnoreCase))
            {
                return current;
            }
            current = current.Next;
        }
        return null;
    }

    public void UpdateBookAvailability(int bookId, bool isAvailable)
    {
        Book book = SearchBookById(bookId);
        if (book != null)
        {
            book.IsAvailable = isAvailable;
        }
    }

    private Book SearchBookById(int bookId)
    {
        Book current = head;
        while (current != null)
        {
            if (current.BookID == bookId)
            {
                return current;
            }
            current = current.Next;
        }
        return null;
    }

    public void DisplayAllBooksForward()
    {
        Book current = head;
        while (current != null)
        {
            Console.WriteLine($"Title: {current.Title}, Author: {current.Author}, Genre: {current.Genre}, Book ID: {current.BookID}, Available: {current.IsAvailable}");
            current = current.Next;
        }
    }

    public void DisplayAllBooksReverse()
    {
        Book current = tail;
        while (current != null)
        {
            Console.WriteLine($"Title: {current.Title}, Author: {current.Author}, Genre: {current.Genre}, Book ID: {current.BookID}, Available: {current.IsAvailable}");
            current = current.Prev;
        }
    }

    public int CountTotalBooks()
    {
        return count;
    }
}

class Program
{
    static void Main()
    {
        LibraryLinkedList library = new LibraryLinkedList();
        library.AddBookAtBeginning("Godaan", "Munshi Premchand", "Fiction", 101, true);
        library.AddBookAtEnd("1984", "Karambhoomi", "Fiction", 102, true);
        library.AddBookAtEnd("Rangbhoomi", "Munshi Premchand", "Fiction", 103, false);

        Console.WriteLine("All Books (Forward):");
        library.DisplayAllBooksForward();

        Console.WriteLine("\nAll Books (Reverse):");
        library.DisplayAllBooksReverse();

        Console.WriteLine("\nTotal Number of Books: " + library.CountTotalBooks());

        Console.WriteLine("\nUpdating availability of '1984' to false");
        library.UpdateBookAvailability(102, false);

        Console.WriteLine("\nAll Books after update:");
        library.DisplayAllBooksForward();

        Console.WriteLine("\nRemoving book with ID 101");
        library.RemoveBookById(101);

        Console.WriteLine("\nAll Books after removal:");
        library.DisplayAllBooksForward();

        Console.WriteLine("\nTotal Number of Books: " + library.CountTotalBooks());
    }
}
