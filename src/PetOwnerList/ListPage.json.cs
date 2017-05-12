using Starcounter;

namespace PetOwnerList
{
    partial class ListPage : Json
    {
        [ListPage_json.Owners]
        partial class OwnerPage : Json
        {
            protected override void OnData()
            {
                base.OnData();
                this.Pet.Info = Self.GET("/PetOwnerList/partials/PetEntry/" + this.Key);
            }
        }
    }
}
