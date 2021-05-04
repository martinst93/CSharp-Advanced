using System;
using System.Collections.Generic;

namespace Models
{
    public static class DogShelter 
    {
        public static List<Dog> ListOfDogs { get; set; }

        static DogShelter()
        {
            ListOfDogs = new List<Dog>();
        }

        public static void PrintAll(List<Dog> listOfDogs)
        {
            foreach (var dog in listOfDogs)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine(new string('-', 60));
                Console.WriteLine($"{dog.Name}'s id number is {dog.ID} and his color is {dog.Color}");
            }
        }
    }
}
