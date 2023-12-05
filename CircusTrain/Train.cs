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
        private bool addedAllAnimals = false;

        //public Train()
        //{
        //    Wagons = new List<Wagon>();
        //}

        public void AddWagons(List<Animal> animalsToAdd)
        {
            Wagons = new List<Wagon>();

            while (animalsToAdd.Count > 0)
            {
                foreach (var wagon in Wagons)
                {
                    wagon.AddAnimals(animalsToAdd);

                    if (animalsToAdd.Count == 0)
                    {
                        addedAllAnimals = true;
                    }
                }

                if (!addedAllAnimals)
                {
                    var newWagon = new Wagon();
                    newWagon.AddAnimals(animalsToAdd);
                    Wagons.Add(newWagon);
                }
            }
        }

        public void DistributeAnimals(List<Animal> animalsToAdd)
        {
            Wagons = new List<Wagon>();
            SortAnimals sortAnimals = new SortAnimals();

            sortAnimals.Sort(animalsToAdd);

            while (animalsToAdd.Count > 0)
            {
                for (int i = 0; i < Wagons.Count; i++) 
                {
                    for (int j = 0; j < animalsToAdd.Count; j++)
                    {
                        if (animalsToAdd.Count == 0)
                        {
                            addedAllAnimals = true;
                            break;
                        }
                        if (Wagons[i].TryAddingAnimal(animalsToAdd, animalsToAdd[j]))
                        {
                            if (animalsToAdd.Count == 0)
                            {
                                addedAllAnimals = true;
                                break;
                            }
                            i--;
                            break;
                        }
                    }
                }

                if (!addedAllAnimals)
                {
                    Wagon wagon = new Wagon();
                    Wagons.Add(wagon);
                }
            }
        }
    }
}
