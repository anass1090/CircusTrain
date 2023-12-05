using CircusTrain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircusTrain
{
    public class Wagon
    {
        private readonly int Size = 10;
        public List<Animal> AnimalsInWagon { get; private set; }
        private bool carnivoreAdded = false;
        public int WagonNumber { get; set; } = 1;

        private int AvailableSpace
        {
            get {
                int space = Size;
                for (int i = 0; i < AnimalsInWagon.Count; i++)
                {
                    space -= (int)AnimalsInWagon[i].Size;
                }
                return space; 
            }
        }
        private int carnivoreSize = 0;
        public Wagon()
        {
            AnimalsInWagon = new List<Animal>();
        }

        public void AddAnimals(List<Animal> AnimalsToAdd)
        {
            for (int i = 0; i < AnimalsToAdd.Count; i++)
            {
                if (AvailableSpace == 0)
                {
                    break;
                }

                // Because the carnivores will always try to eat something as large or smaller than them they have to be in their own wagon,
                // so I first take a random carnivore and put it in the wagon.

                if (AnimalsToAdd[i].Diet == Diets.Carnivore && carnivoreAdded == false)
                {
                    carnivoreSize = (int)AnimalsToAdd[i].Size;
                    AnimalsInWagon.Add(AnimalsToAdd[i]);
                    carnivoreAdded = true;
                    AnimalsToAdd.RemoveAt(i);
                }

                // Now I have to add herbivores that are bigger than the carnivore I just added until its full

                if (AnimalsToAdd[i].Diet == Diets.Herbivore && (int)AnimalsToAdd[i].Size > carnivoreSize)
                {
                    if (AvailableSpace >= (int)AnimalsToAdd[i].Size)
                    {
                        AnimalsInWagon.Add(AnimalsToAdd[i]);
                        AnimalsToAdd.RemoveAt(i);
                        i--;
                    }
                }
            }
        }

        public void tryAddingAnimal(Animal animal)
        {

        }
    }
}
