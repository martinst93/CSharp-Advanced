using System;

namespace Animal
{
    class EntryPoint
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a name for the dog.");
            string name = Console.ReadLine();
            Console.WriteLine("Please enter age of the dog.");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the color of the dog.");
            string color = Console.ReadLine();

            Dog.CreateDogMethod(name, age, color);
        }
    }
}
