using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int? TicketOnSale = 100;
            int AvailableTickets = TicketOnSale ?? 10;

            Console.WriteLine("Available Tickets = {0}", AvailableTickets);
        }
    }
}
