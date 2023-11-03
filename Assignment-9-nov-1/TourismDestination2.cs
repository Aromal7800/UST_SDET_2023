using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Assignment_9_nov_1
{
    internal class TourismDestination2:TourismDestination
    {
        public int PricePerNight {  get; set; }
        public static List<TourismDestination2> tourismDestinations2 = new List<TourismDestination2>();

        public TourismDestination2(string Desname, string country, int rating,int pricePerNight):base( Desname, country,  rating)
        {
            PricePerNight = pricePerNight;
        }

        public void addTDestination2(TourismDestination2 destination)
        {
            tourismDestinations2.Add(destination);
        }
        public void LinqOps()
        {
            Console.WriteLine("tourismDestinations with rating above 5");
            var tDes = tourismDestinations2.Where(x => x.Rating > 5);
            foreach (var tDes2 in tDes)
            {
                Console.WriteLine(tDes2.DesName +"  "+ tDes2.Rating);
            }
            Console.WriteLine("sort by Price Per Night :");
            var result = tourismDestinations2.OrderBy(x => x.PricePerNight);
            foreach (var result2 in result)
            {
                Console.WriteLine(result2.DesName+"  "+ result2.Rating+"  "+ result2.PricePerNight);
                }
            }
        }
    }

