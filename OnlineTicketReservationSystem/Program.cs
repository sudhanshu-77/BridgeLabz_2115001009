using System;

public class Ticket
{
    public int TicketID { get; set; }
    public string CustomerName { get; set; }
    public string MovieName { get; set; }
    public string SeatNumber { get; set; }
    public DateTime BookingTime { get; set; }
    public Ticket Next { get; set; }
}

public class TicketReservationSystem
{
    private Ticket head;

    public void AddTicket(int ticketId, string customerName, string movieName, string seatNumber, DateTime bookingTime)
    {
        Ticket newTicket = new Ticket
        {
            TicketID = ticketId,
            CustomerName = customerName,
            MovieName = movieName,
            SeatNumber = seatNumber,
            BookingTime = bookingTime
        };

        if (head == null)
        {
            head = newTicket;
            newTicket.Next = head;
        }
        else
        {
            Ticket temp = head;
            while (temp.Next != head)
            {
                temp = temp.Next;
            }
            temp.Next = newTicket;
            newTicket.Next = head;
        }
    }

    public void RemoveTicketById(int ticketId)
    {
        if (head == null) return;

        Ticket current = head;
        Ticket previous = null;

        do
        {
            if (current.TicketID == ticketId)
            {
                if (previous != null)
                {
                    previous.Next = current.Next;
                }
                else
                {
                    Ticket temp = head;
                    while (temp.Next != head)
                    {
                        temp = temp.Next;
                    }
                    head = current.Next;
                    temp.Next = head;
                }
                return;
            }
            previous = current;
            current = current.Next;
        } while (current != head);
    }

    public void DisplayAllTickets()
    {
        if (head == null) return;

        Ticket temp = head;
        do
        {
            Console.WriteLine($"Ticket ID: {temp.TicketID}, Customer Name: {temp.CustomerName}, Movie Name: {temp.MovieName}, Seat Number: {temp.SeatNumber}, Booking Time: {temp.BookingTime}");
            temp = temp.Next;
        } while (temp != head);
    }

    public Ticket SearchTicketByCustomerName(string customerName)
    {
        if (head == null) return null;

        Ticket temp = head;
        do
        {
            if (temp.CustomerName.Equals(customerName, StringComparison.OrdinalIgnoreCase))
            {
                return temp;
            }
            temp = temp.Next;
        } while (temp != head);

        return null;
    }

    public Ticket SearchTicketByMovieName(string movieName)
    {
        if (head == null) return null;

        Ticket temp = head;
        do
        {
            if (temp.MovieName.Equals(movieName, StringComparison.OrdinalIgnoreCase))
            {
                return temp;
            }
            temp = temp.Next;
        } while (temp != head);

        return null;
    }

    public int CountTotalTickets()
    {
        if (head == null) return 0;

        int count = 0;
        Ticket temp = head;
        do
        {
            count++;
            temp = temp.Next;
        } while (temp != head);

        return count;
    }
}

class Program
{
    static void Main()
    {
        TicketReservationSystem reservationSystem = new TicketReservationSystem();
        reservationSystem.AddTicket(1, "Sudhanshu", "Inception", "A1", DateTime.Now);
        reservationSystem.AddTicket(2, "Vaibhav", "The Matrix", "B2", DateTime.Now);
        reservationSystem.AddTicket(3, "Siddhant", "Interstellar", "C3", DateTime.Now);

        Console.WriteLine("All Tickets:");
        reservationSystem.DisplayAllTickets();

        Console.WriteLine("\nSearching for ticket by Customer Name 'Sudhanshu':");
        Ticket ticket = reservationSystem.SearchTicketByCustomerName("Sudhanshu");
        if (ticket != null)
        {
            Console.WriteLine($"Found Ticket ID: {ticket.TicketID}, Movie Name: {ticket.MovieName}");
        }

        Console.WriteLine("\nTotal Number of Booked Tickets: " + reservationSystem.CountTotalTickets());

        Console.WriteLine("\nRemoving Ticket with ID 2");
        reservationSystem.RemoveTicketById(2);

        Console.WriteLine("\nAll Tickets after removal:");
        reservationSystem.DisplayAllTickets();

        Console.WriteLine("\nTotal Number of Booked Tickets: " + reservationSystem.CountTotalTickets());
    }
}
