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
    public class ProcurementEmployee : Account
    {
        public List<Order> Orders { get; set; }

        public ProcurementEmployee(int id, string firstName, string lastName, string user_Name, string password, Enum_Role role, List<Order> orders, Catalog catalogs) 
            : base(id, firstName, lastName, user_Name, password, role)
        {
            Orders = orders;
        }

        public override ProcurementEmployee Validate(string userName, string password)
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
    }
}
