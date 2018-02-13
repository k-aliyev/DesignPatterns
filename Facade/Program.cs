using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    class Program
    {
        static void Main(string[] args)
        {
            Videocard videocard = new Videocard("Invidia1", false, DateTime.Now.Second);
            RAM ram = new RAM("RAM1", false, DateTime.Now.Second, 34);
            Winchester winchester = new Winchester("winchester1", false, true);
            Disk disk = new Disk("disk1", false, true);
            PowerSupply supply = new PowerSupply("PS1", false, DateTime.Now.Second);
            Sensors sensors = new Sensors("sensors1", false);

            PCFacade pc = new PCFacade(videocard, ram, winchester, disk, supply, sensors);
            //pc.TurnOn();
            pc.AnalysisRAM();
            pc.ClearRAM();
            pc.AnalysisRAM();
        }
    }
}
