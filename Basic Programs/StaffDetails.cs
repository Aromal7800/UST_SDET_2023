using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Programs
{
    internal class StaffDetails
    {
        public int Staffid {  get; set; }   
        public string Staffname { get; set; }
        public string Staffdescription { get; set; }
        public string Dept { get; set;}
        
        public void DisplayStaffDetalis()
        {
            Console.WriteLine("id :"+Staffid+"Staff Name" + Staffname+"Staff Desciption");
        }
    }
}
