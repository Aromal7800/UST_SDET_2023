using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_6_oct_26
{
    internal class Customer
    {
        public int CustomerId;
        public string CustomerName;
        public double Phonenumber;
        public int Balance;
        public static List<Customer> CustomersList = new List<Customer>();

        public Customer(int customerId, string customerName, double phonenumber, int balance)
        {
            CustomerId = customerId;
            CustomerName = customerName;
            Phonenumber = phonenumber;
            Balance = balance;
        }

        public void SearchByPhone(double  phone)
        {
            var cust1=CustomersList.Find(x=>x.Phonenumber == phone);
            if(cust1 != null)
            {
                Console.WriteLine("{0} has a balance of {1}", CustomerName, Balance);
            }
            else
            {
                Console.WriteLine("customer not found !!!");
            }
            
            
           
        }
    }
}
