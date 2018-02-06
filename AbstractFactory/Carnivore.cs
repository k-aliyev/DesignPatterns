using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public abstract class Carnivore
    {
        private int power;

        public int Power { get; set; }
        public abstract void EatHerbivore(Herbivore obj);
    }

    public class Lion : Carnivore
    {
        public Lion()
        {
            Power = 10;
        }

        public override void EatHerbivore(Herbivore obj)
        {
            if (obj.Weight < Power)
            {
                Power += 10;
                obj.Life = false;
            }
            else
            {
                Power -= 10;
            }
        }
    }

    public class Wolf : Carnivore
    {
        public Wolf()
        {
            Power = 10;
        }

        public override void EatHerbivore(Herbivore obj)
        {
            if (obj.Weight < Power)
            {
                Power += 10;
                obj.Life = false;
            }
            else
            {
                Power -= 10;
            }
        }
    }
}
