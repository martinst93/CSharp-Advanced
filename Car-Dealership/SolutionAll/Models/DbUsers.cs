using System;
using System.Collections.Generic;
using Enums;

namespace Models
{
    public static class DbUsers
    {
        public static List<User> Users;

        static DbUsers()
        {
            Users = new List<User>
            {
                new Client("Aleksandar", "Planic", "aleksandar@gmail.com", "12345", RoleEnum.Client, 50000),
                new Sale("Pera", "Peric", "pera@gmail.com", "12345", RoleEnum.Sale, 7, new DateTime(1985, 5, 10), "Hristo Tatarchev", 078123456, 80),
                new Dealer("Mika", "Mikic", "mika@gmail.com", "12345", RoleEnum.Dealer, 10, new DateTime(1990, 1, 15), "Goce Delchev", 070654321, 120),
                new Client("Marija", "Maric", "marija@gmail.com", "12345", RoleEnum.Client, 100000),
                new Sale("Dejan", "Deni", "dejan@gmail.com", "12345", RoleEnum.Sale, 5, new DateTime(1975, 5, 04), "Hristo Tatarchev", 065123456, 50),
                new Dealer("Luka", "Lukic", "luka@gmail.com", "12345", RoleEnum.Dealer, 8, new DateTime(1977, 3, 22), "Hristo Tatarchev", 078555444, 220)

            };
        }
    }
}