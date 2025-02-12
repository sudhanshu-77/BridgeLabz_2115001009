using System;

public class Movie
{
    public string Title { get; set; }
    public string Director { get; set; }
    public int YearOfRelease { get; set; }
    public double Rating { get; set; }
    public Movie Next { get; set; }
    public Movie Prev { get; set; }
}

public class MovieLinkedList
{
    private Movie head;
    private Movie tail;

    public void AddMovieAtBeginning(string title, string director, int yearOfRelease, double rating)
    {
        Movie newMovie = new Movie
        {
            Title = title,
            Director = director,
            YearOfRelease = yearOfRelease,
            Rating = rating,
            Next = head,
            Prev = null
        };

        if (head != null)
        {
            head.Prev = newMovie;
        }
        head = newMovie;

        if (tail == null)
        {
            tail = newMovie;
        }
    }

    public void AddMovieAtEnd(string title, string director, int yearOfRelease, double rating)
    {
        Movie newMovie = new Movie
        {
            Title = title,
            Director = director,
            YearOfRelease = yearOfRelease,
            Rating = rating,
            Next = null,
            Prev = tail
        };

        if (tail != null)
        {
            tail.Next = newMovie;
        }
        tail = newMovie;

        if (head == null)
        {
            head = newMovie;
        }
    }

    public void RemoveMovieByTitle(string title)
    {
        Movie current = head;
        while (current != null)
        {
            if (current.Title == title)
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
                return;
            }
            current = current.Next;
        }
    }

    public Movie SearchMovieByDirector(string director)
    {
        Movie current = head;
        while (current != null)
        {
            if (current.Director == director)
            {
                return current;
            }
            current = current.Next;
        }
        return null;
    }

    public Movie SearchMovieByRating(double rating)
    {
        Movie current = head;
        while (current != null)
        {
            if (current.Rating == rating)
            {
                return current;
            }
            current = current.Next;
        }
        return null;
    }

    public void DisplayAllMoviesForward()
    {
        Movie current = head;
        while (current != null)
        {
            Console.WriteLine($"Title: {current.Title}, Director: {current.Director}, Year: {current.YearOfRelease}, Rating: {current.Rating}");
            current = current.Next;
        }
    }

    public void DisplayAllMoviesReverse()
    {
        Movie current = tail;
        while (current != null)
        {
            Console.WriteLine($"Title: {current.Title}, Director: {current.Director}, Year: {current.YearOfRelease}, Rating: {current.Rating}");
            current = current.Prev;
        }
    }

    public void UpdateMovieRating(string title, double newRating)
    {
        Movie movie = SearchMovieByTitle(title);
        if (movie != null)
        {
            movie.Rating = newRating;
        }
    }

    private Movie SearchMovieByTitle(string title)
    {
        Movie current = head;
        while (current != null)
        {
            if (current.Title == title)
            {
                return current;
            }
            current = current.Next;
        }
        return null;
    }
}

class Program
{
    static void Main()
    {
        MovieLinkedList movieList = new MovieLinkedList();
        movieList.AddMovieAtBeginning("Inception", "Christopher", 2010, 8.8);
        movieList.AddMovieAtEnd("The Matrix", "Wachowski", 1999, 8.7);
        movieList.AddMovieAtEnd("Interstellar", "Christopher Nolan", 2014, 8.6);

        Console.WriteLine("All Movies (Forward):");
        movieList.DisplayAllMoviesForward();

        Console.WriteLine("\nAll Movies (Reverse):");
        movieList.DisplayAllMoviesReverse();

        Console.WriteLine("\nUpdating 'The Matrix' rating to 9.0");
        movieList.UpdateMovieRating("The Matrix", 9.0);

        Console.WriteLine("\nAll Movies after update:");
        movieList.DisplayAllMoviesForward();

        Console.WriteLine("\nRemoving movie 'Inception'");
        movieList.RemoveMovieByTitle("Inception");

        Console.WriteLine("\nAll Movies after removal:");
        movieList.DisplayAllMoviesForward();
    }
}
