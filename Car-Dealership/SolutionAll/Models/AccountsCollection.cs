using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using Models.Enums;

namespace Models
{
    public class AccountsCollection
    {
        public List<Customer>  Customers { get; set; }
        public List<SalesEmployee> SalesEmployees { get; set; }
        public List<ProcurementEmployee> ProcurementEmployees { get; set; }

        public AccountsCollection(List<Customer> customers, List<SalesEmployee> salesEmployees, List<ProcurementEmployee> procurementEmployees)
        {
            Customers = customers;
            SalesEmployees = salesEmployees;
            ProcurementEmployees = procurementEmployees;
        }

        //public static void Validate(AccountsCollection accountsList, string userName, string password)
        //{
        //    foreach (var item in accountsList.Customers)
        //    {
        //        if (null == userName || null == password)
        //        {
        //            throw new ArgumentNullException();
        //        }

        //        if (!(userName == item.User_Name && password == item.Password))
        //        {
        //            throw new Exception("Unknown User name or Password");
        //        }
        //        if (item.Role == Enum_Role.Customer)
        //        {
        //            continue;
        //        }
        //    }

        //    foreach (var item in accountsList.SalesEmployees)
        //    {
        //        if (null == userName || null == password)
        //        {
        //            throw new ArgumentNullException();
        //        }

        //        if (!(userName == item.User_Name && password == item.Password))
        //        {
        //            throw new Exception("Unknown User name or Password");
        //        }
        //        if (item.Role == Enum_Role.SalesEmployee)
        //        {
        //            continue;
        //        }
        //    }

        //    foreach (var item in accountsList.ProcurementEmployees)
        //    {
        //        if (null == userName || null == password)
        //        {
        //            throw new ArgumentNullException();
        //        }

        //        if (!(userName == item.User_Name && password == item.Password))
        //        {
        //            throw new Exception("Unknown User name or Password");
        //        }
        //        if (item.Role == Enum_Role.ProcurementEmployee)
        //        {
        //            continue;
        //        }
        //    }
        //}
    }
}
