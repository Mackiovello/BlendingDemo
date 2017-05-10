using Starcounter;

namespace SharedModel
{
    public enum PetType
    {
        Cat, Dog, Fish, Bird, Horse
    }

    [Database]
    public class Pet
    {
        public string Name { get; set; }
        public PetType Type { get; set; }
    }
}
