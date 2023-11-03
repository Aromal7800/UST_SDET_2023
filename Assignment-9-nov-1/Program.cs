// See https://aka.ms/new-console-template for more information
using Assignment_9_nov_1;

TourPackage package = new TourPackage(1, "kochi", "12-1-2025", 1200);
TourPackage package1 = new TourPackage(2, "alappuzha", "12-1-2024", 1400);
TourPackage package2 = new TourPackage(3, "kannur", "12-12-2023", 1500);

TourPackage.TourPackages.Add(package1);
TourPackage.TourPackages.Add(package2);
TourPackage.TourPackages.Add(package);


Thread thread = new Thread(TourPackage.HotelReservation);

Thread thread1 = new Thread(TourPackage.HotelReservation);

thread1.Start();
thread1.Join();
thread.Start();
/*
Hotel hotel1 = new Hotel("nrkgn", 56, "rng", "rnig", 90);
Hotel hotel2 = new Hotel("nrk", 5, "rngm", "rn", 9);
if (await hotel1.HotelBookingRequest(3))
{
    Console.WriteLine("booking sucessful !!!");
}
else
{
    Console.WriteLine("booking failed !!!");
}
if (await hotel2.HotelBookingRequest(3))
{
    Console.WriteLine("booking sucessful !!!");
}
else
{
    Console.WriteLine("booking failed !!!");
}
/*
bool flag = true;
while (flag)
{
    Console.WriteLine("1.Add Destination :");
    Console.WriteLine("2.Sort and Dispaly");
    Console.WriteLine("3.Exit");
    int ch = Convert.ToInt32(Console.ReadLine());
    switch (ch)
    {
        case 1:
            {
                Console.WriteLine("Enter Country Name :");
                string Cname = Console.ReadLine();
                Console.WriteLine("Enter Destination Name :");
                string desname = Console.ReadLine();
                Console.WriteLine("Enter Rating :");
                int rating = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Price :");
                int price=Convert.ToInt32(Console.ReadLine());
                TourismDestination2 tourismDestination = new TourismDestination2();
                tourismDestination.Name = desname;
                tourismDestination.Rating = rating;
                tourismDestination.Country = Cname;
                tourismDestination.PricePerNight = price;
                tourismDestination.addTDestination2(tourismDestination);
                break;
            }
        case 2:
            {
                TourismDestination2 tourismDestination = new TourismDestination2();
                tourismDestination.sortBasedOnRating(TourismDestination.tourismDestinations);
                tourismDestination.LinqOps();
                break;
            }
        case 3:
            {
                flag = false; break;
            }
    }


}
/*
bool flag = true;
while (flag)
{
    Console.WriteLine("1.Add Destination :");
    Console.WriteLine("2.Sort and Dispaly");
    Console.WriteLine("3.Exit");
    int ch=Convert.ToInt32(Console.ReadLine());
    switch (ch)
    {
        case 1:
            {
                Console.WriteLine("Enter Country Name :");
                string Cname = Console.ReadLine();
                Console.WriteLine("Enter Destination Name :");
                string desname = Console.ReadLine();
                Console.WriteLine("Enter Rating :");
                int rating = Convert.ToInt32(Console.ReadLine());
                TourismDestination tourismDestination = new TourismDestination();
                tourismDestination.Name = desname;
                tourismDestination.Rating=rating;
                tourismDestination.Country = Cname;
                tourismDestination.addTDestination(tourismDestination);
                break;
            }
            case 2:
            {
                TourismDestination tourismDestination = new TourismDestination();
                tourismDestination.sortBasedOnRating(TourismDestination.tourismDestinations);
                break;
            }
            case 3: {
                flag = false; break;
            }
    }
    

}
*/
