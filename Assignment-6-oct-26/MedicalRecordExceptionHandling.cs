using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_6_oct_26
{
    internal class MedicalRecordExceptionHandling
    {
        public static Dictionary<string, string> exmess = new Dictionary<string, string>
        { {"Age", "Age should be between 1 and 120"},
           { "Name", "Name should not be null or empty"},
           { "Diagnosis", "Diagnosis should not be null or empty "},
            {"TCost","Treatment cost must be greater than 0" }
        };


    }
    internal class CoustomException : Exception
    {
        public CoustomException(string message) : base(message)
        {

        }
    }
 
}

