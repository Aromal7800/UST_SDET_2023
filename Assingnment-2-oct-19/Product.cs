using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assingnment_2_oct_19
{
    internal class Product
    {
        string? productName;
        int quantity;
        double price;
       
        
        public Product(string productName, double price, int quantity)
        {
            this.productName = productName;
            this.price = price;
            this.quantity = quantity;
        }

       
        public void SetPrice(double newPrice)
        {
            price = newPrice;
        }
        //public Product(string productName, double price, int quantity)
        //{
        //    ProductName = productName;
        //    this.price = price;
        //    this.quantity = quantity;
        //}
        public void DisplayDetails()
        {
            Console.WriteLine("Product Name :"+productName+"Product Price"+price+"Product Quantity :"+quantity);

        }
        public void DisplayTotalPrice() { Console.WriteLine("Total Price =" + (quantity * price)); }

        


    }
}
