using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class User : Person
    {
        public int Balance { get; set; }
        public List<Invoice> Invoice { get; set; }
        public User(string firstName, string lastName, string userName, string password, int balance, RoleEnum role)
            : base (firstName, lastName, userName, password, role)
        {
            Balance = balance;
            Invoice = new List<Invoice>();
        }
    }
}
