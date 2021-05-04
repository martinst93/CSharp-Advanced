using Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Models
{
    public class Student : User , IStudent
    {
        public List<int> Grades { get; set; }
        public Student(int id, string name, string user_name, List<int> grades) : base (id, name, user_name)
        {
            Grades = grades;
        }

        public override string PrintUser()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            return $"The student's id is {ID} his name in {Name}, his user name is {User_Name}, and his grades are {Grades.Aggregate("", (accumulator, piece) => accumulator + "," + piece)}";
        }
    }
}
