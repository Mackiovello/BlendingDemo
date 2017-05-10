using Starcounter;

namespace SharedModel
{
    [Database]
    public class PetOwner
    {
        public string Name;
        public Pet Pet;
    }
}