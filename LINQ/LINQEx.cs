using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    internal class LINQEx
    {
        public void Example1()
        {
            List<string> courses = new List<string>(); 
            courses.Add("C Tutorial");
            courses.Add("C++ Tutorial");
            courses.Add("C# Tutorial");
            courses.Add("Java Tutorial");
            courses.Add("Web Dev Tutorial");
            courses.Add("SQL");
            courses.Add("UI Exp");
            /*
            var result = courses.Where(x => x.EndsWith("Tutorial"));
            foreach(var resultItem in result)
            {
                Console.WriteLine(resultItem);
            }
            var result1=courses.Select(x => x.ToString()).ToList();
            foreach(var resultItem in result1)
            {
                Console.WriteLine(resultItem);
            }
            
            var GroupBYEx = courses.GroupBy(x => x.EndsWith("Tutorial") ? "Tutorial" : "Not Tutorial");
            foreach (var group in GroupBYEx)
            {
                Console.WriteLine($"{group.Key} :\n");
                foreach (var item in group)
                {
                    
                    Console.WriteLine(item);
                }
            }
            */
            var result = courses.Select(x => x);
           
            foreach (string s in result) { Console.WriteLine(s); }
            var result2 = courses.Where(x=>x.Contains("SQL"));
            foreach(string s in result2) { Console.WriteLine(s + " "); }
        }
        public void Example2()
        {
           List<Student>  students = new List<Student>();
            students.Add(new Student(1, "ZZ", "CSE"));
            students.Add(new Student(2, "BB", "CSE"));
            students.Add(new Student(7, "CC", "EEE"));
            students.Add(new Student(9, "DD", "EC"));
            students.Add(new Student(5, "EE", "MECH"));
            students.Add(new Student(6, "AA", "EEE"));
            var stud=students.Where(x=>x.Id==1);
            foreach (var student in stud)
            {
              //  Console.WriteLine(student.Name);
            }
            var result=students.Select(x=>x.Id=x.Id*2);
            
            var result1=students.Select(x=>x);
           
            var result2=students.Where(x=>x.Id%2==0);
           // foreach (var student in result2) { Console.WriteLine(student.Name); }
            Student stud2=(Student)students.FirstOrDefault(x=>x.Id==2);
            var result3 = students.GroupBy(x => x.Dept);
            foreach(var student in result3) { 
          //      Console.WriteLine(student.Key+ " :");
                foreach(var stud12 in student)
                {
            //        Console.WriteLine($"{stud12.Name}  {stud12.Id}");
                }
              //  Console.WriteLine("\n");
            }
           // foreach (var student in stud2) { Console.WriteLine(student.Name); }
           var result4=students.OrderBy(x=>x.Dept).ThenBy(x=>x.Name);
            
            foreach(var student in result4) {
                Console.WriteLine(student.Name);
            }
        }
    }
}
