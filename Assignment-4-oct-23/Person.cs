using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_4_oct_23
{
    internal class Person
    {
        string fristName;
        string lastName;
        int age;

        public Person(string fristName, string lastName, int age)
        {
            FristName = fristName;
            LastName = lastName;
             Age = age;
        }

        public string? FristName
        {
            get { return fristName; }
            set { fristName = value; }
        }
        public string? LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }
        public int Age
        {
            get { return age; }
            set {
                if(value>=18 && value<=100)
                age = value;
                else
                {
                    Console.WriteLine("age should be between 18 and 100");
                }
            }
        }
       
    }
}
