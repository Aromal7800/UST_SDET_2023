// See https://aka.ms/new-console-template for more information
using Assignment_1_oct_18;
Console.WriteLine("Enter the student Name");
string name=Console.ReadLine();
Console.WriteLine("Enter the student marks");
int markOne=Convert.ToInt32(Console.ReadLine());
int markTwo = Convert.ToInt32(Console.ReadLine());
int markThree = Convert.ToInt32(Console.ReadLine());

Student student = new Student(name,markOne,markTwo,markThree);
Console.WriteLine("Student Name :"+name);
Console.WriteLine("Total Marks :" + student.TotalMarks());
Console.WriteLine("Average Marks :"+student.Average());

Console.WriteLine("Grade :"+student.Grade());
