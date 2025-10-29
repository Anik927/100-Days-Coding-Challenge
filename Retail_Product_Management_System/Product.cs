using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Retail_Product_Management_System
{
    internal class Product
    {
        protected int productId;
        protected string name;
        protected double price;

        protected static double vatRate = .1;

        public int ProductId
        {
            get { return productId; } 
            set { productId = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public double Price
        {
            get { return price; }
            set { price = value; }
        }

        public static double VatRate
        { 
            get { return vatRate; }
            set { vatRate = value; }
        }

        public Product()
        {

        }

        public Product(int productId, string name, double price)
        {
            this.name = name;
            this.productId = productId;
            this.price = price;
        }

        public void ShowDetails()
        {
            Console.WriteLine(productId);
            Console.WriteLine(name);
            Console.WriteLine(price);
            Console.WriteLine("Vat Rate: "+vatRate);

        }

    }
}
