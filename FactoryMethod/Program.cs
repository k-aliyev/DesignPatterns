using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {

            Creator[] creators = new Creator[7];

            creators[0] = new TFigureCreator();
            creators[1] = new ZFigureCreator();
            creators[2] = new SFigureCreator();
            creators[3] = new JFigureCreator();
            creators[4] = new LFigureCreator();
            creators[5] = new IFigureCreator();
            creators[6] = new OFigureCreator();

            foreach (Creator creator in creators)
            {
                Figure figure = creator.FactoryMethod();
                Console.WriteLine($"Name: {figure.Name}");
                Console.WriteLine($"Color: R({figure.Color.red}) G({figure.Color.green}) B({figure.Color.blue})");
                for (int i = 0; i < 4; i++)
                {
                    for (int j = 0; j < 4; j++)
                    {
                        Console.Write(figure.Arr[i,j].ToString());
                    }
                    Console.WriteLine();
                }
                Console.WriteLine("--------------------------------");
            }
        }
    }
}
