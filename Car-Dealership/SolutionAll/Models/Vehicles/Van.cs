using Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Vehicles
{
    public class Van : Vehicle
    {
        public string Payload { get; set; }
        public Van(string payload, string manufacturer, string model, decimal price, string type) : base(manufacturer, model, price, type)
        {
            Payload = payload;
        }

        public static void VanPriceRange(string payload, List<Van> vans)
        {
            if (payload == "Small")
            {
                foreach (var van in vans)
                {
                    Console.WriteLine($"The Price for the small payload is {van.Price}");
                }
            }
            if (payload == "Medium")
            {
                foreach (var van in vans)
                {
                    Console.WriteLine($"The Price for the medium payload is {van.Price}");
                }
            }
            if (payload == "Large")
            {
                foreach (var van in vans)
                {
                    Console.WriteLine($"The Price for the large payload is {van.Price}");
                }
            }
        }
    }
}
