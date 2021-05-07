namespace Models
{
    public class Fish : Pet
    {
        public string Color { get; set; }
        public int Size { get; set; }

        public override string PrintInfo()
        {
            return $"{base.Name} the {base.Type} is {base.Age} years old.";
        }
    }
}
