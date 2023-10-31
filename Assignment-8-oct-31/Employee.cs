using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_8_oct_31
{
    internal class Employee
    {
        public Employee(int employeeID, string name, double performanceRating)
        {
            EmployeeID = employeeID;
            Name = name;
            PerformanceRating = performanceRating;
        }

        public int EmployeeID { get; set; }
        public string Name { get; set; }
        public double PerformanceRating { get; set; }


        public  double BonusCal(Employee employee)
        {
            double total = 1000 * employee.PerformanceRating;
            return total;
        }
        public double OnamBonusCal(Employee employee)
        {
            return 1000 * 5;
        }
    }
}