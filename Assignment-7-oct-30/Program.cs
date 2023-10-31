// See https://aka.ms/new-console-template for more information
using Assignment_7_oct_30;
ProductManagement<object> productManagement= new ProductManagement<object>();


productManagement.AddProduct(new Product<object>(1, "Apple", 4, 10));
productManagement.AddProduct(new Product<object>(2, "Shirt", 19, 50));
productManagement.AddProduct(new Product<object>(3, "Banana", 10.00, 100));
Console.WriteLine("before update");
productManagement.DisplayProducts();
var updatedProduct = new Product<object>(1, "Smartphone", 500, 15);
productManagement.UpdateProduct(1, updatedProduct);
Console.WriteLine("After update");
productManagement.DisplayProducts();


productManagement.DeleteProduct(3);
Console.WriteLine("After delete");
productManagement.DisplayProducts();
/*
List<HotelRoom> rooms = new List<HotelRoom>
        {
            new HotelRoom(1, "Single"),
            new HotelRoom(2, "Double"),
            new HotelRoom(3, "Suite"),
        };

RoomReservation<HotelRoom> reservationSystem = new RoomReservation<HotelRoom>(rooms);
int flag = 0;
do
{
  
    Console.WriteLine("1. Book a Room");
    Console.WriteLine("2. Cancel a Booking");
    Console.WriteLine("3. Exit");
    Console.Write("Enter your choice: ");

    int choice = int.Parse(Console.ReadLine());

    switch (choice)
    {
       
        case 1:
            Console.Write("Enter the room number to book: ");
            int roomNumberToBook = int.Parse(Console.ReadLine());
            reservationSystem.BookRoom(roomNumberToBook);
            break;
        case 2:
            Console.Write("Enter the room number to cancel the booking: ");
            int roomNumberToCancel = int.Parse(Console.ReadLine());
            reservationSystem.CancelRoom(roomNumberToCancel);
            break;
        case 3:
            flag = 1;
            break;
    }
   
}
while (flag == 0);
*/