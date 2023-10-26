using Basic_Programs.ExceptionMess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Programs
{
    internal class ExceptionHandling
    {
        public ExceptionHandling(int num1, int num2)
        {
            Num1 = num1;
            Num2 = num2;
        }

        public int Num1 {  get; set; }
        public int Num2 { get; set; }

        public void Divide()
        {
           
               int[] num = { 10, 20,30 };
                int res = Num1 / Num2;
                Console.WriteLine(res);
            
                for(int i = 0; i <= 4; i++) 
                {
                    res = num[i] / Num2;
                    Console.WriteLine(res);
                }
            

            }
        public void NumCheck()
        {
            if (Num1 > 100)
            {
                Console.WriteLine("Congrats");
            }
            else
            {
                throw new Num1Exception(MyExceptions.exmess[2]);
                // Console.WriteLine("Not 100 yet !!!! ");

            }
        }
        public void NumCheck2() { 
            if (Num2 < 100)
            {
                Console.WriteLine("Congrats");
            }
            else
            {
                throw new Num1Exception(MyExceptions.exmess[3]);
            }
        }


    }
}
