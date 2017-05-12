using System.Collections.Generic;
using Starcounter;
using SharedModel;

namespace PetImageProvider
{
    class Program
    {
        static void Main()
        {
            Handle.GET("/PetImageProvider/partials/petimage/{?}", (string ownerId) =>
            {
                var imageFromType = new Dictionary<PetType, string>()
                {
                    { PetType.Cat,  "http://www.cats.org.uk/uploads/images/pages/photo_latest14.jpg"},
                    { PetType.Dog,  "http://cdn1-www.dogtime.com/assets/uploads/2011/01/file_23262_entlebucher-mountain-dog-460x290.jpg"},
                    { PetType.Fish, "https://vignette2.wikia.nocookie.net/pixar/images/8/82/Nemo.png/revision/latest?cb=20110504131029"}
                };

                var petOwner = DbHelper.FromID(DbHelper.Base64DecodeObjectID(ownerId)) as PetOwner;
                PetType petType = petOwner.Pet.Type;

                return new PetImage { Src = imageFromType[petType] };
            });

            Blender.MapUri("/PetImageProvider/partials/petimage/{?}", "PetInfo");
        }
    }
}