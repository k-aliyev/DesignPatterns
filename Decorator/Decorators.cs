using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    abstract class Decorator : Component
    {
        protected Component component;

        public abstract void SetComponent(Component component);

        protected abstract void SetProperties();

        public override int Move()
        {
            if (component != null)
            {
                return component.Move();
            }
            return 0;
        }

        public void Print()
        {
            Console.WriteLine("-------------------------------");
            Console.WriteLine(component.Attack);
            Console.WriteLine(component.Speed);
            Console.WriteLine(component.Health);
            Console.WriteLine(component.Protection);
            Console.WriteLine("-------------------------------");
        }
    }

    class HumanWarriorDecorator : Decorator
    {
        public override void SetComponent(Component component)
        {
            if (component is Human)
            {
                this.component = component;
                SetProperties();
            }
            else
            {
                throw new Exception("Unsuitable type");
            }
        }

        public override int Move()
        {
            return Speed + component.Move();
        }
        protected override void SetProperties()
        {
            Attack = 20;
            Speed = 10;
            Health = 50;
            Protection = 20;
        }
    }

    class HumanSwordbeardDecorator : Decorator
    {
        public override void SetComponent(Component component)
        {
            if (component is HumanWarriorDecorator)
            {
                this.component = component;
                SetProperties();
            }
            else
            {
                throw new Exception("Unsuitable type");
            }
        }

        public override int Move()
        {
            return Speed + component.Move();
        }
        protected override void SetProperties()
        {
            Attack = 40;
            Speed = -10;
            Health = 50;
            Protection = 40;
        }
    }

    class HumanArcherDecorator : Decorator
    {
        public override void SetComponent(Component component)
        {
            if (component is HumanWarriorDecorator)
            {
                this.component = component;
                SetProperties();
            }
            else
            {
                throw new Exception("Unsuitable type");
            }
        }

        public override int Move()
        {
            return Speed + component.Move();
        }
        protected override void SetProperties()
        {
            Attack = 20;
            Speed = 20;
            Health = 50;
            Protection = 10;
        }
    }

    class HumanRiderDecorator : Decorator
    {
        public override void SetComponent(Component component)
        {
            if (component is HumanSwordbeardDecorator)
            {
                this.component = component;
                SetProperties();
            }
            else
            {
                throw new Exception("Unsuitable type");
            }
        }

        public override int Move()
        {
            return Speed + component.Move();
        }
        protected override void SetProperties()
        {
            Attack = -10;
            Speed = 40;
            Health = 200;
            Protection = 100;
        }
    }

    class ElfWarriorDecorator : Decorator
    {
        public override void SetComponent(Component component)
        {
            if (component is Elf)
            {
                this.component = component;
                SetProperties();
            }
            else
            {
                throw new Exception("Unsuitable type");
            }
        }

        public override int Move()
        {
            return Speed + component.Move();
        }
        protected override void SetProperties()
        {
            Attack = 20;
            Speed = -10;
            Health = 100;
            Protection = 20;
        }
    }

    class ElfMagicianDecorator : Decorator
    {
        public override void SetComponent(Component component)
        {
            if (component is Elf)
            {
                this.component = component;
                SetProperties();
            }
            else
            {
                throw new Exception("Unsuitable type");
            }
        }

        public override int Move()
        {
            return Speed + component.Move();
        }
        protected override void SetProperties()
        {
            Attack = 10;
            Speed = 10;
            Health = -50;
            Protection = 10;
        }
    }

    class ElfCrossbowmanDecorator : Decorator
    {
        public override void SetComponent(Component component)
        {
            if (component is ElfWarriorDecorator)
            {
                this.component = component;
                SetProperties();
            }
            else
            {
                throw new Exception("Unsuitable type");
            }
        }

        public override int Move()
        {
            return Speed + component.Move();
        }
        protected override void SetProperties()
        {
            Attack = 10;
            Speed = 10;
            Health = 50;
            Protection = -10;
        }
    }

    class ElfEvilMagicianDecorator : Decorator
    {
        public override void SetComponent(Component component)
        {
            if (component is ElfMagicianDecorator)
            {
                this.component = component;
                SetProperties();
            }
            else
            {
                throw new Exception("Unsuitable type");
            }
        }

        public override int Move()
        {
            return Speed + component.Move();
        }
        protected override void SetProperties()
        {
            Attack = 70;
            Speed = 20;
            Health = 0;
            Protection = 0;
        }
    }

    class ElfKindMagicianDecorator : Decorator
    {
        public override void SetComponent(Component component)
        {
            if (component is ElfMagicianDecorator)
            {
                this.component = component;
                SetProperties();
            }
            else
            {
                throw new Exception("Unsuitable type");
            }
        }

        public override int Move()
        {
            return Speed + component.Move();
        }
        protected override void SetProperties()
        {
            Attack = 50;
            Speed = 30;
            Health = 100;
            Protection = 30;
        }
    }

}

