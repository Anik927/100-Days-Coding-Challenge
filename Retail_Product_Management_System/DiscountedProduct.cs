using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Retail_Product_Management_System
{
    internal class DiscountedProduct:Product
    {
        private double discountPercent;
        private string category;

        public double DiscountPercent
        {
            get { return discountPercent; }
            set { discountPercent = value; }
        }

        public string Category
        {
            get { return category; }
            set { category = value; }
        }

        public DiscountedProduct()
        {

        }

        public DiscountedProduct(int productId, string name, double price, double discountPercent, string category):base(productId, name, price)
        {
            this.discountPercent = discountPercent;
            this.category = category;
        }

        public double GetFinalPrice()
        {
            double discountedPrice = price - (price * discountPercent);
            return discountedPrice + (discountPercent * vatRate);
        }

        public bool HasSeasonalOffer()
        {
            return category == "Festival" || category == "Winter";
        }

        public void ShowDetails()
        {
            base.ShowDetails();
            Console.WriteLine(discountPercent);
            Console.WriteLine(category);
        }

    }
}
