using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    class Videocard
    {

        public Videocard(string name, bool on, int temp)
        {
            Name = name;
            ON = on;
            Temperature = temp;
        }

        public string Name { get; set; }
        public bool ON { get; set; }
        public int Temperature { get; set; }

        public void CheeckPower()
        {
            if (!ON)
            {
                throw new Exception("Videocard: No Power!");
            }
            Console.WriteLine("Videocard: Power Cheecked!");
        }
        public void CheeckTemperature()
        {
            if (Temperature > 65)
            {
                throw new Exception("Videocard: High Temperature!");
            }
            Console.WriteLine("Videocard: Temperature Cheecked!");
        }
        public void PrintMessege()
        {
            Console.WriteLine("Fuck You!");
        }
    }

    class RAM
    {
        public string Name { get; set; }
        public bool ON { get; set; }
        public int Temperature { get; set; }
        public int Size { get; set; }

        public RAM(string name, bool on, int temp, int size)
        {
            Name = name;
            ON = on;
            Temperature = temp;
            Size = size;
        }

        public void CheeckPower()
        {
            if (!ON)
            {
                throw new Exception("RAM: No Power!");
            }
            Console.WriteLine("RAM: Power Cheecked!");
        }
        public void CheeckTemperature()
        {
            if (Temperature > 85)
            {
                throw new Exception("RAM: High Temperature!");
            }
            Console.WriteLine("RAM: Temperature Cheecked!");
        }
    }

    class Winchester
    {
        public string Name { get; set; }
        public bool ON { get; set; }
        public bool Sector { get; set; }

        public Winchester(string name, bool on, bool sector)
        {
            Name = name;
            ON = on;
            Sector = sector;
        }

        public void CheeckPower()
        {
            if (!ON)
            {
                throw new Exception("Winchester: No Power!");
            }
            Console.WriteLine("Winchester: Power Cheecked!");

        }
        public void CheeckSector()
        {
            if (!Sector)
            {
                throw new Exception("Winchester: No Sector!");
            }
            Console.WriteLine("Winchester: Sector Cheecked!");
        }
    }

    class Disk
    {
        public string Name { get; set; }
        public bool ON { get; set; }
        public bool DiskIn { get; set; }

        public Disk(string name, bool on, bool disk)
        {
            Name = name;
            ON = on;
            DiskIn = disk;
        }

        public void CheeckPower()
        {
            if (!ON)
            {
                throw new Exception("Disk: No Power!");
            }
            Console.WriteLine("Disk: Power Cheecked!");
        }
        public void CheeckDisk()
        {
            if (DiskIn)
            {
                Console.WriteLine("Has Disk!");
            }
            else
            {
                Console.WriteLine("No Disk!");
            }
        }
    }

    class PowerSupply
    {
        public string Name { get; set; }
        public bool ON { get; set; }
        public int Temperature { get; set; }

        public PowerSupply(string name, bool on, int temp)
        {
            Name = name;
            ON = on;
            Temperature = temp;
        }

        public void CheeckPower()
        {
            if (!ON)
            {
                throw new Exception("Power Supply: No Power!");
            }
            Console.WriteLine("Power Supply: Power Cheecked!");
        }
        public void CheeckTemperature()
        {
            if (Temperature > 40)
            {
                throw new Exception("Power Supply: High Temperature!");
            }
            Console.WriteLine("Power Supply: Temperature Cheecked!");
        }
    }

    class Sensors
    {
        public string Name { get; set; }
        public bool ON { get; set; }

        public Sensors(string name, bool on)
        {
            Name = name;
            ON = on;
        }


        public void CheeckPower()
        {
            if (!ON)
            {
                throw new Exception("Sensors: No Power!");
            }
            Console.WriteLine("Sensors: Power Cheecked!");
        }
    }


}
