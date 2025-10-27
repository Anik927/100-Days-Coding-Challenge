using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Appliance_Energy_Monitoring_System
{
    internal class Appliance
    {
        protected string applianceName;
        protected string brand;

        protected double totalEnergyUsed;

        public string ApplianceName
        {
            get { return applianceName; }
            set { applianceName = value; }
        }

        public string Brand
        {
            get { return brand; }
            set { brand = value; }
        }

        public double TotalEnergyUsed
        {
            get { return totalEnergyUsed; }
            set { totalEnergyUsed = value; }
        }
        
        public virtual void ShowDetails()
        {
            Console.WriteLine(applianceName);
            Console.WriteLine(brand);
            Console.WriteLine(totalEnergyUsed);
        }

        public Appliance() { }

        public Appliance(string applianceName, string brand)
        {
            this.applianceName = applianceName;
            this.brand = brand;
        }


    }
}
