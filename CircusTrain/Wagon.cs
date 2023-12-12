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

        public bool TryAddingAnimal(Animal animal)
        {
            if (AvailableSpace == 0) return false;
            
            bool carnivoreAdded = TryAddingCarnivore(animal);
            bool herbivoreAdded = TryAddingHerbivore(animal);

            return carnivoreAdded || herbivoreAdded;
        }

        public bool TryAddingCarnivore(Animal animal)
        {
            if (animal.Diet == Diets.Carnivore && CarnivoreInWagon == false)
            {
                CarnivoreSize = (int)animal.Size;
                AnimalsInWagon.Add(animal);
                CarnivoreInWagon = true;
                return true;
            }

            return false;
        }

        public bool TryAddingHerbivore(Animal animal)
        {
            if (animal.Diet == Diets.Herbivore && (int)animal.Size > CarnivoreSize)
            {
                if (AvailableSpace >= (int)animal.Size)
                {
                    AnimalsInWagon.Add(animal);
                    return true;
                }
            }

            return false;
        }
    }
}
