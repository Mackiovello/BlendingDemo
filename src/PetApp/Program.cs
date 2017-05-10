using System;
using Starcounter;
using PetApp.handlers;

namespace PetApp
{
    class Program
    {
        static void Main()
        {
            var main = new MainHandlers();
            var partials = new PartialHandlers();

            main.Register();
            partials.Register();

            Blender.MapUri("/PetApp/partials/petpage", "Pet");
        }
    }
}