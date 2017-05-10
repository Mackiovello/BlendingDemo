using SharedModel;
using Starcounter;
using System;

namespace CollectionLister.Handlers
{
    public class PartialHandlers
    {
        public void Register()
        {
            Handle.GET("/CollectionLister/partials/PetEntry/{?}", (string ownerId) => new Page { Html = "/CollectionLister/views/EmptyPage.html" });
        }
    }
}
