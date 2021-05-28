using Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Vehicles
{
    public class Car : Vehicle
    {
        public string TypeOfFuel { get; set; }
        public Car(string typeOfFuel, string manufacturer, string model, decimal price, string type) : base(manufacturer, model, price, type)
        {
            TypeOfFuel = typeOfFuel;
        }

        //public static void CarPriceRangeGasoline(List<Car> cars)
        //{
        //    Console.ForegroundColor = ConsoleColor.Magenta;
        //    Console.WriteLine(new string('-', 90));
        //    cars.ForEach(e => Console.WriteLine(e.Price));
        //    Console.WriteLine(new string('-', 90));
        //    Console.ResetColor();
        //}
        //public static void CarPriceRangeDiesel(int price)
        //{
        //    int con = price % 100;
        //    int per = con * 5;
        //    int sumPrice = per + con;
        //    Console.ForegroundColor = ConsoleColor.Magenta;
        //    Console.WriteLine(new string('-', 90));
        //    Console.WriteLine($"The price for Diesel is {sumPrice}");
        //    Console.WriteLine(new string('-', 90));
        //    Console.ResetColor();
        //}
        //public static int CarPriceRangeElectricity(int price)
        //{
        //        int con = price % 100;
        //        int per = con * 15;
        //        int sumPrice = per + con;
        //        Console.ForegroundColor = ConsoleColor.Magenta;
        //        Console.WriteLine(new string('-', 90));
        //        return sumPrice;
        //        Console.WriteLine(new string('-', 90));
        //        Console.ResetColor();
        //}
    }
}
