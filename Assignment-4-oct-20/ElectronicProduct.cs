using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_4_oct_20
{
    internal class ElectronicProduct : Product
    {
        int warrantyPeriod;
        public ElectronicProduct(string productName, double price, int quantity, int warrantyPeriod) : base(productName, price, quantity)
        {
            this.warrantyPeriod = warrantyPeriod;
        }
        public void DisplayWarrentyPeriod()
        {
            Console.WriteLine("Warrenty Period is "+warrantyPeriod);
        }
    }
    
    }

