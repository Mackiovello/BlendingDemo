using Starcounter;
using SharedModel;

namespace CollectionLister
{
    class Program
    {
        static void Main()
        {
            Application.Current.Use(new HtmlFromJsonProvider());
            Application.Current.Use(new PartialToStandaloneHtmlProvider());

            PopulateList();

            Handle.GET("/CollectionLister", () =>
            {
                var listPage = GetListPage();

                listPage.Owners.Data = Db.SQL("SELECT o FROM SharedModel.PetOwner o");

                return listPage;
            });

            Handle.GET("/CollectionLister/partials/PetEntry/{?}", (string ownerId) => new Page { Html = "/CollectionLister/views/EmptyPage.html" });
            Blender.MapUri("/CollectionLister/partials/PetEntry/{?}", "Pet");
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