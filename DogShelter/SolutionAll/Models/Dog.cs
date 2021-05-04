using System;

namespace Models
{
    public class Dog 
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public Color Color { get; set; }

        public Dog(int id, string name, Color color) 
        {
            ID = id;
            Name = name;
            Color = color;
        }

        public string Bark()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(new string('-', 60));
            return $"{Name} the dog say's Bark Bark!";
        }

        public static bool Validate(Dog dogs)
        {
            if (!(dogs.ID <= 0) && dogs.Name.Length >= 2)
            {
                return true;
            }
            else
            {
                throw new Exception("One or more of the parameters is wrong!");
            }
        }
    }
}
