using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircusTrain
{
    public class Train
    {
        public List<Wagon> Wagons { get; private set; }
        private readonly PlaceAnimals placeAnimals = new PlaceAnimals();

        public List<Wagon> AddWagons(List<Animal> animalsToAdd)
        {
            Wagons = new List<Wagon>();

            List<Wagon> WagonsDesc = placeAnimals.AllocateAnimals(animalsToAdd);
            List<Wagon> WagonsAsc = placeAnimals.AllocateAnimals(animalsToAdd, false);

            if(WagonsDesc.Count < WagonsAsc.Count)
            {
                Wagons.AddRange(WagonsDesc);
                return WagonsDesc;
            } else
            {
                Wagons.AddRange(WagonsAsc);
                return WagonsAsc;
            }
        }
    }
}
