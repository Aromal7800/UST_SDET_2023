// See https://aka.ms/new-console-template for more information


using Basic_Programs;
public delegate void Deli();
public delegate void Deli1(int num,int num1);
public delegate int Deli2(int num, int num1);
class Program
{
    private static readonly Deli methodA;

    //private static Deli methodA;

    public static void Main(string[] args)
    {
        DeleEx deleEx = new DeleEx();
        Deli deli=methodA;
    //    deli();
        Deli1 deli1=deleEx.Add;
        deleEx.Add(Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()));    
       // deli1(1, 2);
        Deli1 deli2=deleEx.Sub;
       // deli2(1,2);
        Deli1 dobjall = deli2+deli1;
        dobjall(10, 20);
       // Deli2 deli3 = deleEx.AddR;
       // Console.WriteLine(deli3(1, 2));
       // Deli deli1=methodA;
        //deli1();

    }
}


    
/*
using Basic_Programs.ExceptionMess;
GenEx<int> g1=new GenEx<int>(10, 20);
Console.WriteLine(g1.Val1+"  "+ g1.Val2);
GenEx<double> g2 = new GenEx<double>(10.9000, 20.8990);
Console.WriteLine(g2.Val1 + "  " + g2.Val2);
GenEx<string> g3 = new GenEx<string>("hello","hello1");
Console.WriteLine(g3.Val1 + "  " + g3.Val2);
/*
FileOperations fileOperations = new FileOperations();
fileOperations.FileProperties();
//fileOperations.CopyMoveFile();
//fileOperations.ReadData();
//fileOperations.CreateFile();
//fileOperations.WriteData();
/*
ExceptionHandling exp = new ExceptionHandling(10,120);
try
{
    exp.NumCheck();
}
catch(ArgumentException)
{
    Console.WriteLine(MyExceptions.exmess[3]);
}
try
{
    exp.NumCheck2();
}
catch (ArgumentException)
{
    Console.WriteLine(MyExceptions.exmess[4]);
}
/*
try
{
exp.Divide();
}
catch (ArithmeticException ex)
{
    /*
    Console.WriteLine(ex.HelpLink);
    Console.WriteLine(ex.InnerException);
    Console.WriteLine(ex.StackTrace);

    Console.WriteLine(ex.Source);
    
    Console.WriteLine(ex.Message);
    Console.WriteLine(MyExceptions.exmess[0]);
}
catch (IndexOutOfRangeException ex)
{
    Console.WriteLine(MyExceptions.exmess[1]);
}
catch (Exception ex)
{
    Console.WriteLine(MyExceptions.exmess[2]);
}
finally { Console.WriteLine("Done"); }

        
/*
NGC nGC = new NGC();
//nGC.SortedListHandling();
Basic_Programs.GC gC = new();
gC.DictionaryHandling();
/*
nGC.StackHandling();
Console.WriteLine("Queue");
nGC.QueueHandling();
//BankDetails bank = new(1234, 1234567890L, "AA", "Inactive");
//bank.WelcomeMessage();
/*
BankDetailsNew bank = new(1234, 1234567890L, "AA", "Inactive");
bank.WelcomeMessage();
Console.WriteLine("1. Customer id 2. Accno 3. Name ");
int ch=Convert.ToInt32(Console.ReadLine());
switch (ch)
{
    case 1:
        {
            Console.WriteLine("Custid : ");
            bank.GetAccDetails(Convert.ToInt32(Console.ReadLine()));
            break;
        }
        case 2:
        {
            Console.WriteLine("Custid : ");
            bank.GetAccDetails(Convert.ToInt64(Console.ReadLine()));
            break;
        }
        case 3:
        {
            Console.WriteLine("Custid : ");
            bank.GetAccDetails(Console.ReadLine());
            break;
        }
        default:
        {
            Console.WriteLine("Please Enter a number between 1-3");
            break;
        }
}
/*
 * 
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