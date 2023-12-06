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
            animalsToAdd = animalsToAdd
                .OrderByDescending(a => a.Diet)
                .ThenBy(a => (int)a.Size)
                .ToList();
            return animalsToAdd;
        }

        public List<Animal> SortDesc(List<Animal> animalsToAdd)
        {
            animalsToAdd = animalsToAdd
                .OrderByDescending(a => a.Diet)
                .ThenByDescending(a => (int)a.Size)
                .ToList();
            return animalsToAdd;
        }
    }
}
