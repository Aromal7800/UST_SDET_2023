using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_7_oct_30
{
    internal class Product<T>
    {
        public int ProductID { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public int QuantityInStock { get; set; }

        public Product(int productId, string name, double price, int quantityInStock)
        {
            ProductID = productId;
            Name = name;
            Price = price;
            QuantityInStock = quantityInStock;
        }
    }
}
