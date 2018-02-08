using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    class Program
    {
        static void Main(string[] args)
        {
            PC pc1 = new PC();
            pc1.Videocard = "ZOTAC GeForce GT 730";
            pc1.HDD = "Western Digital Blue 500GB 5400rpm 64МB";
            pc1.CPU = "Intel Xeon E5-2648L v4 Tetradeca-core 1.80 GH";

            PC pc2 = new PC();
            pc2.Videocard = "XFX Radeon RX 570 8GB GDDR5 Graphics Card";
            pc2.HDD = "Seagate Expansion 1.5TB External Black";
            pc2.CPU = "AMD Ryzen 7 1700 Processor with Wraith Spire";

            RefinedAbstraction ra = new RefinedAbstraction();

            Implementor videocard = new PC_Videocard();
            Implementor cpu = new PC_CPU();
            Implementor hdd = new PC_HDD();

            Console.WriteLine("-------------------------pc1");

            ra.PC = pc1;
            ra.Implementor = videocard;
            ra.GetInformation();

            ra.Implementor = cpu;
            ra.GetInformation();

            ra.Implementor = hdd;
            ra.GetInformation();
            Console.WriteLine("-------------------------pc2");

            ra.Implementor = videocard;
            ra.GetInformation();

            ra.Implementor = cpu;
            ra.GetInformation();

            ra.Implementor = hdd;
            ra.GetInformation();
            Console.WriteLine("----------------------------");
        }
    }
}
