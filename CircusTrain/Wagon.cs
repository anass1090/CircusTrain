using CircusTrain.Enums;
using System.Collections.Generic;
using System.Linq;

namespace CircusTrain
{
    public class Wagon
    {
        private readonly int Size;
        public List<Animal> AnimalsInWagon { get; private set; }
        public int WagonNumber { get; set; }

        private int CarnivoreSize { 
            get { 
                Animal carnivore = AnimalsInWagon.Find(e => e.Diet.Equals(Diets.Carnivore));
                return carnivore != null ? (int)carnivore.Size : 0;
            }
        }

        private bool CarnivoreInWagon { 
            get { 
                return AnimalsInWagon.Any(e => e.Diet.Equals(Diets.Carnivore)); 
            } 
        }

        private int AvailableSpace {
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

            return animal.Diet.Equals(Diets.Carnivore) ? TryAddingCarnivore(animal) : TryAddingHerbivore(animal);
        }

        public bool TryAddingCarnivore(Animal animal)
        {
            if (CarnivoreInWagon == false)
            {
                AnimalsInWagon.Add(animal);
                return true;
            }

            return false;
        }

        public bool TryAddingHerbivore(Animal animal)
        {
            if ((int)animal.Size > CarnivoreSize)
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
