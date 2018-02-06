using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    abstract class CarBuilder
    {
        public Car Car { get; protected set; }

        public CarBuilder()
        {
            Car = new Car();
        }

        public abstract void SetName();
        public abstract void SetBody();
        public abstract void SetEngine();
        public abstract void SetWheels();
        public abstract void SetTransmission();
    }

    class DaewooLanos : CarBuilder
    {
        public override void SetName()
        {
            Car.Name = "Daewoo Lanos";
        }

        public override void SetBody()
        {
            Car.Body = "Sedan";
        }

        public override void SetEngine()
        {
            Car.Engine = 98;
        }

        public override void SetWheels()
        {
            Car.Wheels = 13;
        }

        public override void SetTransmission()
        {
            Car.Transmission = "5 Manual";
        }
    }

    class FordProbe  : CarBuilder
    {
        public override void SetName()
        {
            Car.Name = "Ford Probe";
        }

        public override void SetBody()
        {
            Car.Body = "Coupe";
        }

        public override void SetEngine()
        {
            Car.Engine = 160;
        }

        public override void SetWheels()
        {
            Car.Wheels = 14;
        }

        public override void SetTransmission()
        {
            Car.Transmission = "4 Auto";
        }
    }

    class UAZPatriot : CarBuilder
    {
        public override void SetName()
        {
            Car.Name = "UAZ Patriot";
        }

        public override void SetBody()
        {
            Car.Body = "Wagon";
        }

        public override void SetEngine()
        {
            Car.Engine = 120;
        }

        public override void SetWheels()
        {
            Car.Wheels = 16;
        }

        public override void SetTransmission()
        {
            Car.Transmission = "4 Manual";
        }
    }
}
