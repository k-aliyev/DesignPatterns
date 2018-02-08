using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    interface Implementor
    {
        void GetInformation(PC pc);
    }

    class RefinedAbstraction
    {
        protected PC pc;
        protected Implementor implementor;

        public Implementor Implementor
        {
            set { implementor = value; }
        }
        public PC PC
        {
            set { pc = value; }
        }

        public void GetInformation()
        {
            implementor.GetInformation(pc);
        }
    }

    class PC_Videocard : Implementor
    {
        public void GetInformation(PC pc)
        {
            Console.WriteLine($"Videocard: {pc.Videocard}");
        }
    }

    class PC_HDD : Implementor
    {
        public void GetInformation(PC pc)
        {
            Console.WriteLine($"HDD: {pc.HDD}");
        }
    }

    class PC_CPU : Implementor
    {
        public void GetInformation(PC pc)
        {
            Console.WriteLine($"CPU: {pc.CPU}");
        }
    }
}
