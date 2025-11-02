using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ticket_Booking_System
{
    internal class FlightTicket:Ticket
    {
        private string seatClass;
        private double luggageWeight;

        public string SeatClass
        {
            get { return seatClass; }
            set { seatClass = value; }
        }

        public double LuggageWeight
        {
            get { return luggageWeight; }
            set { luggageWeight = value; }
        }

        public override void ShowDetails()
        {
            base.ShowDetails();
            Console.WriteLine(seatClass);
            Console.WriteLine(luggageWeight);
        }

        public bool IsExcessLuggage()
        {
            return luggageWeight > 20;
        }

        public bool IsPrioritySeat()
        {
            return seatClass == "Business";
        }

        public bool IsPrioritySeat(bool isFrequentFlyer)
        {
            if (isFrequentFlyer == true && seatClass == "Business")
                return true;
            else 
                return false;
        }

        public FlightTicket()
        {

        }

        public FlightTicket(int ticketId, string passengerName, string seatClass, double luggageWeight):base(ticketId, passengerName)
        {
            this.seatClass = seatClass;
            this.luggageWeight= luggageWeight;
        }


    }
}
