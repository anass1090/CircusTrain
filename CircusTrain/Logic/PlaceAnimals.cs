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

        public List<Wagon> AllocateAnimals(List<Animal> animalsToAdd, bool isDescending = true)
        {
            List<Wagon> Wagons = new List<Wagon>();
            bool addedAllAnimals = false;
            int WagonAmount = 0;

            animalsToAdd = isDescending ? sortAnimals.SortDesc(animalsToAdd) : sortAnimals.Sort(animalsToAdd);

            while (animalsToAdd.Count > 0)
            {
                bool addedAnimal = false;

                foreach (Wagon wagon in Wagons)
                {
                    foreach (Animal animal in animalsToAdd)
                    {
                        addedAnimal = false;

                        if (wagon.TryAddingAnimal(animalsToAdd, animal))
                        {
                            addedAnimal = true;
                            if (animalsToAdd.Count == 0)
                            {
                                addedAllAnimals = true;
                                break;
                            }
                            break;
                        }
                    }
                }

                if (!addedAllAnimals && !addedAnimal)
                {
                    WagonAmount++;
                    Wagon wagon = new Wagon
                    {
                        WagonNumber = WagonAmount
                    };
                    Wagons.Add(wagon);
                }
            }

            return Wagons;
        }
    }
}
