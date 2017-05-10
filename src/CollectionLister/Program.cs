using System;
using Starcounter;
using CollectionLister.Handlers;
using SharedModel;

namespace CollectionLister
{
    class Program
    {
        static void Main()
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

            var main = new MainHandlers();
            var partial = new PartialHandlers();

            main.Register();
            partial.Register();

            Blender.MapUri("/CollectionLister/partials/PetEntry/{?}", "Pet");
        }
    }
}