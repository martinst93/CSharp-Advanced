using System;
using Models;
using System.Collections.Generic;

namespace SchoolApp
{
    class EntryPoint
    {
        static void Main(string[] args)
        {
            Teacher Tod = new Teacher(11, "Tod Peters", "TP", new List<string>() { "JavaScript Basic", "JavaScript Advanced" });
            Teacher Mary = new Teacher(12, "Mary Smith", "MS", new List<string>() { "C# Basic", "C# Advanced" });

            Student Jamie = new Student(10, "Jamie Cooper", "JC", new List<int>() { 9, 10 });
            Student Nina = new Student(9, "Nina Pinto", "NP", new List<int>() { 10, 10 });

            Console.WriteLine(Tod.PrintUser());
            Console.WriteLine(Mary.PrintUser());
            Console.WriteLine(Jamie.PrintUser());
            Console.WriteLine(Nina.PrintUser());

            Console.ReadLine();
        }
    }
}
