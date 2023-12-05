using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircusTrain
{
    public class SortAnimals
    {
        public List<Animal> Sort(List<Animal> animalsToAdd)
        {
            List<Animal> sortedAnimals = new List<Animal>();

            sortedAnimals = animalsToAdd
                .OrderByDescending(a => a.Diet)
                .ThenBy(a => (int)a.Size)
                .ToList();
            return sortedAnimals;
        }

        public List<Animal> SortDesc(List<Animal> animalsToAdd)
        {
            List<Animal> sortedAnimals = new List<Animal>();

            sortedAnimals = animalsToAdd
                .OrderByDescending(a => a.Diet)
                .ThenByDescending(a => (int)a.Size)
                .ToList();
            return sortedAnimals;
        }
    }
}
