using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_5_oct_25
{
    internal class CarInsurance:InsurencePolicyAbstract
    {
        public double KMsDriven;

        public override double CalculatePremium()
        {
           if(KMsDriven > 2000) {  return PremiumAmount*1.4; }
           else if(KMsDriven > 4000) { return PremiumAmount * 1.2; }
           else if(KMsDriven > 8000) { return PremiumAmount*1.1; }
           else { return PremiumAmount; }
        }

    }
}
