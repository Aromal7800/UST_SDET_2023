using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_5_oct_25
{
    internal class InsurancePolicy
    {
        public string? policyName;
        public int policyId;
        public double premiumAmount;

        public InsurancePolicy(string? policyName, int policyId, double premiumAmount)
        {
            this.policyName = policyName;
            this.policyId = policyId;
            this.premiumAmount = premiumAmount;
        }
   
        public double RenewPolicy(double newPremium)
        {

            premiumAmount = newPremium;
            return premiumAmount;
        }
        public double RenewPolicy()
        {
            premiumAmount = premiumAmount * 1.1;
            return premiumAmount;
        }
        public void display()
        {
            Console.WriteLine("Policy id :{0} \t policy name : {1} \t premium amount : {2}",policyId,policyName,premiumAmount);
           
        }
    }
}
