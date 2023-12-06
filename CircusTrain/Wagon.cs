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
        private readonly int Size;
        private int CarnivoreSize { get; set; }
        private bool CarnivoreInWagon { get; set; } = false;
        public List<Animal> AnimalsInWagon { get; private set; }
        public int WagonNumber { get; set; }

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

        public Wagon()
        {
            AnimalsInWagon = new List<Animal>();
            Size = 10;
        }

        public bool TryAddingAnimal(List<Animal> animals, Animal animal)
        {
            if (AvailableSpace == 0)
            {
                return false;
            }

            // Because the carnivores will always try to eat something as large or smaller than them they have to be in their own wagon,
            // so I first take a random carnivore and put it in the wagon.

            if (animal.Diet == Diets.Carnivore && CarnivoreInWagon == false)
            {
                CarnivoreSize = (int)animal.Size;
                AnimalsInWagon.Add(animal);
                animals.Remove(animal);
                CarnivoreInWagon = true;
                return true;
            }

            // Now I have to add herbivores that are bigger than the carnivore I just added until its full

            if (animal.Diet == Diets.Herbivore && (int)animal.Size > CarnivoreSize)
            {
                if (AvailableSpace >= (int)animal.Size)
                {
                    AnimalsInWagon.Add(animal);
                    animals.Remove(animal);
                    return true;
                }
            }

            return false;
        }
    }
}
