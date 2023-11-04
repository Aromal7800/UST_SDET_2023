using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseStudy_3.MyExceptions
{
    internal class StudentException : Exception
    {
        public StudentException(string message) : base(message)
        {

        }
    }
}
