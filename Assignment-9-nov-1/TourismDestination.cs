using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_9_nov_1
{
    internal class TourismDestination
    {
        public string DesName {  get; set; }
        public string Country {  get; set; }
        public int Rating {  get; set; }
        public static List<TourismDestination> tourismDestinations = new List<TourismDestination>();

        public TourismDestination(string Desname, string country, int rating)
        {
            DesName = Desname;
            Country = country;
            Rating = rating;
        }

        public void addTDestination(TourismDestination destination)
        {
            tourismDestinations.Add(destination);
        }

        public void sortBasedOnRating(List<TourismDestination> tourismDestinations )
        {
           var sortedList=  tourismDestinations.OrderByDescending( x => x.Rating );
            foreach( TourismDestination dest in sortedList)
            {
                Console.WriteLine($"{dest.DesName} in {dest.Country}  Rating : {dest.Rating}");
            }
        }
    }
}
