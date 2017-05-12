using Starcounter;
using SharedModel;

namespace PetOwnerList
{
    class Program
    {
        static void Main()
        {
            Application.Current.Use(new HtmlFromJsonProvider());
            Application.Current.Use(new PartialToStandaloneHtmlProvider());

            PopulateList();

            Handle.GET("/PetOwnerList", () =>
            {
                var listPage = GetListPage();

                listPage.Owners.Data = Db.SQL("SELECT o FROM SharedModel.PetOwner o");

                return listPage;
            });

            Handle.GET("/PetOwnerList/partials/PetEntry/{?}", (string ownerId) => new Json());
            Blender.MapUri("/PetOwnerList/partials/PetEntry/{?}", "PetInfo");
        }

        private static void PopulateList()
        {
            bool listIsEmpty = Db.SQL("SELECT p FROM SharedModel.PetOwner p").First == null;

            if (listIsEmpty)
            {
                Db.Transact(() =>
                {
                    new PetOwner
                    {
                        Name = "Emma",
                        Pet = new Pet { Name = "Lassie", Type = PetType.Dog },
                    };

                    new PetOwner
                    {
                        Name = "James",
                        Pet = new Pet { Name = "Tiger", Type = PetType.Cat }
                    };


                    new PetOwner
                    {
                        Name = "Mary",
                        Pet = new Pet { Name = "Nemo", Type = PetType.Fish }
                    };
                });
            }
        }

        private static ListPage GetListPage()
        {
            if (Session.Current == null)
            {
                Session.Current = new Session(SessionOptions.PatchVersioning);
            }

            ListPage master = Session.Current.Data as ListPage;

            if (master == null)
            {
                master = new ListPage() { Session = Session.Current };
            }

            return master;
        }
    }
}