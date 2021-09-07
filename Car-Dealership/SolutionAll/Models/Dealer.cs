using Enums;
using System;

namespace Models
{
    public class Dealer : User
    {
        public int YearsOfExperience { get; set; }
        public DateTime BirthDate { get; set; }
        public string Address { get; set; }
        public int PhoneNo { get; set; }
        public int TotalVehiclePurchase { get; set; }
        public Dealer(string firstName, string lastName, string mail, string password, RoleEnum role, int experience, DateTime birthDate, string address, int phoneNo, int totalVehiclePurchase) : base(firstName, lastName, mail, password, role)
        {
            YearsOfExperience = experience;
            BirthDate = birthDate;
            Address = address;
            PhoneNo = phoneNo;
            TotalVehiclePurchase = totalVehiclePurchase;
        }
    }
}