using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Programs
{
    internal class TeachingStaff : StaffDetails
    {
        public string? Specialization {  get; set; }    
        public int Year { get; set; }   

        public void teachingStaffDetails()
        {
            Console.WriteLine("Specialization: "+ Specialization +" Year :"+Year);
        }
    }
}
