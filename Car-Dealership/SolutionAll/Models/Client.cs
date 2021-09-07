using Enums;

namespace Models
{
    public class Client : User
    {
        public int Balance { get; set; }
        public Client(string firstName, string lastName, string mail, string password, RoleEnum role, int balance) : base(firstName, lastName, mail, password, role)
        {
            Balance = balance;
        }
    }
}