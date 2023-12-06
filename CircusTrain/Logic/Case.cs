using CircusTrain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircusTrain
{
    public class Case
    {
        public List<Animal> Scenario(int countSmallCarnivore, int countMediumCarnivore, int countLargeCarnivore, int countSmallHerbivore, int countMediumHerbivore, int countLargeHerbivore)
        {
            List<Animal> scenario = new List<Animal>();

            AddToScenario(scenario, Sizes.Small, Diets.Carnivore, countSmallCarnivore);
            AddToScenario(scenario, Sizes.Medium, Diets.Carnivore, countMediumCarnivore);
            AddToScenario(scenario, Sizes.Large, Diets.Carnivore, countLargeCarnivore);
            AddToScenario(scenario, Sizes.Small, Diets.Herbivore, countSmallHerbivore);
            AddToScenario(scenario, Sizes.Medium, Diets.Herbivore, countMediumHerbivore);
            AddToScenario(scenario, Sizes.Large, Diets.Herbivore, countLargeHerbivore);
                
            return scenario;
        }

        private void AddToScenario(List<Animal> scenario, Sizes size, Diets diet, int count)
        {
            for (int i = 0; i < count; i++)
            {
                scenario.Add(new Animal("test", diet, size));
            }
        }
    }
}
