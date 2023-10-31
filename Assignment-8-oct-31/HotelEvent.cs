using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_8_oct_31
{
    internal class HotelEvent
    {
        public HotelEvent(string eventName, int eventDate, string location, int capacity)
        {
            EventName = eventName;
            EventDate = eventDate;
            Location = location;
            Capacity = capacity;
        }

        public string EventName { get; set; }
        public int EventDate { get; set; }
        public string Location { get; set; }
        public int Capacity { get; set; }

       public static string EventRegistreation(string mes)
        {
            return mes;
        }

    }
}
