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
                var master = GetMasterPage();

                master.Pet = Self.GET("/collectionlister/partials/petentry");

                return master;
            });
        }

        private MasterPage GetMasterPage()
        {
            if (Session.Current == null)
            {
                Session.Current = new Session(SessionOptions.PatchVersioning);
            }

            MasterPage master = Session.Current.Data as MasterPage;

            if (master == null)
            {
                master = new MasterPage() { Session = Session.Current };
            }

            return master;
        }
    }
}
