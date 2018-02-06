using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class AnimalWorld
    {
        public IContinentFactory ContinentFactory { get; set; }

        public Herbivore CrateHerbivores()
        {
            return ContinentFactory.CreateHerbivore();
        }

        public Carnivore CrateCarnivore()
        {
            return ContinentFactory.CreateCarnivore();
        }

        public void MealsHerbivores(Herbivore h)
        {
            h.EatGrass();
        }

        public void NutritionCarnivores(Carnivore c, Herbivore h)
        {
            c.EatHerbivore(h);
        }
    }
}
