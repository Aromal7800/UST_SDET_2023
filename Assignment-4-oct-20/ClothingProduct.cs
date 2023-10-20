using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_4_oct_20
{
    internal class ClothingProduct : Product
    {
        string size;
        public ClothingProduct(string productName, double price, int quantity, string size) : base(productName, price, quantity)
        {
            this.size = size;
        }
        public void displaySize()
        {
            Console.WriteLine("Size "+size );
        }
    }
}
