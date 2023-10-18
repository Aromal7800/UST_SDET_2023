// See https://aka.ms/new-console-template for more information
using Basic_Programs;
Electricity electricity1=new(12345,9000,9300,"XX");
double billamount = electricity1.CalculateBill();
Console.WriteLine(electricity1.CalculateBill());
Console.WriteLine(electricity1.consumernumber);
Console.WriteLine(electricity1.consumername);
Electricity electricity2 = new(12345, 7000, 9300, "XX");

Console.WriteLine(electricity2.CalculateBill());
/*
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
*/
calulation calculation=new calulation();
int num1=Convert.ToInt32(Console.ReadLine());
int num2=Convert.ToInt32(Console.ReadLine());
double ans=calculation.add(num1, num2);
Console.WriteLine(ans);