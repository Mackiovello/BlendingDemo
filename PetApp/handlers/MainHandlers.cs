using Starcounter;

namespace PetApp.handlers
{
    public class MainHandlers
    {
        public void Register()
        {
            Application.Current.Use(new HtmlFromJsonProvider());
            Application.Current.Use(new PartialToStandaloneHtmlProvider());

            Handle.GET("/PetApp", () =>
            {
                return new PetPage();
            });
        }
    }
}
