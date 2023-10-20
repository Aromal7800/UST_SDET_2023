using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3_oct_19
{
    internal class Student
    {
        string name;
        int[] marks=new int[3];
        char grade;
        int sum;

        public Student(string? name, int[] marks, char grade)
        {
            this.name = name;
            this.marks = marks;
            this.grade = grade; 
        }
        public void TotalMarks()
        {
            foreach (var mark in marks)
            {
                sum = mark + sum;
            }
        }
        public double CalculateAverage()
        {
            double average;
            int sum=0;
            for(int i=0;i<3;i++)
            {
                sum+= marks[i];


            }
            average = sum/3;
            return average;
        }
        public void display()
        {
            Console.WriteLine("Student Name ={0}", name);

            Console.Write("marks:");
            int total = 0;
            foreach (int i in marks)
            {
                total = total + i;
                Console.WriteLine(i + "\t");
            }
            Console.WriteLine();
            Console.WriteLine("Total " + total + " Average " + CalculateAverage() + "grade " + grade
); ;
            Console.WriteLine();
        }
            public void GetMarkSummary()
            {
                int max=marks.Max();
              
            Console.WriteLine(name + " has " + marks.Length + " highest mark is" + marks.Max() + " lowest marks is" + marks.Min());
            Console.WriteLine();

        }
        }
        
    }

