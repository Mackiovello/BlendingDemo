using SharedModel;
using Starcounter;
using System;

namespace CollectionLister.Handlers
{
    public class PartialHandlers
    {
        public void Register()
        {
            Handle.GET("/CollectionLister/partials/PetEntry", () => new Page() { Html = "/CollectionLister/views/PetEntry.html" });

            Handle.GET("/CollectionLister/partials/PetEntry/{?}", (string ownerId) =>
            {
                var page = new PetTypePage();
                var petOwner = DbHelper.FromID(DbHelper.Base64DecodeObjectID(ownerId)) as PetOwner;
                PetType petType = petOwner.Pet.Type;
                page.Type = Enum.GetName(typeof(PetType), petType);

                return page;
            });
        }
    }
}
