using System;
using System.Collections.Generic;
using System.Linq;
using Models;

    public class PetStore<T> where T : Pet
{
        public List<T> Pets;

        public void PrintPets(int speed)
        {
            Pets.ForEach(x => Console.WriteLine(x.PrintInfo()));
        }

        public PetStore()
        {
            this.Pets = new List<T>();
        }

        public void BuyPet(string name)
        {
            foreach (T pet in Pets)
            {
                if (name == pet.Name)
                {
                    Pets.FirstOrDefault(x => x.Name == name);
                    Pets.Remove(pet);
                    Console.WriteLine($"Congratulations! You bought a {pet.GetType().Name}");
                    break;
                }
            }
        }
}
