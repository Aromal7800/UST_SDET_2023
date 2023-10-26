using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_6_oct_26
{
    internal class CallRecords
    {
        public int CallId;
        public int PhoneNumber;
        public double CallTime;
        public static List<CallRecords> callRecordsList=new List<CallRecords>();

        public CallRecords(int callId, int phoneNumber, double callTime)
        {
            CallId = callId;
            PhoneNumber = phoneNumber;
            CallTime = callTime;
        }

        public  void CallHistory(double phone)
        {
            var sameNumList=callRecordsList.FindAll(x=> x.PhoneNumber == phone);    
            foreach(var record in sameNumList)
            {
                Console.WriteLine("Phone number {0}\t CallID {1} \t CallTime{2} \t",record.PhoneNumber,record.CallId,record.CallTime);
            }
        }
        public void TotalCalls()
        {
            var distinctNumbers = callRecordsList.DistinctBy(x => x.PhoneNumber).ToList();
            foreach(var record in distinctNumbers)
            {
                int count=callRecordsList.Count(x=>x.PhoneNumber == record.PhoneNumber);
                Console.WriteLine("{0} was contacted {1} times",record.PhoneNumber,count);
            }

        }

    }
}
