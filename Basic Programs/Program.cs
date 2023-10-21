// See https://aka.ms/new-console-template for more information
using Basic_Programs;
Doctor doc= new Doctor();
doc.AddNewDoctor(123,"AA");
doc.DisplayDoctorDetails();
doc.ModifyDoctor(123,"BB");
doc.DisplayDoctorDetails();
IDoctor Idoc = new Doctor();
doc.BookApp(980,"XX");
doc.DelApp("XX");
calulation docc=new Doctor();
IApponiment appo = new Doctor();

//Idoc.AddNewDoctor();
//Idoc.ModifyDoctor();
/*
EV eV=new EV();
eV.vehicleNumber = 44;
eV.Brand = "XX";
eV.Model = "AA";
Console.WriteLine(eV.SetTypeForVeh());
eV.Disp();

PV pV=new PV();
pV.vehicleNumber = 33;
pV.Brand = "YY";
pV.Model = "AA";
Console.WriteLine(pV.SetTypeForVeh());
pV.Disp();


Console.WriteLine("1.TS 2.NTS");
switch (Convert.ToInt32(Console.ReadLine()))
{
    case 1:
        {
            TeachingStaff teachingStaff = new TeachingStaff();
            teachingStaff.Staffid = 111;
            teachingStaff.Staffname = "AAA";
            teachingStaff.Dept = "CS";
            teachingStaff.Specialization = "DBMS";
           
            teachingStaff.Year = 1999;
            teachingStaff.DisplayStaffDetalis();
            teachingStaff.teachingStaffDetails();
            break;
        }
        case 2:
        {
            NonTeachingStaff nonTeachingStaff = new NonTeachingStaff();
            nonTeachingStaff.Staffname = "Arun";
            nonTeachingStaff.Staffid = 101;
            nonTeachingStaff.Staffdescription = "aRUN DPT";
            nonTeachingStaff.Dept = "Admin";
            nonTeachingStaff.DisplayStaffDetalis();
            nonTeachingStaff.NonTeachingStaffDetails();
            break;

        }
}







/*
StudentMarks marks = new StudentMarks();
StudentGrade studentGrade = new StudentGrade();
studentGrade.RollNo = 0;

studentGrade.Mark1 = 90;
studentGrade.Mark2 = 98;
studentGrade.Mark3 = 87;
studentGrade.StudentName = "AAA";
studentGrade.DisplayStudentDetails();
studentGrade.DisplayStudentDetails();

Console.WriteLine("Total Marks :"+studentGrade.CalculateTotal());
Console.WriteLine("Aerage Marks :"+studentGrade.CalculateAverage());
;
Console.WriteLine("Student Grade= "+ studentGrade.CalculateGrade());


Electricity electricity1=new(12345,9000,9300,"XX");
double billamount = electricity1.CalculateBill();
Console.WriteLine(electricity1.CalculateBill());
Console.WriteLine(electricity1.consumernumber);
Console.WriteLine(electricity1.consumername);
Electricity electricity2 = new(12345, 7000, 9300, "XX");

Console.WriteLine(electricity2.CalculateBill());

 * 
Console.WriteLine("Enter two numbers");
int num1, num2, ans;
num1=Convert.ToInt32(Console.ReadLine());
num2=Convert.ToInt32(Console.ReadLine());
ans = num1 + num2;
Console.WriteLine(ans);
string? s1="";
String? s2="";
string? s3="";
s3 = s1 +"  "+s2;
Console.WriteLine(s3);  
int x;
s1=Console.ReadLine();
s2=Console.ReadLine();
Console.WriteLine(s1.Equals(s2));
Console.WriteLine(s1.ToLower());
Console.WriteLine(s2.ToUpper());
s2.Trim();
Console.WriteLine(s3.Trim());

string[] s=s3.Split(' ');

for(int i = 0; i < s.Length; i++)
{
    Console.WriteLine(s[i]);
}

calulation calculation=new calulation();
int num1=Convert.ToInt32(Console.ReadLine());
int num2=Convert.ToInt32(Console.ReadLine());
double ans=calculation.add(num1, num2);
Console.WriteLine(ans);
*/