using System;

public class Class1
{
    public class PetStore<T> where T : Pet
    {
        public List<T> Pets;

        public void PrintPets(int speed)
        {
            Pets.ForEach(x => Console.WriteLine(x.PrintInfo()));
            Thread.Sleep(speed);
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
                    Console.WriteLine($"Congratulations! You bought a {pet.GetType().Name}. Keep your pet healthy and safety");
                    break;
                }
            }
        }
    }
