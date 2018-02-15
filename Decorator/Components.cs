using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    abstract class Component
    {
        public int Attack { get; set; }
        public int Speed { get; set; }
        public int Health { get; set; }
        public int Protection { get; set; }

        public abstract int Move();
    }

    class Human : Component
    {
        public Human()
        {
            Attack = 20;
            Speed = 20;
            Health = 150;
            Protection = 0;
        }

        public override int Move()
        {
            return Speed;
        }
    }

    class Elf : Component
    {
        public Elf()
        {
            Attack = 15;
            Speed = 30;
            Health = 100;
            Protection = 0;
        }

        public override int Move()
        {
            return Speed;
        }
    }
}
