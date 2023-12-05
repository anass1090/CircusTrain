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
        private int WagonAmount { get; set; } 
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
                    WagonAmount++;
                    Wagon newWagon = new Wagon();
                    newWagon.WagonNumber = WagonAmount;
                    newWagon.AddAnimals(animalsToAdd);
                    Wagons.Add(newWagon);
                }
            }

            WagonAmount = 0;
        }
    }
}
