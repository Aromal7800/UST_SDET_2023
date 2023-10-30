using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_7_oct_30
{
    internal class HotelRoom
    {
        public int RoomNumber {  get; set; }    
        public string RoomType {  get; set; }   

        public bool IsBooked {  get; set; }

        public HotelRoom(int roomNumber, string roomType)
        {
            RoomNumber = roomNumber;
            RoomType = roomType;
            IsBooked = false;
        }
    }
}
