using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Programs
{
    internal class GenEx<T>//
    {
        private T val1,val2;
        private string val3;
        public GenEx(T val1, T val2)
        {
            Val1 = val1;
            Val2 = val2;
        }

        public T Val1 { get => val1; set => val1 = value; }
        public T Val2 { get => val2; set => val2 = value; }
    }
}
