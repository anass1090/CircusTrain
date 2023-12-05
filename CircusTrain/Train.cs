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
        public int WagonAmount { get; private set; }

        private bool addedAllAnimals = false;

        public Train()
        {
            Wagons = new List<Wagon>();
        }

        public void DistributeAnimals(List<Animal> animalsToAdd)
        {
            addedAllAnimals = false;
            Wagons = new List<Wagon>();
            SortAnimals sortAnimals = new SortAnimals();
            
            List<Animal> animalsToAddAsc = sortAnimals.Sort(animalsToAdd);
            List<Animal> animalsToAddDesc = sortAnimals.SortDesc(animalsToAdd);

            while (animalsToAddDesc.Count > 0 || animalsToAddAsc.Count > 0)
            {
                for (int i = 0; i < Wagons.Count; i++)
                {
                    foreach(Animal animal in animalsToAddDesc)
                    {
                        if (Wagons[i].TryAddingAnimal(animalsToAddDesc, animal))
                        {
                            if (animalsToAddDesc.Count == 0)
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
                    WagonAmount++;
                    Wagon wagon = new Wagon();
                    wagon.WagonNumber = WagonAmount;
                    Wagons.Add(wagon);
                } 
            }

            WagonAmount = 0;
        }

        public List<Animal> EfficiencyCheck(List<Animal> animals)
        {
            return animals;
        }
    }
}
