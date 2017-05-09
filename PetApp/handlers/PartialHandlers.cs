using Starcounter;

namespace PetApp.handlers
{
    public class PartialHandlers
    {
        public void Register()
        {
            Handle.GET("/PetApp/partials/petpage", () => new PetPage());
        }
    }
}
