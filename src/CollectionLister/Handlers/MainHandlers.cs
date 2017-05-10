using Starcounter;

namespace CollectionLister.Handlers
{
    public class MainHandlers
    {
        public void Register()
        {
            Application.Current.Use(new HtmlFromJsonProvider());
            Application.Current.Use(new PartialToStandaloneHtmlProvider());

            Handle.GET("/CollectionLister", () =>
            {
                var listPage = GetListPage();

                listPage.Pet = Self.GET("/collectionlister/partials/petentry");

                return listPage;
            });
        }

        private ListPage GetListPage()
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
