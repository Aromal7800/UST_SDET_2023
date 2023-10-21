using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Case_Study_1
{
    internal class Order
    {
        public string order_date;
        public int Total_Cost;
        public Order(string order_date, int total_Cost)
        {
            this.order_date = order_date;
            Total_Cost = total_Cost;
        }

        
       
        
        

        public void ViewOrderDetails()
        {

            Console.WriteLine("order date = {0}\t Total Cost={1}", order_date, CalculateTotalCost());


        }
        public int CalculateTotalCost()
        {
            int GST = 3;
            return Total_Cost * GST;
        }
      
    }
}
