using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Programs.ExceptionMess
{
 
        internal class MyExceptions
        {
            public static Dictionary<int, string> exmess = new Dictionary<int, string>
        { {0, "Denom should not be 0"},
           { 1, "Index out of range"},
           { 2, "Unknown Exception"},
            {3,"Age is 100+" },
            {4,"Age is less" }
        };
        internal class Num1Exception : Exception
        {
            public Num1Exception(string message) : base(message)
            {
            }
        }
        internal class Num2Exception : Exception
        {
            public Num2Exception(string message) : base(message)
            {
            }
        }
        /*
        public static  List<string> exmesslist = new List<string>()
        {
            "Denom should not be 0",
            "Index out of range",
            "Unknown Exception"

        };*/
    }
    }

