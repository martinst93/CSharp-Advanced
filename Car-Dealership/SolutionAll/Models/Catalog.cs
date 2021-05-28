using Models.Vehicles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Catalog
    {
        public List<Car> Cars { get; set; }
        public List<Van> Vans { get; set; }
        public List<Truck> Trucks { get; set; }

        bool InStock { get; set; }
        public Catalog(List<Car> cars, List<Van> vans, List<Truck> trucks, bool inStock)
        {
            Cars = cars;
            Vans = vans;
            Trucks = trucks;
            InStock = inStock;
        }
        public static void SeeTheCatalog(Catalog catalogs)
        {
            foreach (var car in catalogs.Cars)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine(new string('-', 60));
                Console.WriteLine($"Car\n Manufacturer: {car.Manufacturer}, \n Model: {car.Model}, \n Car Price: ${car.Price}");
                Console.WriteLine(new string('-', 60));
                Console.ResetColor();
            }
            foreach (var van in catalogs.Vans)
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine(new string('-', 60));
                Console.WriteLine($"Van\n Manufacturer: {van.Manufacturer}, \n Model: {van.Model}, \n Van Price: ${van.Price}");
                Console.WriteLine(new string('-', 60));
                Console.ResetColor();
            }
            foreach (var truck in catalogs.Trucks)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine(new string('-', 60));
                Console.WriteLine($"Truck\n Manufacturer: {truck.Manufacturer}, \n Model: {truck.Model}, \n Truck Price: ${truck.Price}");
                Console.WriteLine(new string('-', 60));
                Console.ResetColor();
            }
        }
    }
}
