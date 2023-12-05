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
        public List<Animal> Scenario(int smallCarnivore, int mediumCarnivore, int largeCarnivore, int smallHerbivore, int mediumHerbivore, int largeHerbivore)
        {
            List<Animal> scenario = new List<Animal>();

            AddToScenario(scenario, Sizes.Small, Diets.Carnivore, smallCarnivore);
            AddToScenario(scenario, Sizes.Medium, Diets.Carnivore, mediumCarnivore);
            AddToScenario(scenario, Sizes.Large, Diets.Carnivore, largeCarnivore);
            AddToScenario(scenario, Sizes.Small, Diets.Herbivore, smallHerbivore);
            AddToScenario(scenario, Sizes.Medium, Diets.Herbivore, mediumHerbivore);
            AddToScenario(scenario, Sizes.Large, Diets.Herbivore, largeHerbivore);
                
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
