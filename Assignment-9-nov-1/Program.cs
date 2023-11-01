// See https://aka.ms/new-console-template for more information
using Assignment_9_nov_1;
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
