namespace SharedModel
{
    public enum PetType
    {
        Dog, Cat, Horse, Rabbit, Fish
    }

    public class Pet
    {
        public string Name { get; set; }
        public PetType Type { get; set; }
    }
}
