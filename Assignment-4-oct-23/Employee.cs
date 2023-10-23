using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_4_oct_23
{
    internal class Employee : Person,IDisplayable
    {
        public Employee(string fristName, string lastName, int age) : base(fristName, lastName, age)
        {
        }

        public int EmployeeID {  get; set; }    

        public void DisplayInfo()
        {
            Console.WriteLine("Full Name : {0} {1} \t age : {2} \t",FristName,LastName,Age);
        }
    }
}
