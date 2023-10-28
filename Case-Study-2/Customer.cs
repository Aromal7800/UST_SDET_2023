
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Case_Study_2
{
    internal class Customer
    {
        public int CustomerID { get; set; }
        public string? CustomerName { get; set; }
        public string? CustomerEmail { get; set; }

        public List<DigitalProduct> orders = new List<DigitalProduct>();
        public List<PhysicalProduct> ordersphy = new List<PhysicalProduct>();
        public List<DigitalProduct> confirmedorders = new List<DigitalProduct>();
        public List<PhysicalProduct> confirmedordersphy = new List<PhysicalProduct>();
        public static List<Customer> customers = new List<Customer>();
    }
}
