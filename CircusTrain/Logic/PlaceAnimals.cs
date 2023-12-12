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
            List<Wagon> Wagons = new List<Wagon>();
            bool addedAllAnimals = false;

            animalsToAdd = isDescending ? sortAnimals.SortDesc(animalsToAdd) : sortAnimals.Sort(animalsToAdd);
            wagonAmount = 0;

            while (animalsToAdd.Count > 0)
            {
                bool addedAnimal = TryAddingAnimalToWagons(animalsToAdd, Wagons);

                if (!addedAllAnimals && !addedAnimal)
                {
                    AddNewWagon(Wagons);
                }
            }

            return Wagons;
        }

        public bool TryAddingAnimalToWagons(List<Animal> animalsToAdd, List<Wagon> wagons)
        {
            bool addedAnimal = false;

            foreach (Animal animal in animalsToAdd)
            {
                foreach (Wagon wagon in wagons)
                {
                    if (wagon.TryAddingAnimal(animal))
                    {
                        animalsToAdd.Remove(animal);
                        addedAnimal = true;

                        if (animalsToAdd.Count == 0)
                        {
                            return true;
                        }

                        break;
                    }
                }
                break;
            }

            return addedAnimal;
        }

        public void AddNewWagon(List<Wagon> Wagons)
        {
            wagonAmount++;
            Wagon wagon = new Wagon
            {
                WagonNumber = wagonAmount
            };

            Wagons.Add(wagon);
        }
    }
}
