// See https://aka.ms/new-console-template for more information
using Assignment_8_oct_31;

class program
{
    //delegate double bonusCalculation(Employee employee);
    delegate string EventNotification(string mes);

    public static void Main(string[] args)
    {
        HotelEvent hotelEvent = new HotelEvent("onam",12,"Tvm",345);
        EventNotification eventNotification = HotelEvent.EventRegistreation;
        if(hotelEvent!=null)
        {
            Console.WriteLine(eventNotification($"Registeration Sucessuful!!! {hotelEvent.EventName} will be held at {hotelEvent.Location} on {hotelEvent.Location} with a maximum attentee limit of {hotelEvent.Capacity}"));
        }
        else
        {
            Console.WriteLine(eventNotification("Registration Failed "));
        }
        HotelEvent hotelEvent1 = new HotelEvent("Diwali", 10, "Kochi", 123);
        EventNotification eventNotification1 = HotelEvent.EventRegistreation;
        if (hotelEvent1 != null)
        {
            Console.WriteLine(eventNotification1($"Registeration Sucessuful!!! {hotelEvent1.EventName} will be held at {hotelEvent1.Location} on {hotelEvent1.Location} with a maximum attentee limit of {hotelEvent1.Capacity}"));
        }
        else
        {
            Console.WriteLine(eventNotification1("Registration Failed "));
        }
        /*
     Employee employee=new Employee(1,"Aromal",1);
     Employee employee1 = new Employee(2, "Arun", 2);
        Employee employee2 = new Employee(3, "A10", 3);
        Employee employee3 = new Employee(2, "Goku", 5);
        bonusCalculation bonus = employee.OnamBonusCal;
        bonusCalculation bonus1 = employee.BonusCal;
        bonus(employee1);
        bonus1(employee2);
        Console.WriteLine("Onam Bonus");
        Console.WriteLine("name"+employee.Name+"  "+"Bonus"+ "  "+ bonus(employee));
        Console.WriteLine("name" + employee1.Name + "  " + "Bonus" + "  " + bonus(employee1));
        Console.WriteLine("Employee Bonus");
        Console.WriteLine("name" + employee.Name + "  " + "Bonus" + "  " + bonus1(employee));
        Console.WriteLine("name" + employee1.Name + "  " + "Bonus" + "  " + bonus1(employee1));
        */
    }

}