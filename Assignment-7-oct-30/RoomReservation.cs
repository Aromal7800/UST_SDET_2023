using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_7_oct_30
{
    internal class RoomReservation<T> where T : HotelRoom

    {
        private List<T> availableRooms;

        public RoomReservation(List<T> rooms)
        {
            availableRooms = rooms;
        }

       

        public void BookRoom(int roomNumber)
        {
            T room = availableRooms.Find(x => x.RoomNumber == roomNumber);
            if (room != null && room.IsBooked==false)
            {
                room.IsBooked = true;
                Console.WriteLine($"Room {roomNumber} is booked.");
            }
            else
            {
                Console.WriteLine($"Room {roomNumber} is not available for booking.");
            }
        }

        public void CancelRoom(int roomNumber)
        {
            T room = availableRooms.Find(r => r.RoomNumber == roomNumber);
            if (room != null && room.IsBooked)
            {
                room.IsBooked = false;
                Console.WriteLine($"Booking for room {roomNumber} is canceled.");
            }
            else
            {
                Console.WriteLine($"Room {roomNumber} is not booked or does not exist.");
            }
        }
    }
}
