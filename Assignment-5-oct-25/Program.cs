// See https://aka.ms/new-console-template for more information
using Assignment_5_oct_25;

InsurancePolicy insurancePolicy=new("p1",1,5000);
insurancePolicy.display();
insurancePolicy.RenewPolicy(800);
insurancePolicy.display();
insurancePolicy.RenewPolicy();
insurancePolicy.display();
LifeInsurance lifeInsurance=new LifeInsurance();
CarInsurance carInsurance=new CarInsurance();
Console.WriteLine("Enter Policy name :");
lifeInsurance.PolicyName= Console.ReadLine();
carInsurance.PolicyName=lifeInsurance.PolicyName;
Console.WriteLine("Enter Policy id :");
lifeInsurance.PolicyId=Convert.ToInt32(Console.ReadLine());
carInsurance.PolicyId = lifeInsurance.PolicyId;
Console.WriteLine("Enter premium amount :");
carInsurance.PremiumAmount= Convert.ToInt32(Console.ReadLine());    
lifeInsurance.PremiumAmount= carInsurance.PremiumAmount;
Console.WriteLine("Enter age :");
lifeInsurance.age= Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the KMs Driven for a car");
carInsurance.KMsDriven= Convert.ToInt32(Console.ReadLine());
carInsurance.CalculatePremium();
carInsurance.display();
lifeInsurance.CalculatePremium();
lifeInsurance.display();


