using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircusTrain
{
    public class PlaceAnimals
    {
        private readonly SortAnimals sortAnimals = new SortAnimals();
        private int wagonAmount;

        public List<Wagon> AllocateAnimals(List<Animal> animalsToAdd, bool isDescending = true)
        {
            wagonAmount = 0;
            List<Wagon> Wagons = new List<Wagon>();
            animalsToAdd = isDescending ? sortAnimals.SortDesc(animalsToAdd) : sortAnimals.Sort(animalsToAdd);

            foreach (Animal animal in animalsToAdd)
            {
                if (!TryAddingAnimalToWagons(animal, Wagons))
                {
                    Wagons.Add(CreateNewWagonWithAnimal(animal));
                }
            }

            return Wagons;
        }

        public bool TryAddingAnimalToWagons(Animal animal, List<Wagon> wagons)
        {
            foreach (Wagon wagon in wagons)
            {
                if (wagon.TryAddingAnimal(animal))
                {
                    return true;
                }
            }

            return false;
        }

        public Wagon CreateNewWagonWithAnimal(Animal animal)
        {
            wagonAmount++;
            Wagon wagon = new Wagon
            {
                WagonNumber = wagonAmount
            };

            wagon.TryAddingAnimal(animal);
            return wagon;
        }
    }
}
