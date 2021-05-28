using Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Vehicles
{
    public class Truck : Vehicle
    {
        public string NumberOfTrailers { get; set; }
        public int TrailerPrice { get; set; } 

        public Truck(string manufacturer, string model, decimal price, string type, string numberOfTrailers) : base(manufacturer, model, price, type)
        {
            NumberOfTrailers = numberOfTrailers;
        }
        public Truck(string manufacturer, string model, int price, string type, string numberOfTrailers, int trailerPrice) : base(manufacturer, model, price, type)
        {
            NumberOfTrailers = numberOfTrailers;
            TrailerPrice = trailerPrice;
        }

        //public string TruckPriceRange(string numberOfTrailers, List<Truck> trucks)
        //{
        //    int oneTrailer = 3000;

        //    if (numberOfTrailers == "No Trailer")
        //    {
        //        Console.ForegroundColor = ConsoleColor.Yellow;
        //        Console.WriteLine(new string('-', 60));
        //        return "There is no discount for the truck";
        //    }
        //    if (numberOfTrailers == "One Trailer")
        //    {
        //        foreach (var truck in trucks)
        //        {
        //            int priceWithOneTrailer = truck.Price + oneTrailer;
        //            Console.ForegroundColor = ConsoleColor.Yellow;
        //            Console.WriteLine(new string('-', 60));
        //            return $"The full price for the truck with one trailer is ${priceWithOneTrailer}.";
        //        }
        //    }
        //    if (numberOfTrailers == "Two Trailers")
        //    {
        //        foreach (var truck in trucks)
        //        {
        //            int priceWithOneTrailer = truck.Price + oneTrailer;
        //            int temp = (oneTrailer % 100) * 10;
        //            int discount = oneTrailer - temp;
        //            int priceWithTwoTrailers = priceWithOneTrailer + discount;
        //            Console.ForegroundColor = ConsoleColor.Yellow;
        //            Console.WriteLine(new string('-', 60));
        //            return $"The price for the truck with two trailers is {priceWithTwoTrailers}. You get a 10% discount on the second trailer it now costs {discount}";
        //        }
        //    }
        //}
    }
}
