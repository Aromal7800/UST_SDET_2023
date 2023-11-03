using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_9_nov_1
{
    internal class Hotel:TourismDestination
    {
        public Hotel(string name, int availableRooms, string Desname, string country, int rating) : base( Desname, country, rating)
        {
            Name = name;
            AvailableRooms = availableRooms;
        }

        public string Name {  get; set; }
        public int AvailableRooms {  get; set; }    

        public async Task<bool> HotelBookingRequest(int availableRooms)
        {
          if(AvailableRooms >=availableRooms) 
            {
                await Task.Delay(1000);
                AvailableRooms =AvailableRooms-availableRooms;
                return true;    
            }
            else
            {
                Console.WriteLine("only "+ AvailableRooms+" rooms are available for booking");
                return false;
            }
        }
    }
}
