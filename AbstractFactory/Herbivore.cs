using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public abstract class Herbivore
    {
        private int weight;
        private bool life;

        public int Weight { get; set; }
        public bool Life { get; set; }
        public abstract void EatGrass();
    }

    public class Wildebeest : Herbivore
    {
        public Wildebeest()
        {
            Weight = 10;
            Life = true;
        }

        public override void EatGrass()
        {
            Weight += 10;
        }
    }

    public class Bison : Herbivore
    {
        public Bison()
        {
            Weight = 10;
            Life = true;
        }

        public override void EatGrass()
        {
            Weight += 10;
        }
    }
}
