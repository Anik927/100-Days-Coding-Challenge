using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ticket_Booking_System
{
    internal class TrainTicket:Ticket
    {
        private string coachType;
        private double fare;

        public string CoachType
        {
            get { return coachType; }
            set { coachType = value; }
        }

        public double Fare
        {
            get { return fare; } 
            set {  fare = value; }
        }

        public bool IsACCoach()
        { 
            return coachType == "AC"; 
        }

        public double GetTaxAmount()
        {
            return fare*0.1;
        }

        public override void ShowDetails()
        {
            base.ShowDetails();
            Console.WriteLine(coachType);
            Console.WriteLine(fare);
        }

        public TrainTicket()
        {

        }

        public TrainTicket(int ticketId, string passengerName, string coachType, double fare):base(ticketId, passengerName)
        {
            this.coachType = coachType;
            this.fare = fare;
        }



    }
}
