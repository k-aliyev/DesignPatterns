using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    class Program
    {

        class Shop
        {
            public void Create(CarBuilder carBuilder)
            {
                carBuilder.SetName();
                carBuilder.SetBody();
                carBuilder.SetEngine();
                carBuilder.SetWheels();
                carBuilder.SetTransmission();
            }
        }


        static void Main(string[] args)
        {
            DaewooLanos daewooLanos = new DaewooLanos();
            FordProbe fordProbe = new FordProbe();
            UAZPatriot uazPatriot = new UAZPatriot();

            Shop shop = new Shop();

            shop.Create(daewooLanos);
            Car car1 = daewooLanos.Car;
            car1.Info();

            shop.Create(fordProbe);
            Car car2 = fordProbe.Car;
            car2.Info();

            shop.Create(uazPatriot);
            Car car3 = uazPatriot.Car;
            car3.Info();
        }
    }
}
