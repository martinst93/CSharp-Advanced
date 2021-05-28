using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.Enums;
using Models;

namespace Models.Vehicles
{
    public abstract class Vehicle
    {
        public string Manufacturer { get; set; }
        public string Model { get; set; }
        public decimal Price { get; set; }
        public string Type { get; set; } 

        public Vehicle(string manufacturer, string model, decimal price, string type)
        {
            Manufacturer = manufacturer;
            Model = model;
            Price = price;
            Type = type;
        }
    }
}
