using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    interface IContinentFactory
    {
        Herbivore CreateHerbivore();
        Carnivore CreateCarnivore();
    }

    class AfricaFactory : IContinentFactory
    {
        public Herbivore CreateHerbivore()
        {
            return new Wildebeest();
        }
        public Carnivore CreateCarnivore()
        {
            return new Lion();
        }
    }

    class NorthAmericaFactory : IContinentFactory
    {
        public Herbivore CreateHerbivore()
        {
            return new Bison();
        }
        public Carnivore CreateCarnivore()
        {
            return new Wolf();
        }
    }
}
