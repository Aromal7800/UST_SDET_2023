using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_5_oct_25
{
    internal abstract class InsurencePolicyAbstract
    {
        public string? PolicyName {  get; set; } 
        public int PolicyId {  get; set; }  
        public double PremiumAmount { get; set; }
        public abstract double CalculatePremium();
        public void display()
        {
            Console.WriteLine("Policy id :{0} \t policy name : {1} \t premium amount : {2}", PolicyId, PolicyName, PremiumAmount);

        }


    }
}
