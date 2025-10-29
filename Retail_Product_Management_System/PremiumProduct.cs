using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Retail_Product_Management_System
{
    internal class PremiumProduct:Product
    {
        private int warrantyYears;
        private string countryOfOrigin;

        public int WarrantyYears
        {
            get { return warrantyYears; }
            set { warrantyYears = value; }
        }

        public string CountryOfOrigin
        {
            get{ return countryOfOrigin; }
            set { countryOfOrigin = value; }
        }

        public void ShowDetails()
        {
            base.ShowDetails();
            Console.WriteLine(warrantyYears);
            Console.WriteLine(countryOfOrigin);
        }

        public bool IsEligibleForVIPReturn()
        {
            return warrantyYears >= 2;
        }



        public PremiumProduct()
        {

        }

        public PremiumProduct(int productId, string name, double price, int warrantyYears, string countryOfOrigin):base(productId,  name, price)
        {
            this.warrantyYears= warrantyYears; 
            this.countryOfOrigin= countryOfOrigin;
        }

        public void ShowWarrantyInfo()
        {
            Console.WriteLine("Warranty: " + warrantyYears + "years");
        }

        public void ShowWarrantyInfo(string note)
        {
            Console.WriteLine("Warranty: " + warrantyYears + "years" + note);
        }

    }
}
