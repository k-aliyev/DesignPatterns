using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public abstract class Figure
    {
        int[,] arr = new int[4, 4];
        Color color;
        string name;

        public int[,] Arr { get; set; }
        public Color Color { get; set; }
        public string Name { get; set; }
    }

    class TFigure : Figure
    {
        public TFigure()
        {
            int[,] myArr = {
            {1, 1, 1, 0},
            {0, 1, 0, 0},
            {0, 0, 0, 0},
            {0, 0, 0, 0},
            };
            Arr = myArr;
            Name = "T";
            Color color;
            color.red = 244;
            color.green = 244;
            color.blue = 66;
            Color = color;
        }
    }

    class ZFigure : Figure
    {
        public ZFigure()
        {
            int[,] myArr = {
            {1, 1, 0, 0},
            {0, 1, 1, 0},
            {0, 0, 0, 0},
            {0, 0, 0, 0},
            };
            Arr = myArr;
            Name = "Z";
            Color color;
            color.red = 244;
            color.green = 0;
            color.blue = 0;
            Color = color;
        }
    }

    class SFigure : Figure
    {
        public SFigure()
        {
            int[,] myArr = {
            {0, 1, 1, 0},
            {1, 1, 0, 0},
            {0, 0, 0, 0},
            {0, 0, 0, 0},
            };
            Arr = myArr;
            Name = "S";
            Color color;
            color.red = 0;
            color.green = 244;
            color.blue = 0;
            Color = color;
        }
    }

    class JFigure : Figure
    {
        public JFigure()
        {
            int[,] myArr = {
            {0, 1, 0, 0},
            {0, 1, 0, 0},
            {1, 1, 0, 0},
            {0, 0, 0, 0},
            };
            Arr = myArr;
            Name = "J";
            Color color;
            color.red = 0;
            color.green = 154;
            color.blue = 249;
            Color = color;
        }
    }

    class LFigure : Figure
    {
        public LFigure()
        {
            int[,] myArr = {
            {0, 1, 0, 0},
            {0, 1, 0, 0},
            {0, 1, 1, 0},
            {0, 0, 0, 0},
            };
            Arr = myArr;
            Name = "L";
            Color color;
            color.red = 249;
            color.green = 166;
            color.blue = 0;
            Color = color;
        }
    }

    class IFigure : Figure
    {
        public IFigure()
        {
            int[,] myArr = {
            {0, 1, 0, 0},
            {0, 1, 0, 0},
            {0, 1, 0, 0},
            {0, 1, 0, 0},
            };
            Arr = myArr;
            Name = "I";
            Color color;
            color.red = 0;
            color.green = 0;
            color.blue = 244;
            Color = color;
        }
    }

    class OFigure : Figure
    {
        public OFigure()
        {
            int[,] myArr = {
            {1, 1, 0, 0},
            {1, 1, 0, 0},
            {0, 0, 0, 0},
            {0, 0, 0, 0},
            };
            Arr = myArr;
            Name = "O";
            Color color;
            color.red = 249;
            color.green = 0;
            color.blue = 244;
            Color = color;
        }
    }

    public struct Color
    {
        public int red;
        public int blue;
        public int green;
    }
}
