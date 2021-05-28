using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.Enums;
using Models.Vehicles;

namespace Models
{
    public class PendingOrder : Order
    {
        public PendingOrder(string manufacturer, string model, decimal price, string type) : base(manufacturer, model, price, type)
        {
        }
    }
}
