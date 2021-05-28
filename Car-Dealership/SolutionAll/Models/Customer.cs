using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using Models.Enums;
using Models.Vehicles;

namespace Models
{
    public class Customer : Account
    {
        public Customer(int id, string firstName, string lastName, string user_Name, string password, Enum_Role role)
            : base(id, firstName, lastName, user_Name, password, role)
        {
        }
        public override Customer Validate(string userName, string password)
        {
            if (null == userName || null == password)
            {
                throw new ArgumentNullException();
            }

            if (!(userName == User_Name && password == Password))
            {
                Console.WriteLine("Unknown User name or Password");
            }

            return this;
        }
    }
}

