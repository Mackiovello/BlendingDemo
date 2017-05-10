using System;
using Starcounter;
using CollectionLister.Handlers;

namespace CollectionLister
{
    class Program
    {
        static void Main()
        {
            var main = new MainHandlers();
            var partial = new PartialHandlers();

            main.Register();
            partial.Register();

            Blender.MapUri("/collectionlister/partials/petentry", "Pet");
        }
    }
}