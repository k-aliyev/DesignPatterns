using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            AnimalWorld world = new AnimalWorld();

            Herbivore h1;
            Carnivore c1;

            world.ContinentFactory = new AfricaFactory();
            h1 = world.CrateHerbivores();
            c1 = world.CrateCarnivore();

            world.MealsHerbivores(h1);
            world.NutritionCarnivores(c1, h1);
            PrintHerbivore("Africa", h1);
            PrintCarnivore("Africa", c1);

            Herbivore h2;
            Carnivore c2;

            world.ContinentFactory = new NorthAmericaFactory();
            h2 = world.CrateHerbivores();
            c2 = world.CrateCarnivore();

            world.MealsHerbivores(h2);
            world.NutritionCarnivores(c2, h2);
            PrintHerbivore("North America", h1);
            PrintCarnivore("North America", c1);
        }

        static void PrintHerbivore(string HerbivoreName, Herbivore herbivore)
        {
            Console.WriteLine("======== " + HerbivoreName + " ========");
            Console.WriteLine("Life: " + herbivore.Life);
            Console.WriteLine("Weight: " + herbivore.Weight);
        }

        static void PrintCarnivore(string CarnivoreName, Carnivore carnivore)
        {
            Console.WriteLine("======== " + CarnivoreName + " ========");
            Console.WriteLine("Power: " + carnivore.Power);
        }
    }
}

