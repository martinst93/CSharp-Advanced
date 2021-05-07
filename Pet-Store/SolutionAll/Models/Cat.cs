namespace Models
{
    public class Cat : Pet
    {
        public bool Lazy { get; set; }
        public int LivesLeft { get; set; }

        public override string PrintInfo()
        {
            return $"{base.Name} the {base.Type} is {base.Age} years old.";
        }
    }
}
