using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    class Car
    {
        public string Name { get; set; }
        public string Body { get; set; }
        public int Engine { get; set; }
        public int Wheels { get; set; }
        public string Transmission { get; set; }

        public void Info()
        {
            Console.WriteLine("-----------------------");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Body: {Body}");
            Console.WriteLine($"Engine: {Engine}L/sec");
            Console.WriteLine($"Wheels: {Wheels}(R)");
            Console.WriteLine($"Transmission: {Transmission}(R)");
            Console.WriteLine("-----------------------\n");
        }
    }
}
