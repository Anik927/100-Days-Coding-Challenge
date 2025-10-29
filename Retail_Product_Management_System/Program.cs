using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Retail_Product_Management_System
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product.VatRate = 3;
            Product p1 = new Product();
            Product p2 = new Product(1,"Laptop",5000);            
            //p2.ShowDetails();

            DiscountedProduct.VatRate = 5;
            DiscountedProduct dp = new DiscountedProduct();
            DiscountedProduct dp2 = new DiscountedProduct(2,"PC",6000,4,"Winter");
            Console.WriteLine(dp2.HasSeasonalOffer());


        }
    }
}
