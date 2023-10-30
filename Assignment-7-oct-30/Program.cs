// See https://aka.ms/new-console-template for more information
using Assignment_7_oct_30;

List<HotelRoom> rooms = new List<HotelRoom>
        {
            new HotelRoom(101, "Single"),
            new HotelRoom(102, "Double"),
            new HotelRoom(103, "Suite"),
        };

RoomReservation<HotelRoom> reservationSystem = new RoomReservation<HotelRoom>(rooms);

while (true)
{
    Console.WriteLine("\n1. Display Available Rooms");
    Console.WriteLine("2. Book a Room");
    Console.WriteLine("3. Cancel a Booking");
    Console.WriteLine("4. Exit");
    Console.Write("Enter your choice: ");

    int choice = int.Parse(Console.ReadLine());

    switch (choice)
    {
        case 1:
            reservationSystem.DisplayAvailableRooms();
            break;
        case 2:
            Console.Write("Enter the room number to book: ");
            int roomNumberToBook = int.Parse(Console.ReadLine());
            reservationSystem.BookRoom(roomNumberToBook);
            break;
        case 3:
            Console.Write("Enter the room number to cancel the booking: ");
            int roomNumberToCancel = int.Parse(Console.ReadLine());
            reservationSystem.CancelRoom(roomNumberToCancel);
            break;
        case 4:
            return;
    }
}
    
