using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    class PCFacade
    {
        public Videocard Videocard { get; set; }
        public RAM RAM { get; set; }
        public Winchester Winchester { get; set; }
        public Disk Disk { get; set; }
        public PowerSupply Supply { get; set; }
        public Sensors Sensors { get; set; }

        public PCFacade(Videocard videocard, RAM ram, Winchester winchester, Disk disk, PowerSupply supply, Sensors sensors)
        {
            Videocard = videocard;
            RAM = ram;
            Winchester = winchester;
            Disk = disk;
            Supply = supply;
            Sensors = sensors;
        }

        public void ClearRAM()
        {
            RAM.Size = 0;
            Console.WriteLine("RAM is Clear!");
        }
        public void AnalysisRAM()
        {
            Console.WriteLine($"There are {RAM.Size}MB!");
        }

        public bool TurnOn()
        {
            try
            {
                Supply.ON = true;
                Supply.CheeckPower();
                Sensors.ON = true;
                Sensors.CheeckPower();
                Videocard.ON = true;
                Videocard.CheeckTemperature();
                Supply.CheeckTemperature();
                Videocard.CheeckPower();
                RAM.ON = true;
                RAM.CheeckPower();
                RAM.CheeckTemperature();
                Disk.ON = true;
                Disk.CheeckPower();
                Disk.CheeckDisk();
                Winchester.ON = true;
                Winchester.CheeckPower();
                Winchester.CheeckSector();


                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

    }
}
