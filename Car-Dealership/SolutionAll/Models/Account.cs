using System;
using Models.Enums;

namespace Models
{
    public abstract class Account
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string User_Name { get; set; }
        public string Password { get; set; }
        public Enum_Role Role { get; set; }

        public Account(int id, string firstName, string lastName, string user_Name, string password, Enum_Role role)
        {
            ID = id;
            FirstName = firstName;
            LastName = lastName;
            User_Name = user_Name;
            Password = password;
            Role = role;
        }

        public virtual Account Validate(string userName, string password)
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
