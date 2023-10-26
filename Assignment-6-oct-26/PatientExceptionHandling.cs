using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_6_oct_26
{
    internal class PatientExceptionHandling
    {
        public static Dictionary<string, string> exmess = new Dictionary<string, string>
        { {"Age", "Age should be between 1 and 120"},
           { "Name", "Name should not be null or empty"},
           { "Diagnosis", "Diagnosis should not be null or empty "},
        };
            
       
    }
    internal class AgeCheck : Exception
    {
        public AgeCheck(string message) : base(message)
        {

        }
    }
    internal class NameCheck : Exception
    {
        public NameCheck(string message) : base(message)
        {

        }
    }
    internal class daiagnosisCheck : Exception
    {
        public daiagnosisCheck(string message) : base(message)
        {

        }
    }
}
