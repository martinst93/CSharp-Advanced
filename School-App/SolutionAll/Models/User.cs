using Models.Interfaces;
namespace Models
{
    public abstract class User : IUser
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string User_Name { get; set; }

        public User(int id, string name, string user_name)
        {
            ID = id;
            Name = name;
            User_Name = user_name;
        }

        public virtual string PrintUser()
        {
            return $"The user's id is {ID} his name in {Name}, and his user name is {User_Name}";
        }
    }
}
