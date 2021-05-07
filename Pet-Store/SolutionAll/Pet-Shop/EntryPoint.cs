using System;
using Models;

namespace Pet_Shop
{
    class EntryPoint
    {
        static void Main(string[] args)
        {
            PetStore<Cat> catStore = new PetStore<Cat>();
            PetStore<Dog> dogStore = new PetStore<Dog>();
            PetStore<Fish> fishStore = new PetStore<Fish>();

            catStore.Pets.Add(new Cat() { Name = "Luna", Lazy = true, LivesLeft = 5, Age = 8, Type = "Persian" });
            catStore.Pets.Add(new Cat() { Name = "Kiki", Lazy = false, LivesLeft = 1, Age = 11, Type = "Egyptian Mau" });

            dogStore.Pets.Add(new Dog() { Name = "Barney", GoodBoy = true, FavoriteFood = "salmon", Age = 10, Type = "Beagle" });
            dogStore.Pets.Add(new Dog() { Name = "Meeko", GoodBoy = false, FavoriteFood = "beef", Age = 7, Type = "Pit Bull" });

            fishStore.Pets.Add(new Fish() { Name = "Bubbles", Size = 8, Color = "orange", Age = 29, Type = "Neon Tetra" });
            fishStore.Pets.Add(new Fish() { Name = "Crystal", Size = 18, Color = "dark violet", Age = 47, Type = "Betta" });


            while (true)
            {
            Start:
                Console.WriteLine("Welcome To The Pet Store!");
                Console.WriteLine();

                Console.ForegroundColor = ConsoleColor.Yellow;
                catStore.PrintPets(600);
                Console.ResetColor();


                Console.ForegroundColor = ConsoleColor.Red;
                dogStore.PrintPets(600);
                Console.ResetColor();


                Console.ForegroundColor = ConsoleColor.Blue;
                fishStore.PrintPets(600);
                Console.ResetColor();


                Console.WriteLine(new string('-', 80));


                Console.WriteLine("Write the name of a pet to buy it");
                string petName = Console.ReadLine();

                if (petName == null)
                {
                    Console.WriteLine("Sorry. We don't have that name in the Pet Store");
                }
                else
                {
                    Console.Clear();
                    catStore.BuyPet(petName);
                    dogStore.BuyPet(petName);
                    fishStore.BuyPet(petName);
                    goto Start;
                }

                break;
            }

            Console.ReadLine();
        }
    }
}
