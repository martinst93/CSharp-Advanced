using System;
using System.IO;
using Newtonsoft.Json;

namespace Animal
{
    public class Dog
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Color { get; set; }

        public static void CreateDogMethod(string name, int age, string color)
        {
            string path = @"E:\vezbi programiranje\C# Advanced\CSharp-Advanced\Animal\SolutionAll\Animal.json";
            
            Dog sparky = new Dog()
            {
                Name = name,
                Age = age,
                Color = color
            };

            string dogString = JsonConvert.SerializeObject(sparky);

            using (StreamWriter sw = new StreamWriter(path))
            {
                sw.WriteLine(dogString);
            }

            Dog dog = JsonConvert.DeserializeObject<Dog>(dogString);
            Console.WriteLine($"Name: {dog.Name},\nAge: {dog.Age},\nColor: {dog.Color}");
                
            using (StreamReader sr = new StreamReader(path))
            {
                string result = sr.ReadToEnd();
                Console.WriteLine(new string('-', 60));
                Console.WriteLine(result);
            }
        }
    }
}
