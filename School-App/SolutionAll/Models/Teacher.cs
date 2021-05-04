using System;
using System.Collections.Generic;
using System.Linq;
using Models.Interfaces;

namespace Models
{
    public class Teacher : User , ITeacher
    {
        public List<string> Subjects { get; set; }
        public Teacher(int id, string name, string user_name, List<string> subjects) : base(id, name, user_name)
        {
            Subjects = subjects;
        }

        public override string PrintUser()
        {
            string delimiter = ",";
            Console.ForegroundColor = ConsoleColor.Cyan;
            return $"The teacher's id is {ID} his name in {Name}, his user name is {User_Name}, and the subjects he teaches are {Subjects.Aggregate((i, j) => i + delimiter + j)}";
        }
    }
}
