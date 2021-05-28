using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using Models.Enums;

namespace Models
{
    public class SalesEmployee : Account
    {
        public List<Customer> Customers { get; set; }
        public List<Order> Orders { get; set; }

        public SalesEmployee(int id, string firstName, string lastName, string user_Name, string password, Enum_Role role) 
            : base(id, firstName, lastName, user_Name, password, role)
        {

        }

        public override SalesEmployee Validate(string userName, string password)
        {
            if (null == userName || null == password)
            {
                throw new ArgumentNullException();
            }

            if (!(userName == User_Name && password == Password))
            {
                throw new Exception("Unknown User name or Password");
            }

            return this;
        }
        public static void SeePendingOrderList(List<PendingOrder> PendingOrderList)
        {
            foreach (var order in PendingOrderList)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine(new string('-', 60));
                Console.WriteLine($"Pending Orders\n Manufacturer: {order.Manufacturer}, \n Model: {order.Model}, \n Type: {order.Type}, \n Price: ${order.Price}");
                Console.WriteLine(new string('-', 60));
                Console.ResetColor();
            }
        }
        public static void SeeTheCustumerList(List<Customer> CustomerList)
        {
            foreach (var custumer in CustomerList)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine(new string('-', 60));
                Console.WriteLine($"Customer\n First Name: {custumer.FirstName}, \n Last Name: {custumer.LastName}, \n ");
                Console.WriteLine(new string('-', 60));
                Console.ResetColor();
            }
        }

        public static void DeclineOrder(List<PendingOrder> PendingOrderList)
        {
            foreach (var order in PendingOrderList)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(new string('-', 60));
                Console.WriteLine($"Pending Orders\n Manufacturer: {order.Manufacturer}, \n Model: {order.Model}, \n Type: {order.Type}, \n Price: ${order.Price}");
                Console.WriteLine(new string('-', 60));
                Console.ResetColor();

                //PendingOrderList.RemoveRange(order.Manufacturer, order.Model, order.Type, order.Price);
            }
        }
    }
}
