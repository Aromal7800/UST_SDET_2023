using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_5_oct_25
{
    internal class LifeInsurance : InsurencePolicyAbstract
    {
        public int age;
        public override double CalculatePremium()
        {
            if(age > 80)
            {
                PremiumAmount = PremiumAmount * 1.8;
                return PremiumAmount;
            }
            else if (age > 60)
            {
                PremiumAmount = PremiumAmount * 1.6;
                return PremiumAmount;
            }
            else
            {
                PremiumAmount = PremiumAmount * 1.2;
                return PremiumAmount;
            }

        }
    }
}
