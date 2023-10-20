using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_4_oct_20
{
    internal class DigitalProduct : ElectronicProduct
    {
        string fileFormat;
        public DigitalProduct(string productName, double price, int quantity, int warrantyPeriod, string fileFormat) : base(productName, price, quantity, warrantyPeriod)
        {
            this.fileFormat = fileFormat;
        }
        public void DisplayFileFormat()
        {
            Console.WriteLine("file format ="+fileFormat);
        }
    }
}
