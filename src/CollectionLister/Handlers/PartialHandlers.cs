using Starcounter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionLister.Handlers
{
    public class PartialHandlers
    {
        public void Register()
        {
            Handle.GET("/CollectionLister/partials/PetEntry", () => new Page() { Html = "/CollectionLister/views/PetEntry.html" });
        }

    }
}
