using Models.Enums;
using Models.Vehicles;

namespace Models
{
    public class Order : Vehicle
    {
        public Order(string manufacturer, string model, decimal price, string type) : base(manufacturer, model, price, type)
        {
        }
    }
}