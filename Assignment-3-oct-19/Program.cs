// See https://aka.ms/new-console-template for more information
using Assignment_3_oct_19;

Console.WriteLine("Hello, World!");
Student[] student=new Student[3];
for (int j = 0; j < 3; j++)
{


    Console.WriteLine("enter the student name");
    string? studentName = Console.ReadLine();
    Console.WriteLine("Enter marks");
    int[] marks = new int[3];
    for (int i = 0; i < marks.Length; i++)
    {
        Console.WriteLine("Enter the marks for subject " + i);
        marks[i] = Convert.ToInt32(Console.ReadLine());

    }
    Console.WriteLine("Enter the grade ");
    char grade = Convert.ToChar(Console.ReadLine());
    student[j] = new Student(studentName, marks, grade);
}
for(int j = 0; j < 3; j++)
{
    student[j].display();
    student[j].GetMarkSummary();    
}