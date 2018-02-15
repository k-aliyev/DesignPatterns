using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command.cs
{

    public struct Point
    {
        public int num;
        public bool pressed;
    }

    class Command
    {
        public List<Point> points = new List<Point>();
        public void AddPoint(Point point)
        {
            if(points.Count < 10)
            points.Add(point);
        }
    }
}
