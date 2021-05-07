namespace Models
{
    public class Dog : Pet
    {
        public bool GoodBoy { get; set; }
        public string FavoriteFood { get; set; }

        public override string PrintInfo()
        {
            return $"{base.Name} the {base.Type} is {base.Age} years old.";
        }
    }
}
