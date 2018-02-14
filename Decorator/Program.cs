using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            Human h = new Human();
            HumanWarriorDecorator warrior = new HumanWarriorDecorator();
            HumanSwordbeardDecorator swordbeard = new HumanSwordbeardDecorator();

            h.Move();
            warrior.SetComponent(h);
            warrior.Move();

            //swordbeard.SetComponent(h);//Error, component must be warrior(h - human)
            swordbeard.SetComponent(warrior);//No Error
            swordbeard.Move();


            Elf e = new Elf();
            ElfWarriorDecorator elfWarrior = new ElfWarriorDecorator();
            ElfCrossbowmanDecorator crossbowman = new ElfCrossbowmanDecorator();

            e.Move();
            elfWarrior.SetComponent(e);
            elfWarrior.Move();

            //crossbowman.SetComponent(h);//Error, component must be elfWarrior(e - elf)
            crossbowman.SetComponent(elfWarrior);//No Error
            crossbowman.Move();
        }
    }
}
