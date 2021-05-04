using System;
using Models;
using System.Collections.Generic;

namespace Exercise01
{
    class EntryPoint
    {
        static void Main(string[] args)
        {
            Dog alfie = new Dog(7, "Alfie", Color.Brown);
            Dog remi = new Dog(9, "Remi", Color.White);
            Dog dingo = new Dog(10, "Dingo", Color.Black);

            Console.WriteLine(alfie.Bark());
            Console.WriteLine(remi.Bark());
            Console.WriteLine(dingo.Bark());

            if (Dog.Validate(alfie) && Dog.Validate(remi) && Dog.Validate(dingo))
            {
                DogShelter.ListOfDogs.AddRange(new List<Dog>() { alfie, remi, dingo });
            }
           
            DogShelter.PrintAll(DogShelter.ListOfDogs);

            Console.ReadLine();
        }
    }
}
