using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Appliance_Energy_Monitoring_System
{
    internal class AC : Appliance
    {
        private int btu;
        private int starRating;

        public int Btu
        {
            get {  return btu; } 
            set     { btu = value; }
        }

        public int StarRating
        {
            get { return starRating; }
            set { starRating = value; }
        }

        public AC() { }

        public AC(string applianceName, string brand,int btu, int starRating):base( applianceName,  brand)
        {
            this.btu = btu;
            this.starRating = starRating;
        }

        public double MonthlyElectricityCost(int hours)
        {
            return btu * hours*0.05;
        }

        public void MonthlyElectricityCost(int hours, double unitCost)
        {
            double cost = btu * hours * unitCost;
            totalEnergyUsed += cost;
        }

        public bool IsEcoFriendly()
        {
            return starRating >= 4;
        }

    }
}
