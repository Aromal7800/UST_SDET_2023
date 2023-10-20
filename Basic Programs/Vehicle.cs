using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Programs
{
    internal abstract class Vehicle
    {
        public int vehicleNumber { get; set; }
        public string? Brand { get; set; }

        public string? Model { get; set; }
        public string? Type { get; set; }

        public abstract string? SetTypeForVeh();

        public void Disp()
        {
            Console.WriteLine(vehicleNumber + "  " + Brand);
        }

    }
}

