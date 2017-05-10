using Starcounter;

namespace CollectionLister
{
    partial class ListPage : Json
    {
        [ListPage_json.Owners]
        partial class OwnerPage : Json
        {
            protected override void OnData()
            {
                base.OnData();
                this.Pet.Info = Self.GET("/CollectionLister/partials/PetEntry/" + this.Key);
            }
        }
    }
}
