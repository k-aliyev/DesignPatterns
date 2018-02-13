using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    abstract class Component
    {
        protected string path;

        public Component(string path)
        {
            this.path = path;
        }
        public abstract void Add(Component c);
        public abstract void Remove(Component c);
        public abstract void Display(int depth);
    }

    class Composite : Component
    {
        private List<Component> _children = new List<Component>();

        public Composite(string path)
          : base(path)
        {
        }

        public override void Add(Component component)
        {
            _children.Add(component);
        }

        public override void Remove(Component component)
        {
            _children.Remove(component);
        }

        public override void Display(int depth)
        {
            Console.WriteLine(new String('-', depth) + path + $" size: {FileManager.GetSize(GetSize())}");

            foreach (Component component in _children)
            {
                component.Display(depth + 2);
            }
        }

        public int GetSize()
        {
            int sum = 0;
            foreach (var item in _children)
            {
                if(item is Leaf)
                {
                    sum += (item as Leaf).Size;
                }
                else
                {
                    sum += (item as Composite).GetSize();
                }
            }
            return sum;
        }
    }

    class Leaf : Component
    {
        public int Size { get; set; }
        public Leaf(string name, int size)
          : base(name)
        {
            Size = size;
        }

        public override void Add(Component c)
        {
            Console.WriteLine("Cannot add to a leaf");
        }

        public override void Remove(Component c)
        {
            Console.WriteLine("Cannot remove from a leaf");
        }

        public override void Display(int depth)
        {
            Console.WriteLine(new String('-', depth) + path + ' ' + FileManager.GetSize(Size));
        }
    }
}
