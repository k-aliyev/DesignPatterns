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

        public override void Move()
        {
            if (component != null)
            {
                component.Move();
            }
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
            if(component is Human)
            {
                this.component = component;
                SetProperties();
            }
            else
            {
                throw new Exception("Unsuitable type");
            }
        }

        public override void Move()
        {
            Console.WriteLine($"Moved with speed: {Speed}");
        }
        protected override void SetProperties()
        {
            Attack = component.Attack + 20;
            Speed = component.Speed + 10;
            Health = component.Health + 50;
            Protection = component.Protection + 20;
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

        public override void Move()
        {
            Console.WriteLine($"Moved with speed: {Speed}");
        }
        protected override void SetProperties()
        {
            Attack = component.Attack + 40;
            Speed = component.Speed - 10;
            Health = component.Health + 50;
            Protection = component.Protection + 40;
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

        public override void Move()
        {
            Console.WriteLine($"Moved with speed: {Speed}");
        }
        protected override void SetProperties()
        {
            Attack = component.Attack + 20;
            Speed = component.Speed + 20;
            Health = component.Health + 50;
            Protection = component.Protection + 10;
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

        public override void Move()
        {
            Console.WriteLine($"Moved with speed: {Speed}");
        }
        protected override void SetProperties()
        {
            Attack = component.Attack - 10;
            Speed = component.Speed + 40;
            Health = component.Health + 200;
            Protection = component.Protection + 100;
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

        public override void Move()
        {
            Console.WriteLine($"Moved with speed: {Speed}");
        }
        protected override void SetProperties()
        {
            Attack = component.Attack + 20;
            Speed = component.Speed - 10;
            Health = component.Health + 100;
            Protection = component.Protection + 20;
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

        public override void Move()
        {
            Console.WriteLine($"Moved with speed: {Speed}");
        }
        protected override void SetProperties()
        {
            Attack = component.Attack + 10;
            Speed = component.Speed + 10;
            Health = component.Health - 50;
            Protection = component.Protection + 10;
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

        public override void Move()
        {
            Console.WriteLine($"Moved with speed: {Speed}");
        }
        protected override void SetProperties()
        {
            Attack = component.Attack + 10;
            Speed = component.Speed + 10;
            Health = component.Health + 50;
            Protection = component.Protection - 10;
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

        public override void Move()
        {
            Console.WriteLine($"Moved with speed: {Speed}");
        }
        protected override void SetProperties()
        {
            Attack = component.Attack + 70;
            Speed = component.Speed + 20;
            Health = component.Health + 0;
            Protection = component.Protection + 0;
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

        public override void Move()
        {
            Console.WriteLine($"Moved with speed: {Speed}");
        }
        protected override void SetProperties()
        {
            Attack = component.Attack + 50;
            Speed = component.Speed + 30;
            Health = component.Health + 100;
            Protection = component.Protection + 30;
        }
    }

}

