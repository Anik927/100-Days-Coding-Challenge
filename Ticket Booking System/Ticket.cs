using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ticket_Booking_System
{
    internal class Ticket
    {
        protected int ticketId;
        protected string passengerName;

        protected static int totalBooking;

        public int TicketID
        {
            get { return ticketId; }
            set { ticketId = value; }
        }

        public string PassengerName
        {
            get { return passengerName; }
            set { passengerName = value; }
        }

        public static int TotalBooking
        {
            get { return totalBooking; }
            set { totalBooking = value; }
        }

        public virtual void ShowDetails()
        {
            Console.WriteLine("Details:");
            Console.WriteLine(ticketId);
            Console.WriteLine(passengerName);
            Console.WriteLine(totalBooking);
        }

        public Ticket()
        {
            totalBooking++;
        }

        public Ticket(int ticketId, string passengerName)
        {
            this.ticketId = ticketId;
            this.passengerName = passengerName;
            totalBooking++;
        }
    }
}
