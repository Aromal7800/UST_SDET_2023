using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Case_Study_1
{
    internal class Customer
    {
        public string name {  get; set; }
        public string contact_details {  get; set; }    
        public int CustomerID { get; set; }

        Customer[] customers = new Customer[5]; 

        public void View_All_customer()
        {
            Console.WriteLine("Customer ID ={0}\t Contact Details={1}\t Customer Name={2}", CustomerID, contact_details, name);
            
           
        }
        public void Add_Customer(Customer customer)
        {
            customers[customers.Length- 1]= customer;
        }
        

    }
}
