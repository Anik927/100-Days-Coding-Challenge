using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Appliance_Energy_Monitoring_System
{
    internal class Fan:Appliance
    {
        private int bladeSize;
        private int speedLevels;

        public Fan() { }

        public Fan(string applianceName, string brand,int bladeSize, int speedLevels):base( applianceName, brand)
        {
            this.bladeSize = bladeSize;
            this.speedLevels = speedLevels;
        }

        public int MaxCoolingEfficiency()
        {
            return bladeSize*speedLevels;
        }

        public string NoiseCategory()
        {
            if (bladeSize < 10)
                return "Low";
            else if (bladeSize >= 10 || bladeSize <= 15)
                return "Medium";
            else
                return "High";
        }



    }
}
