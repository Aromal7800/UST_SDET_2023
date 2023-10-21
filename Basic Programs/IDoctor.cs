using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Programs
{
    internal interface IDoctor
    {
        public int Did { get; set; }
        public string? DName { get; set; }
        void AddNewDoctor(int id,string?name);
         void ModifyDoctor(int id,string?name);
        void DisplayDoctorDetails();


    }
}
